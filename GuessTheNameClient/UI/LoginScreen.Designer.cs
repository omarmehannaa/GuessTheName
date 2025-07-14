namespace GuessTheNameClient.UI
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            UserNameLabel = new ReaLTaiizor.Controls.FoxBigLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ExitBtn = new ReaLTaiizor.Controls.CyberButton();
            LoginBtn = new ReaLTaiizor.Controls.CyberButton();
            UserName = new ReaLTaiizor.Controls.CyberRichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.BackColor = Color.Transparent;
            UserNameLabel.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.ForeColor = Color.FromArgb(76, 88, 100);
            UserNameLabel.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            UserNameLabel.LineColor = Color.FromArgb(200, 200, 200);
            UserNameLabel.Location = new Point(685, 256);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(361, 51);
            UserNameLabel.TabIndex = 19;
            UserNameLabel.Text = "Enter Your User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(733, -66);
            label1.Name = "label1";
            label1.Size = new Size(269, 21);
            label1.TabIndex = 15;
            label1.Text = "Get Started Login Form Below";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(790, -279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 696);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, -55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(647, 696);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(787, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(158, 223);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(733, 226);
            label2.Name = "label2";
            label2.Size = new Size(269, 21);
            label2.TabIndex = 15;
            label2.Text = "Get Started Login Form Below";
            // 
            // ExitBtn
            // 
            ExitBtn.Alpha = 20;
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Background = true;
            ExitBtn.Background_WidthPen = 4F;
            ExitBtn.BackgroundPen = true;
            ExitBtn.ColorBackground = Color.FromArgb(255, 81, 47);
            ExitBtn.ColorBackground_1 = Color.FromArgb(221, 36, 118);
            ExitBtn.ColorBackground_2 = Color.FromArgb(255, 81, 47);
            ExitBtn.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            ExitBtn.ColorLighting = Color.FromArgb(255, 81, 47);
            ExitBtn.ColorPen_1 = Color.FromArgb(221, 36, 118);
            ExitBtn.ColorPen_2 = Color.FromArgb(255, 81, 47);
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ExitBtn.Effect_1 = true;
            ExitBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            ExitBtn.Effect_1_Transparency = 25;
            ExitBtn.Effect_2 = true;
            ExitBtn.Effect_2_ColorBackground = Color.White;
            ExitBtn.Effect_2_Transparency = 20;
            ExitBtn.Font = new Font("Arial", 11F);
            ExitBtn.ForeColor = Color.FromArgb(245, 245, 245);
            ExitBtn.Lighting = false;
            ExitBtn.LinearGradient_Background = false;
            ExitBtn.LinearGradientPen = false;
            ExitBtn.Location = new Point(769, 468);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.PenWidth = 15;
            ExitBtn.Rounding = true;
            ExitBtn.RoundingInt = 70;
            ExitBtn.Size = new Size(201, 62);
            ExitBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ExitBtn.TabIndex = 16;
            ExitBtn.Tag = "Cyber";
            ExitBtn.TextButton = "Exit";
            ExitBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ExitBtn.Timer_Effect_1 = 5;
            ExitBtn.Timer_RGB = 300;
            ExitBtn.Click += cyberButton1_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Alpha = 20;
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Background = true;
            LoginBtn.Background_WidthPen = 4F;
            LoginBtn.BackgroundPen = true;
            LoginBtn.ColorBackground = Color.FromArgb(255, 81, 47);
            LoginBtn.ColorBackground_1 = Color.FromArgb(221, 36, 118);
            LoginBtn.ColorBackground_2 = Color.FromArgb(255, 81, 47);
            LoginBtn.ColorBackground_Pen = Color.FromArgb(255, 81, 47);
            LoginBtn.ColorLighting = Color.FromArgb(255, 81, 47);
            LoginBtn.ColorPen_1 = Color.FromArgb(221, 36, 118);
            LoginBtn.ColorPen_2 = Color.FromArgb(255, 81, 47);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            LoginBtn.Effect_1 = true;
            LoginBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            LoginBtn.Effect_1_Transparency = 25;
            LoginBtn.Effect_2 = true;
            LoginBtn.Effect_2_ColorBackground = Color.White;
            LoginBtn.Effect_2_Transparency = 20;
            LoginBtn.Font = new Font("Arial", 11F);
            LoginBtn.ForeColor = Color.FromArgb(245, 245, 245);
            LoginBtn.Lighting = false;
            LoginBtn.LinearGradient_Background = false;
            LoginBtn.LinearGradientPen = false;
            LoginBtn.Location = new Point(769, 384);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.PenWidth = 15;
            LoginBtn.Rounding = true;
            LoginBtn.RoundingInt = 70;
            LoginBtn.Size = new Size(201, 62);
            LoginBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            LoginBtn.TabIndex = 17;
            LoginBtn.Tag = "Cyber";
            LoginBtn.TextButton = "Login";
            LoginBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            LoginBtn.Timer_Effect_1 = 5;
            LoginBtn.Timer_RGB = 300;
            LoginBtn.Click += cyberButton2_Click;
            // 
            // UserName
            // 
            UserName.AccessibleName = "";
            UserName.Alpha = 20;
            UserName.BackColor = Color.Transparent;
            UserName.Background_WidthPen = 2F;
            UserName.BackgroundImageLayout = ImageLayout.Center;
            UserName.BackgroundPen = true;
            UserName.ColorBackground = Color.FromArgb(255, 81, 47);
            UserName.ColorBackground_Pen = Color.FromArgb(221, 36, 118);
            UserName.ColorLighting = Color.FromArgb(255, 81, 47);
            UserName.ColorPen_1 = Color.FromArgb(255, 81, 47);
            UserName.ColorPen_2 = Color.FromArgb(255, 81, 47);
            UserName.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            UserName.Font = new Font("Arial", 11F);
            UserName.ForeColor = Color.FromArgb(245, 245, 245);
            UserName.ImeMode = ImeMode.AlphaFull;
            UserName.Lighting = true;
            UserName.LinearGradientPen = false;
            UserName.Location = new Point(685, 313);
            UserName.Name = "UserName";
            UserName.PenWidth = 15;
            UserName.RGB = false;
            UserName.Rounding = true;
            UserName.RoundingInt = 51;
            UserName.Size = new Size(361, 56);
            UserName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            UserName.TabIndex = 18;
            UserName.Tag = "Cyber";
            UserName.TextButton = "";
            UserName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            UserName.Timer_RGB = 300;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UserNameLabel);
            Controls.Add(UserName);
            Controls.Add(LoginBtn);
            Controls.Add(ExitBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "LoginScreen";
            Size = new Size(1080, 581);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FoxBigLabel UserNameLabel;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private ReaLTaiizor.Controls.CyberButton ExitBtn;
        private ReaLTaiizor.Controls.CyberButton LoginBtn;
        private ReaLTaiizor.Controls.CyberRichTextBox UserName;
    }
}
