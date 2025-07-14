using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNameClient.UI
{
    public partial class LoginScreen : UserControl
    {
        public event EventHandler OnLoginSuccess = delegate { }; // Ensures it's never null

        public LoginScreen()
        {

            InitializeComponent();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            OnLoginSuccess?.Invoke(this, EventArgs.Empty);
        }
    }
}
