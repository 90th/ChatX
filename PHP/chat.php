<?php
date_default_timezone_set('UTC');

// Constants
define('DEFAULT_ROOM', 'general');
define('BLACKLIST', ['admin', 'administrator', 'root', 'server', 'system']);
define('MAX_MESSAGES', 20);
define('MESSAGE_TIME_LIMIT', 24 * 60 * 60);

// Use the default room or the specified room in the request
$currentRoom = isset($_GET['room']) ? $_GET['room'] : DEFAULT_ROOM;

// Create a logs directory if it doesn't exist
$logDirectory = "logs";
if (!is_dir($logDirectory)) {
    mkdir($logDirectory, 0755, true); // Reduced permissions for security
}

// Create a log file for each room inside the logs directory
$logFile = "{$logDirectory}/chat_log_{$currentRoom}.log";

if (!file_exists($logFile)) {
    file_put_contents($logFile, "");
}

function cleanOldMessages($logFile, $messageTimeLimit, $maxMessages, $currentRoom) {
    $currentTime = time();
    $lines = file($logFile);

    if ($lines === false) {
        error_log("Error reading log file"); // Log the error instead of dying
        return;
    }

    // Check the number of messages
    $numMessages = count($lines);

    if ($numMessages > $maxMessages) {
        // Preserve the most recent messages, and remove the old ones
        $lines = array_slice($lines, -$maxMessages, $maxMessages);
        file_put_contents($logFile, implode("", $lines));
        return;
    }

    if ($currentRoom !== DEFAULT_ROOM) {
        // Delete the entire log file if it's not in the default room and hasn't been edited in 24+ hours
        $lastMessage = end($lines);
        $lastMessageData = json_decode($lastMessage, true);

        if (is_array($lastMessageData) && isset($lastMessageData['timestamp'])) {
            $lastMessageTime = $lastMessageData['timestamp'];

            if ($currentTime - $lastMessageTime > $messageTimeLimit) {
                unlink($logFile);
                return;
            }
        }
    }

    $newLines = [];
    foreach ($lines as $key => $line) {
        $messageData = json_decode($line, true);

        if (is_array($messageData) && isset($messageData['timestamp'])) {
            $messageTime = $messageData['timestamp'];

            $newLines[] = $line;
        }
    }

    file_put_contents($logFile, implode("", $newLines));
}

function deleteOldLogFiles($logDirectory, $messageTimeLimit) {
    $currentTime = time();
    $files = glob("{$logDirectory}/chat_log_*.log");

    foreach ($files as $file) {
        $lastModifiedTime = filemtime($file);

        if ($currentTime - $lastModifiedTime > $messageTimeLimit) {
            if (unlink($file)) {
                // Log successful deletion
                error_log("Deleted log file: $file");
            } else {
                // Log deletion failure
                error_log("Failed to delete log file: $file");
            }
        }
    }
}

function handleIncomingMessage($logFile, $currentRoom, $blacklist) {
    $postData = file_get_contents("php://input");

    // Validate $postData before using it
    if (empty($postData) || !validateJson($postData)) {
        header('Content-Type: application/json', true, 400);
        echo json_encode(["status" => "Invalid message format"]);
        return;
    }

    $messageData = json_decode($postData);

    if (isset($messageData->username)) {
        // Check if the username is in the blacklist
        $username = strtolower($messageData->username);
        if (in_array($username, $blacklist)) {
            header('Content-Type: application/json');
            echo json_encode(["status" => "Username is blacklisted"]);
            return;
        }

        $messageData->timestamp = time();

        // Use file locking to prevent race conditions
        $fileHandle = fopen($logFile, 'a');
        if (flock($fileHandle, LOCK_EX)) {
            file_put_contents($logFile, json_encode($messageData) . "\n", FILE_APPEND);
            flock($fileHandle, LOCK_UN);
        } else {
            error_log("Error acquiring file lock");
        }
        fclose($fileHandle);

        header('Content-Type: application/json');
        echo json_encode(["status" => "OK"]);
    } else {
        header('Content-Type: application/json', true, 400);
        echo json_encode(["status" => "Invalid message format"]);
    }
}

function getMessages($logFile) {
    $messages = file($logFile);

    if ($messages !== false) {
        header('Content-Type: application/json');
        echo json_encode(array_map('json_decode', $messages));
    } else {
        header('Content-Type: application/json', true, 500);
        echo json_encode(["status" => "Error reading messages"]);
    }
}

function validateJson($data) {
    return json_decode($data) !== null && json_last_error() === JSON_ERROR_NONE;
}

cleanOldMessages($logFile, MESSAGE_TIME_LIMIT, MAX_MESSAGES, $currentRoom);
deleteOldLogFiles($logDirectory, MESSAGE_TIME_LIMIT);

// Include the room in the handleIncomingMessage and getMessages calls
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    handleIncomingMessage($logFile, $currentRoom, BLACKLIST);
} elseif ($_SERVER['REQUEST_METHOD'] === 'GET' && isset($_GET['action']) && $_GET['action'] === 'get_messages') {
    getMessages($logFile);
} else {
    echo "wrong direction\n";
}
?>