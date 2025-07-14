namespace GuessTheNameClient.UI
{
    partial class lobbyDeisgn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
           

            this.roomsView = new System.Windows.Forms.Panel();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.panelRoomName = new System.Windows.Forms.Label();
            this.roomPlayersNo = new System.Windows.Forms.Label();
            this.RoomNo = new System.Windows.Forms.Label();
            this.watchRoom = new System.Windows.Forms.Button();
            this.joinRoom = new System.Windows.Forms.Button();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.roomsView.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsView
            // 
            this.roomsView.AutoScroll = true;
            this.roomsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.roomsView.Controls.Add(this.roomPanel);
            this.roomsView.Location = new System.Drawing.Point(42, 27);
            this.roomsView.Name = "roomsView";
            this.roomsView.Size = new System.Drawing.Size(487, 419);
            this.roomsView.TabIndex = 0;
            // 
            // roomPanel
            // 
            this.roomPanel.BackColor = System.Drawing.Color.LightGray;
            this.roomPanel.Controls.Add(this.panelRoomName);
            this.roomPanel.Controls.Add(this.roomPlayersNo);
            this.roomPanel.Controls.Add(this.RoomNo);
            this.roomPanel.Controls.Add(this.watchRoom);
            this.roomPanel.Controls.Add(this.joinRoom);
            this.roomPanel.Location = new System.Drawing.Point(13, 23);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(430, 90);
            this.roomPanel.TabIndex = 0;
            // 
            // panelRoomName
            // 
            this.panelRoomName.BackColor = System.Drawing.Color.White;
            this.panelRoomName.Location = new System.Drawing.Point(21, 57);
            this.panelRoomName.Name = "panelRoomName";
            this.panelRoomName.Size = new System.Drawing.Size(195, 21);
            this.panelRoomName.TabIndex = 4;
            this.panelRoomName.Text = "Room Name: ";
            // 
            // roomPlayersNo
            // 
            this.roomPlayersNo.BackColor = System.Drawing.Color.White;
            this.roomPlayersNo.Location = new System.Drawing.Point(130, 17);
            this.roomPlayersNo.Name = "roomPlayersNo";
            this.roomPlayersNo.Size = new System.Drawing.Size(86, 20);
            this.roomPlayersNo.TabIndex = 3;
            this.roomPlayersNo.Text = "Players: 0";
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSize = true;
            this.RoomNo.BackColor = System.Drawing.Color.White;
            this.RoomNo.Location = new System.Drawing.Point(21, 17);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(78, 16);
            this.RoomNo.TabIndex = 2;
            this.RoomNo.Text = "Room No: 1";
            // 
            // watchRoom
            // 
            this.watchRoom.Location = new System.Drawing.Point(287, 57);
            this.watchRoom.Name = "watchRoom";
            this.watchRoom.Size = new System.Drawing.Size(75, 23);
            this.watchRoom.TabIndex = 1;
            this.watchRoom.Text = "Watch";
            this.watchRoom.UseVisualStyleBackColor = true;
            // 
            // joinRoom
            // 
            this.joinRoom.Location = new System.Drawing.Point(287, 14);
            this.joinRoom.Name = "joinRoom";
            this.joinRoom.Size = new System.Drawing.Size(75, 23);
            this.joinRoom.TabIndex = 0;
            this.joinRoom.Text = "Join Room";
            this.joinRoom.UseVisualStyleBackColor = true;
            // 
            // CreateRoom
            // 
            this.CreateRoom.Location = new System.Drawing.Point(599, 207);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(207, 69);
            this.CreateRoom.TabIndex = 1;
            this.CreateRoom.Text = "Create Room";
            this.CreateRoom.UseVisualStyleBackColor = true;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(1094, 377);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(207, 69);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;

            // 
            // lobbyDeisgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 485);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.CreateRoom);
            this.Controls.Add(this.roomsView);
            this.Name = "lobbyDeisgn";
            this.Text = "lobbyDeisgn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.lobbyDeisgn_Load);
            

            this.roomsView.ResumeLayout(false);
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.Panel roomsView;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Label roomPlayersNo;
        private System.Windows.Forms.Label RoomNo;
        private System.Windows.Forms.Button watchRoom;
        private System.Windows.Forms.Button joinRoom;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label panelRoomName;
    }
}