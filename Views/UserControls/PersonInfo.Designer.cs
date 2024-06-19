namespace CineVerse.Views.UserControls
{
    partial class PersonInfo
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
            lblName = new Label();
            picProfileImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProfileImage).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(20, 20, 20);
            lblName.Dock = DockStyle.Bottom;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 270);
            lblName.Name = "lblName";
            lblName.Size = new Size(312, 44);
            lblName.TabIndex = 0;
            lblName.Text = "Anya Taylor-Joy";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picProfileImage
            // 
            picProfileImage.Dock = DockStyle.Fill;
            picProfileImage.Location = new Point(0, 0);
            picProfileImage.Name = "picProfileImage";
            picProfileImage.Size = new Size(312, 270);
            picProfileImage.TabIndex = 1;
            picProfileImage.TabStop = false;
            // 
            // PersonInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 16);
            Controls.Add(picProfileImage);
            Controls.Add(lblName);
            Name = "PersonInfo";
            Size = new Size(312, 314);
            ((System.ComponentModel.ISupportInitialize)picProfileImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private PictureBox picProfileImage;
    }
}
