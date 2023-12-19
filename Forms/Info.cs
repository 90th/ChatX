using ChatX.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatX.Forms {

    public partial class Info : Form {
        private readonly MainForm mainForm;

        public Info(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void setUsername_Click(object sender, EventArgs e) {
            string enteredUsername = usernameTextbox.Text;
            string enteredRoom = roomTextBox.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || !IsUsernameValid(enteredUsername) || mainForm.BlacklistedUsernames.Contains(enteredUsername)) {
                MessageBox.Show("Please enter a valid username with allowed characters.", "ERROR: 1", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(enteredRoom) || mainForm.BlacklistedUsernames.Contains(enteredRoom)) {
                MessageBox.Show("Please enter a valid Room.", "ERROR: 2", MessageBoxButtons.OK);
                return;
            }

            mainForm.room = enteredRoom;
            mainForm.username = enteredUsername;
            Close();
        }

        private bool IsUsernameValid(string username) {
            string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

            return username.All(c => allowedCharacters.Contains(c));
        }

        private void formExit_Click(object sender, EventArgs e) {
            HttpClientInstance.Client.Dispose();
            Environment.Exit(0);
        }

        private void helpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Username Input: Enter your desired username. The default is 'anon'.\n\n" +
                "Room Input: Enter the name of the chat room you want to join. The default is 'general'.\n\n" +
                "Private Room: To create or join a private room, Click the private room button or enter a specific room name. " +
                "A private room will be generated with a random string as its name.\n\n" +
                "Note: Private chat rooms that remain inactive for more than 24 hours will be automatically deleted.\n\n" +
                "Click 'OK' to close this message and start chatting!",
                "ChatX Application Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private static string GenerateRandomString(int minLength, int maxLength) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            int length = random.Next(minLength, maxLength + 1);

            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

        private void roomGenerateButton_Click(object sender, EventArgs e) {
            roomTextBox.Text = GenerateRandomString(8, 20);
        }
    }
}