namespace GuessTheNameClient.UI
{
    partial class MainPanel
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
            LoginPanel = new Panel();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Location = new Point(1, 1);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1072, 655);
            LoginPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 610);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPanel";
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
    }
}