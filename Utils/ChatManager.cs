using System.Threading.Tasks;
using System;
using ChatX.Utils;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;

namespace ChatX {

    internal class ChatManager : IDisposable {
        private readonly MainForm mainForm;

        public ChatManager(MainForm mainForm) {
            this.mainForm = mainForm;
        }

        public async Task SendMessageAsync(string username, string color, string message, string room) {
            try {
                var messageData = new { username, color, message };
                var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(messageData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Use the shared HttpClient instance
                var response = await HttpClientInstance.Client.PostAsync($"{mainForm.serverUrl}?room={room}", content);

                if (!response.IsSuccessStatusCode) {
                    MessageBox.Show($"Error sending message. Status code: {response.StatusCode}");
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message} -- 13");
            }
        }

        public async void RetrieveMessages(string room) {
            while (true) {
                try {
                    // Include the room in the URL
                    var response = await HttpClientInstance.Client.GetAsync($"{mainForm.serverUrl}?action=get_messages&room={room}");
                    if (response.IsSuccessStatusCode) {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        dynamic messages = null;

                        try {
                            messages = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                            mainForm.DisplayMessages(messages);
                        } catch (Newtonsoft.Json.JsonException) {
                            // Handle non-JSON response (e.g., display an error message)
                            MessageBox.Show($"Unexpected response format: {responseBody}");
                        }
                    } else {
                        MessageBox.Show($"Error retrieving messages. Status code: {response.StatusCode}");
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Error: {ex.Message} -- 12"); // task was cancled error
                }

                await Task.Delay(500);
            }
        }

        public void Dispose() {
            // No need to dispose HttpClientInstance.Client here
            // HttpClientInstance handles its own disposal
        }
    }
}