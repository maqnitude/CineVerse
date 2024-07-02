namespace CineVerse.Views.UserControls
{
    partial class PostItem
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
            picAvatar = new PictureBox();
            lblTitle = new Label();
            lblCreatedAt = new Label();
            panel1 = new Panel();
            lblUsername = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(12, 10);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(42, 42);
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitle.Location = new Point(73, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Furiosa - a movie that  never should've been made";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.ForeColor = Color.FromArgb(173, 196, 214);
            lblCreatedAt.Location = new Point(637, 17);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(129, 15);
            lblCreatedAt.TabIndex = 2;
            lblCreatedAt.Text = "Jun 28, 2024 at 2:30 AM";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(697, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 21);
            panel1.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.ForeColor = Color.FromArgb(1, 180, 228);
            lblUsername.Location = new Point(20, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(49, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Markoff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.ForeColor = Color.FromArgb(173, 196, 214);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 0;
            label3.Text = "by";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoSize = true;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(73, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 18);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.ForeColor = Color.FromArgb(173, 196, 214);
            label5.Location = new Point(18, 0);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 1;
            label5.Text = "10";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.upvote;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.AutoSize = true;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(138, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(59, 18);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.ForeColor = Color.FromArgb(173, 196, 214);
            label6.Location = new Point(18, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 1;
            label6.Text = "12";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.reply;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // PostItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 68, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblTitle);
            Controls.Add(picAvatar);
            Name = "PostItem";
            Size = new Size(778, 72);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label lblTitle;
        private Label lblCreatedAt;
        private Panel panel1;
        private Label lblUsername;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox3;
    }
}
