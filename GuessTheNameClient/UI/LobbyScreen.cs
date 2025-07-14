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
    public partial class LobbyScreen : UserControl
    {
        public event EventHandler? OnLogout;
        public LobbyScreen()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Trigger logout event
            OnLogout?.Invoke(this, EventArgs.Empty);
        }

        private void crownListView1_Click(object sender, EventArgs e)
        {

        }

        private void RoomNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
