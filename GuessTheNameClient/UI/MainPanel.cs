using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNameClient.UI
{
    public partial class MainPanel : Form
    {
        private LoginScreen loginScreen;
        private LobbyScreen lobbyScreen;
        public MainPanel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //showPanel();
            loginScreen = new LoginScreen();
            lobbyScreen = new LobbyScreen();
             loginScreen.OnLoginSuccess += LoginScreen_OnLoginSuccess;
            //lobbyScreen.OnLogout += LobbyScreen_OnLogout;
            ShowScreen(loginScreen);

        }
        private void showPanel()
        {
            LoginPanel.Visible = true;
           // LobbyPanel.Visible = false;
            //panel2.Visible = false;
            // panel3.Visible = false;
            // panel4.Visible = false;
        }
        private void ShowScreen(UserControl screen)
        {
            this.Controls.Clear();
            this.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void texticn1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void LoginScreen_OnLoginSuccess(object? sender, EventArgs e)
        {
            ShowScreen(lobbyScreen); // Switch to Lobby Screen
        }

        //private void Login_btn_Click(object sender, EventArgs e)
        //{
        //    //LoginPanel.Controls.Clear();
        //   // LobbyPanel.Visible = true;
        //    // LobbyPanel.Visible = true;
        //    //  Panel LobbyPanel = new Panel();
        //    // LobbyPanel.Dock = DockStyle.Fill;
        //    //  LobbyPanel.BackColor = Color.Blue;
        //    //LoginPanel.Controls.Add(LobbyPanel);
        //    //panel2.Visible = true;
        //    this.Controls.Clear();
        //    this.Controls.Add(LobbyPanel);
        //    LobbyPanel.Dock = DockStyle.Fill;
        //    LobbyPanel.Visible = true;

        //}
    }
}
