namespace CineVerse.Views.UserControls
{
    partial class PersonCard
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
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 142);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 26);
            lblName.TabIndex = 0;
            lblName.Text = "Anya Taylor-Joy";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picProfileImage
            // 
            picProfileImage.Dock = DockStyle.Fill;
            picProfileImage.Image = Properties.Resources.default_person;
            picProfileImage.Location = new Point(10, 10);
            picProfileImage.Margin = new Padding(2);
            picProfileImage.Name = "picProfileImage";
            picProfileImage.Size = new Size(98, 132);
            picProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProfileImage.TabIndex = 1;
            picProfileImage.TabStop = false;
            // 
            // PersonCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 16);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picProfileImage);
            Controls.Add(lblName);
            Margin = new Padding(2);
            Name = "PersonCard";
            Size = new Size(118, 178);
            ((System.ComponentModel.ISupportInitialize)picProfileImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private PictureBox picProfileImage;
    }
}
