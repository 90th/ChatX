using ChatX.Forms;
using ChatX.Utils;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatX {

    public partial class MainForm : Form {
        public readonly string serverUrl;
        public string[] BlacklistedUsernames = { "admin", "administrator", "root", "server", "system" };
        public string room = "general";
        public string username;
        private readonly ChatManager chatManager;
        private readonly FormDragHandler dragHandler;
        private readonly TimeSpan messageCooldown = TimeSpan.FromSeconds(1);
        private readonly Random random = new Random();
        private string color;
        private DateTime lastMessageTime = DateTime.MinValue;

        public MainForm() {
            InitializeComponent();

            dragHandler = new FormDragHandler(windowHandle, this);
            dragHandler = new FormDragHandler(labelTitle, this);

            serverUrl = "http://x010.x10.mx/v1/chat.php";

            chatManager = new ChatManager(this);

            //RetrieveMessages(room);

            chatLog.HideSelection = false;

            Panel dummyPanel = new Panel {
                Size = new Size(0, 0)
            };

            Controls.Add(dummyPanel);

            chatLog.Enter += (sender, e) => dummyPanel.Focus();

            chatLog.LinkClicked += (sender, e) => {
                // Open the clicked URL in the default browser
                System.Diagnostics.Process.Start(e.LinkText);
            };
        }

        public void DisplayMessages(dynamic messages) {
            chatLog.SuspendLayout();

            chatLog.Clear();

            foreach (var msg in messages) {
                string msgUsername = msg.username;
                string msgColor = msg.color;
                string msgText = msg.message;

                string formattedUsername = $"{msgUsername}";
                string formattedMessage = $": {msgText}\n";

                chatLog.SelectionColor = GetUserColor(msgColor);
                chatLog.AppendText(formattedUsername);

                chatLog.SelectionColor = chatLog.ForeColor;
                chatLog.AppendText(formattedMessage);
            }
            // Enable URL detection
            chatLog.ResumeLayout();

            chatLog.DetectUrls = true;
        }

        private async void button1_Click(object sender, EventArgs e) {
            string message = userTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(message)) {
                if (CanSendMessage()) {
                    // Use the instance of chatManager to call SendMessageAsync
                    await chatManager.SendMessageAsync(username, color, message, room);
                    userTextbox.Clear();
                    UpdateLastMessageTime();
                } else {
                    // handle cooldown message
                    return;
                }
            }
        }

        private bool CanSendMessage() {
            return DateTime.Now - lastMessageTime >= messageCooldown;
        }

        private void EnableButtons() {
            sendMessage.Enabled = true;
            userTextbox.Enabled = true;
        }

        private void formExit_Click(object sender, EventArgs e) {
            HttpClientInstance.Client.Dispose();
            Environment.Exit(0);
        }

        private Color GetUserColor(string userColor) {
            try {
                return ColorTranslator.FromHtml(userColor);
            } catch (Exception) {
                return Color.Black;
            }
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e) {
            EnableButtons();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            HttpClientInstance.Client.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e) {
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            Info d1 = new Info(this) {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            d1.FormClosed += InfoForm_FormClosed;
            d1.ShowDialog();
            chatManager.RetrieveMessages(room);
            color = SetRandomColor();
        }

        private string SetRandomColor() {
            while (true) {
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = names[random.Next(names.Length)];

                Color randomColor = Color.FromKnownColor(randomColorName);

                if (randomColor != Color.Black && randomColor.GetBrightness() > 0.1) {
                    return ColorTranslator.ToHtml(randomColor);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                if (e.KeyChar == (char)Keys.Enter) {
                    string message = userTextbox.Text.Trim();
                    if (!string.IsNullOrEmpty(message)) {
                        if (CanSendMessage()) {
                            chatManager.SendMessageAsync(username, color, message, room);
                            userTextbox.Clear();
                            UpdateLastMessageTime();
                        } else {
                            // handle cooldown message
                            return;
                        }
                    }

                    e.Handled = true;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void UpdateLastMessageTime() {
            lastMessageTime = DateTime.Now;
        }
    }
}