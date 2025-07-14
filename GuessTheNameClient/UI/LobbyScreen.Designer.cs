namespace GuessTheNameClient.UI
{
    partial class LobbyScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyScreen));
            LogoutBtn = new ReaLTaiizor.Controls.CyberButton();
            panelListRoom = new ReaLTaiizor.Controls.Panel();
            PlayersCount = new ReaLTaiizor.Controls.LostLabel();
            Players = new ReaLTaiizor.Controls.CrownLabel();
            RoomID = new ReaLTaiizor.Controls.LostLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            RoomNumber = new ReaLTaiizor.Controls.CrownLabel();
            WatchGame = new ReaLTaiizor.Controls.CyberButton();
            JoinRoom = new ReaLTaiizor.Controls.CyberButton();
            CreateRoom = new ReaLTaiizor.Controls.CyberButton();
            panelListRoom.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.Alpha = 20;
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.Background = true;
            LogoutBtn.Background_WidthPen = 4F;
            LogoutBtn.BackgroundPen = true;
            LogoutBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            LogoutBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            LogoutBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            LogoutBtn.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            LogoutBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            LogoutBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            LogoutBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            LogoutBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            LogoutBtn.Effect_1 = true;
            LogoutBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            LogoutBtn.Effect_1_Transparency = 25;
            LogoutBtn.Effect_2 = true;
            LogoutBtn.Effect_2_ColorBackground = Color.White;
            LogoutBtn.Effect_2_Transparency = 20;
            LogoutBtn.Font = new Font("Arial", 11F);
            LogoutBtn.ForeColor = Color.FromArgb(245, 245, 245);
            LogoutBtn.Lighting = false;
            LogoutBtn.LinearGradient_Background = false;
            LogoutBtn.LinearGradientPen = false;
            LogoutBtn.Location = new Point(794, 508);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.PenWidth = 15;
            LogoutBtn.Rounding = true;
            LogoutBtn.RoundingInt = 70;
            LogoutBtn.Size = new Size(227, 56);
            LogoutBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Tag = "Cyber";
            LogoutBtn.TextButton = "LogOut";
            LogoutBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            LogoutBtn.Timer_Effect_1 = 5;
            LogoutBtn.Timer_RGB = 300;
            // 
            // panelListRoom
            // 
            panelListRoom.BackColor = Color.FromArgb(39, 51, 63);
            panelListRoom.Controls.Add(PlayersCount);
            panelListRoom.Controls.Add(Players);
            panelListRoom.Controls.Add(RoomID);
            panelListRoom.Controls.Add(crownLabel1);
            panelListRoom.Controls.Add(RoomNumber);
            panelListRoom.Controls.Add(WatchGame);
            panelListRoom.Controls.Add(JoinRoom);
            panelListRoom.EdgeColor = Color.FromArgb(32, 41, 50);
            panelListRoom.Location = new Point(21, 21);
            panelListRoom.Name = "panelListRoom";
            panelListRoom.Padding = new Padding(5);
            panelListRoom.Size = new Size(270, 118);
            panelListRoom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panelListRoom.TabIndex = 1;
            panelListRoom.Text = "panel1";
            // 
            // PlayersCount
            // 
            PlayersCount.BackColor = Color.FromArgb(64, 64, 64);
            PlayersCount.BackgroundImageLayout = ImageLayout.Center;
            PlayersCount.ForeColor = Color.White;
            PlayersCount.Location = new Point(83, 74);
            PlayersCount.Name = "PlayersCount";
            PlayersCount.Size = new Size(63, 29);
            PlayersCount.TabIndex = 8;
            PlayersCount.Text = "0";
            // 
            // Players
            // 
            Players.AutoSize = true;
            Players.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Players.ForeColor = Color.FromArgb(220, 220, 220);
            Players.Location = new Point(8, 74);
            Players.Name = "Players";
            Players.Size = new Size(72, 23);
            Players.TabIndex = 7;
            Players.Text = "Players :";
            // 
            // RoomID
            // 
            RoomID.BackColor = Color.FromArgb(64, 64, 64);
            RoomID.BackgroundImageLayout = ImageLayout.Center;
            RoomID.ForeColor = Color.White;
            RoomID.Location = new Point(83, 18);
            RoomID.Name = "RoomID";
            RoomID.Size = new Size(63, 29);
            RoomID.TabIndex = 6;
            RoomID.Text = "0";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(83, 48);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(0, 23);
            crownLabel1.TabIndex = 5;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomNumber.ForeColor = Color.FromArgb(220, 220, 220);
            RoomNumber.Location = new Point(8, 18);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(86, 23);
            RoomNumber.TabIndex = 4;
            RoomNumber.Text = "Room ID :";
            RoomNumber.Click += RoomNumber_Click;
            // 
            // WatchGame
            // 
            WatchGame.Alpha = 20;
            WatchGame.BackColor = Color.Transparent;
            WatchGame.Background = true;
            WatchGame.Background_WidthPen = 4F;
            WatchGame.BackgroundPen = true;
            WatchGame.ColorBackground = Color.FromArgb(37, 52, 68);
            WatchGame.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            WatchGame.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            WatchGame.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            WatchGame.ColorLighting = Color.FromArgb(29, 200, 238);
            WatchGame.ColorPen_1 = Color.FromArgb(37, 52, 68);
            WatchGame.ColorPen_2 = Color.FromArgb(41, 63, 86);
            WatchGame.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            WatchGame.Effect_1 = true;
            WatchGame.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            WatchGame.Effect_1_Transparency = 25;
            WatchGame.Effect_2 = true;
            WatchGame.Effect_2_ColorBackground = Color.White;
            WatchGame.Effect_2_Transparency = 20;
            WatchGame.Font = new Font("Arial", 11F);
            WatchGame.ForeColor = Color.FromArgb(245, 245, 245);
            WatchGame.Lighting = false;
            WatchGame.LinearGradient_Background = false;
            WatchGame.LinearGradientPen = false;
            WatchGame.Location = new Point(167, 74);
            WatchGame.Name = "WatchGame";
            WatchGame.PenWidth = 15;
            WatchGame.Rounding = true;
            WatchGame.RoundingInt = 70;
            WatchGame.Size = new Size(85, 36);
            WatchGame.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            WatchGame.TabIndex = 3;
            WatchGame.Tag = "Cyber";
            WatchGame.TextButton = "Watch";
            WatchGame.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            WatchGame.Timer_Effect_1 = 5;
            WatchGame.Timer_RGB = 300;
            // 
            // JoinRoom
            // 
            JoinRoom.Alpha = 20;
            JoinRoom.BackColor = Color.Transparent;
            JoinRoom.Background = true;
            JoinRoom.Background_WidthPen = 4F;
            JoinRoom.BackgroundPen = true;
            JoinRoom.ColorBackground = Color.FromArgb(37, 52, 68);
            JoinRoom.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            JoinRoom.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            JoinRoom.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            JoinRoom.ColorLighting = Color.FromArgb(29, 200, 238);
            JoinRoom.ColorPen_1 = Color.FromArgb(37, 52, 68);
            JoinRoom.ColorPen_2 = Color.FromArgb(41, 63, 86);
            JoinRoom.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            JoinRoom.Effect_1 = true;
            JoinRoom.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            JoinRoom.Effect_1_Transparency = 25;
            JoinRoom.Effect_2 = true;
            JoinRoom.Effect_2_ColorBackground = Color.White;
            JoinRoom.Effect_2_Transparency = 20;
            JoinRoom.Font = new Font("Arial", 11F);
            JoinRoom.ForeColor = Color.FromArgb(245, 245, 245);
            JoinRoom.Lighting = false;
            JoinRoom.LinearGradient_Background = false;
            JoinRoom.LinearGradientPen = false;
            JoinRoom.Location = new Point(167, 8);
            JoinRoom.Name = "JoinRoom";
            JoinRoom.PenWidth = 15;
            JoinRoom.Rounding = true;
            JoinRoom.RoundingInt = 70;
            JoinRoom.Size = new Size(85, 42);
            JoinRoom.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            JoinRoom.TabIndex = 2;
            JoinRoom.Tag = "Cyber";
            JoinRoom.TextButton = "Join";
            JoinRoom.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            JoinRoom.Timer_Effect_1 = 5;
            JoinRoom.Timer_RGB = 300;
            // 
            // CreateRoom
            // 
            CreateRoom.Alpha = 20;
            CreateRoom.BackColor = Color.Transparent;
            CreateRoom.Background = true;
            CreateRoom.Background_WidthPen = 4F;
            CreateRoom.BackgroundPen = true;
            CreateRoom.ColorBackground = Color.FromArgb(37, 52, 68);
            CreateRoom.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            CreateRoom.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            CreateRoom.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            CreateRoom.ColorLighting = Color.FromArgb(29, 200, 238);
            CreateRoom.ColorPen_1 = Color.FromArgb(37, 52, 68);
            CreateRoom.ColorPen_2 = Color.FromArgb(41, 63, 86);
            CreateRoom.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            CreateRoom.Effect_1 = true;
            CreateRoom.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            CreateRoom.Effect_1_Transparency = 25;
            CreateRoom.Effect_2 = true;
            CreateRoom.Effect_2_ColorBackground = Color.White;
            CreateRoom.Effect_2_Transparency = 20;
            CreateRoom.Font = new Font("Arial", 11F);
            CreateRoom.ForeColor = Color.FromArgb(245, 245, 245);
            CreateRoom.Lighting = false;
            CreateRoom.LinearGradient_Background = false;
            CreateRoom.LinearGradientPen = false;
            CreateRoom.Location = new Point(735, 437);
            CreateRoom.Name = "CreateRoom";
            CreateRoom.PenWidth = 15;
            CreateRoom.Rounding = true;
            CreateRoom.RoundingInt = 70;
            CreateRoom.Size = new Size(329, 65);
            CreateRoom.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            CreateRoom.TabIndex = 2;
            CreateRoom.Tag = "Cyber";
            CreateRoom.TextButton = "Create Room";
            CreateRoom.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            CreateRoom.Timer_Effect_1 = 5;
            CreateRoom.Timer_RGB = 300;
            // 
            // LobbyScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(CreateRoom);
            Controls.Add(panelListRoom);
            Controls.Add(LogoutBtn);
            DoubleBuffered = true;
            Name = "LobbyScreen";
            Size = new Size(1091, 581);
            panelListRoom.ResumeLayout(false);
            panelListRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton LogoutBtn;
        private ReaLTaiizor.Controls.Panel panelListRoom;
        private ReaLTaiizor.Controls.CyberButton WatchGame;
        private ReaLTaiizor.Controls.CyberButton JoinRoom;
        private ReaLTaiizor.Controls.CrownLabel RoomNumber;
        private ReaLTaiizor.Controls.LostLabel RoomID;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.LostLabel PlayersCount;
        private ReaLTaiizor.Controls.CrownLabel Players;
        private ReaLTaiizor.Controls.CyberButton CreateRoom;
    }
}
