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
    public partial class lobbyDeisgn : Form
    {
        private int panelCounter = 1;
        List<string> roomNames = new List<string>();
        public lobbyDeisgn()
        {
            InitializeComponent();
        }

        private void lobbyDeisgn_Load(object sender, EventArgs e)
        {
            roomNames.Add(roomPanel.Name);
        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            addRoom newRoomDialog = new addRoom();
            DialogResult result = newRoomDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
             //   roomNames.Add(newRoomDialog.newRoom);
               // createRoom(newRoomDialog.newRoom, roomNames.Count);
                Invalidate();

            }
        }

        private void createRoom(string name, int roomNo)
        {
            Panel newPanel = new Panel();
            newPanel.Size = new Size(320, 90);
            newPanel.Location = new Point(10, 10 + (100 * panelCounter));
            newPanel.BackColor = Color.LightGray;
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.BorderStyle = BorderStyle.None;

            // Room No 
            Label labelRoomNo = new Label();
            labelRoomNo.Location = new Point(17, 17);
            labelRoomNo.Name = $"RoomNo{roomNo}";
            labelRoomNo.Size = new Size(70, 16);
            labelRoomNo.Text = $"Room No: {roomNo}";
            labelRoomNo.BackColor = Color.White;
            newPanel.Controls.Add(labelRoomNo);

            // Room Name
            Label labelRoomName = new Label();
            labelRoomName.Location = new Point(17, 59);
            labelRoomName.Name = $"RoomName{roomNo}";
            labelRoomName.Size = new Size(150, 16);
            labelRoomName.Text = $"Room Name: {name}";
            labelRoomName.BackColor = Color.White;
            newPanel.Controls.Add(labelRoomName);

            // Room Players
            Label labelRoomPlayers = new Label();
            labelRoomPlayers.Location = new Point(100, 17);
            labelRoomPlayers.Name = $"Room{roomNo}players";
            labelRoomPlayers.Size = new Size(66, 16);
            labelRoomPlayers.Text = "Players: 0";
            labelRoomPlayers.BackColor = Color.White;
            newPanel.Controls.Add(labelRoomPlayers);

            //Join Room Button
            Button joinRoomBTn = new Button();
            joinRoomBTn.Location = new Point(215, 14);
            joinRoomBTn.Name = "joinRoom";
            joinRoomBTn.Size = new Size(60, 23);
            joinRoomBTn.TabIndex = roomNames.Count - 1;
            joinRoomBTn.Text = "Join";
            joinRoomBTn.UseVisualStyleBackColor = true;
            newPanel.Controls.Add(joinRoomBTn);


            //Watch Room Button
            Button watchRoomBTn = new Button();
            watchRoomBTn.Location = new Point(215, 57);
            watchRoomBTn.Name = "watchRoom";
            watchRoomBTn.Size = new Size(60, 23);
            watchRoomBTn.TabIndex = roomNames.Count - 1;
            watchRoomBTn.Text = "Watch";
            watchRoomBTn.UseVisualStyleBackColor = true;
            newPanel.Controls.Add(watchRoomBTn);




            roomsView.Controls.Add(newPanel);
            panelCounter++;
        }
    }
}
