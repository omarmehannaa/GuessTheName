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
    public partial class addRoom : Form
    {
      //  public string newRoom { get; private set; }
        public addRoom()
        {
            InitializeComponent();
        }
        private void closeNewRoomForm_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmNewRoomName_Click(object sender, EventArgs e)
        {
       //     this.newRoom = newRoomName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void addRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
