using System;
using System.Drawing;
using System.Windows.Forms;
using GuessTheNameClient.ClientCore;

using GuessTheNameClient.Networking;



namespace GuessTheNameClient.UI
{
    public partial class LoginForm : Form
    {
        private readonly GameClient _client = new();



        private Button? button1;
        private Button? btnTestSerialization;

        public LoginForm()
        {

            InitializeCustomComponents();
            MessageBox.Show("Welcome to Guess The Name!", "Welcome",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeCustomComponents()
        {

            // Configure form
            this.Text = "Server Connection Test";
            this.ClientSize = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Test Connection Button
            button1 = new Button
            {
                Text = "Test Connection",
                Location = new Point(80, 60),
                Size = new Size(120, 40)
            };
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            // Test Serialization Button
            btnTestSerialization = new Button
            {
                Text = "Test Serialization",
                Location = new Point(80, 120),
                Size = new Size(120, 40)
            };
            btnTestSerialization.Click += BtnTestSerialization_Click;
            this.Controls.Add(btnTestSerialization);
        }

        private async void BtnTestSerialization_Click(object? sender, EventArgs? e)
        {
            try
            {
                if (_client.IsConnected && _client.Network != null)
                {
                    await _client.Network.TestSerializationAsync();
                }
                else
                {
                    MessageBox.Show("Connect to server first!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Serialization Test Failed: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void button1_Click(object? sender, EventArgs? e)
        {
            try
            {
                if (!_client.IsConnected)
                {
                    await _client.Connect("127.0.0.1", 8888);
                    MessageBox.Show("Connected to server!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Already connected!", "Info",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}