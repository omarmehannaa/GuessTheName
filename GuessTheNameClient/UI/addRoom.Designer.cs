namespace GuessTheNameClient.UI
{
    partial class addRoom
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
            this.newRoomName = new System.Windows.Forms.TextBox();
            this.confirmNewRoomName = new System.Windows.Forms.Button();
            this.newRoomLabel = new System.Windows.Forms.Label();
            this.closeNewRoomForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newRoomName
            // 
            this.newRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.newRoomName.Location = new System.Drawing.Point(205, 158);
            this.newRoomName.Name = "newRoomName";
            this.newRoomName.Size = new System.Drawing.Size(421, 30);
            this.newRoomName.TabIndex = 0;
            // 
            // confirmNewRoomName
            // 
            this.confirmNewRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewRoomName.Location = new System.Drawing.Point(429, 232);
            this.confirmNewRoomName.Name = "confirmNewRoomName";
            this.confirmNewRoomName.Size = new System.Drawing.Size(156, 55);
            this.confirmNewRoomName.TabIndex = 1;
            this.confirmNewRoomName.Text = "Confirm";
            this.confirmNewRoomName.UseVisualStyleBackColor = true;
            this.confirmNewRoomName.Click += new System.EventHandler(this.confirmNewRoomName_Click);
            // 
            // newRoomLabel
            // 
            this.newRoomLabel.AutoSize = true;
            this.newRoomLabel.BackColor = System.Drawing.Color.White;
            this.newRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.newRoomLabel.Location = new System.Drawing.Point(211, 86);
            this.newRoomLabel.Name = "newRoomLabel";
            this.newRoomLabel.Size = new System.Drawing.Size(245, 46);
            this.newRoomLabel.TabIndex = 2;
            this.newRoomLabel.Text = "Room Name";
            // 
            // closeNewRoomForm
            // 
            this.closeNewRoomForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeNewRoomForm.Location = new System.Drawing.Point(235, 232);
            this.closeNewRoomForm.Name = "closeNewRoomForm";
            this.closeNewRoomForm.Size = new System.Drawing.Size(156, 55);
            this.closeNewRoomForm.TabIndex = 3;
            this.closeNewRoomForm.Text = "Close";
            this.closeNewRoomForm.UseVisualStyleBackColor = true;
            this.closeNewRoomForm.Click += new System.EventHandler(this.closeNewRoomForm_Click);
            // 

            // addRoom
            // 


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeNewRoomForm);
            this.Controls.Add(this.newRoomLabel);
            this.Controls.Add(this.confirmNewRoomName);
            this.Controls.Add(this.newRoomName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "addRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addRoom";
            this.Load += new System.EventHandler(this.addRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newRoomName;
        private System.Windows.Forms.Button confirmNewRoomName;
        private System.Windows.Forms.Label newRoomLabel;
        private System.Windows.Forms.Button closeNewRoomForm;
    }
}