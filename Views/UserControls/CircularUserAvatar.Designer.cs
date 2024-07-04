namespace CineVerse.Views.UserControls
{
    partial class CircularUserAvatar
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
            picAvatar = new CustomControls.CircularPictureBox();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(14, 0);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(40, 40);
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            picAvatar.MouseEnter += picAvatar_MouseEnter;
            picAvatar.MouseLeave += picAvatar_MouseLeave;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.FromArgb(54, 68, 82);
            lblUsername.Dock = DockStyle.Bottom;
            lblUsername.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(173, 196, 214);
            lblUsername.Location = new Point(0, 43);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(69, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "maqnitude";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.Visible = false;
            // 
            // CircularUserAvatar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Name = "CircularUserAvatar";
            Size = new Size(69, 58);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CircularPictureBox picAvatar;
        private Label lblUsername;
    }
}
