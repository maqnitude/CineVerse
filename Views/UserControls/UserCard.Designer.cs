namespace CineVerse.Views.UserControls
{
    partial class UserCard
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
            picUserAvatar = new PictureBox();
            pnFooter = new Panel();
            pnStats = new Panel();
            lblNumReviews = new Label();
            lblNumMovies = new Label();
            lblUsername = new Label();
            picFollow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            pnFooter.SuspendLayout();
            pnStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFollow).BeginInit();
            SuspendLayout();
            // 
            // picUserAvatar
            // 
            picUserAvatar.Dock = DockStyle.Top;
            picUserAvatar.Location = new Point(0, 0);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.Size = new Size(137, 148);
            picUserAvatar.TabIndex = 0;
            picUserAvatar.TabStop = false;
            // 
            // pnFooter
            // 
            pnFooter.AutoSize = true;
            pnFooter.Controls.Add(pnStats);
            pnFooter.Controls.Add(lblUsername);
            pnFooter.Dock = DockStyle.Fill;
            pnFooter.Location = new Point(0, 148);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(137, 59);
            pnFooter.TabIndex = 1;
            // 
            // pnStats
            // 
            pnStats.AutoSize = true;
            pnStats.Controls.Add(lblNumReviews);
            pnStats.Controls.Add(lblNumMovies);
            pnStats.Location = new Point(3, 28);
            pnStats.Name = "pnStats";
            pnStats.Size = new Size(120, 22);
            pnStats.TabIndex = 1;
            // 
            // lblNumReviews
            // 
            lblNumReviews.AutoSize = true;
            lblNumReviews.Dock = DockStyle.Fill;
            lblNumReviews.ForeColor = Color.FromArgb(149, 142, 133);
            lblNumReviews.Location = new Point(49, 0);
            lblNumReviews.Name = "lblNumReviews";
            lblNumReviews.Size = new Size(71, 15);
            lblNumReviews.TabIndex = 1;
            lblNumReviews.Text = "1.4K reviews";
            // 
            // lblNumMovies
            // 
            lblNumMovies.AutoSize = true;
            lblNumMovies.Dock = DockStyle.Left;
            lblNumMovies.ForeColor = Color.FromArgb(149, 142, 133);
            lblNumMovies.Location = new Point(0, 0);
            lblNumMovies.Name = "lblNumMovies";
            lblNumMovies.Size = new Size(49, 15);
            lblNumMovies.TabIndex = 0;
            lblNumMovies.Text = "2K films";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(201, 199, 197);
            lblUsername.Location = new Point(3, 4);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Cinema Joe";
            // 
            // picFollow
            // 
            picFollow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFollow.Image = Properties.Resources.add_follow;
            picFollow.Location = new Point(104, 114);
            picFollow.Name = "picFollow";
            picFollow.Size = new Size(30, 30);
            picFollow.SizeMode = PictureBoxSizeMode.StretchImage;
            picFollow.TabIndex = 2;
            picFollow.TabStop = false;
            // 
            // UserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picFollow);
            Controls.Add(pnFooter);
            Controls.Add(picUserAvatar);
            Name = "UserCard";
            Size = new Size(137, 207);
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).EndInit();
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            pnStats.ResumeLayout(false);
            pnStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFollow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUserAvatar;
        private Panel pnFooter;
        private Label lblUsername;
        private Panel pnStats;
        private Label lblNumReviews;
        private Label lblNumMovies;
        private PictureBox picFollow;
    }
}
