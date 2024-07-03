namespace CineVerse.Views.UserControls
{
    partial class UserListItem
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
            picUser = new PictureBox();
            lblUsername = new Label();
            lblNumReviews = new Label();
            btnLists = new Button();
            btnWatched = new Button();
            btnLiked = new Button();
            pnStats = new Panel();
            btnFollow = new Button();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnStats.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.Left;
            picUser.Location = new Point(13, 15);
            picUser.Name = "picUser";
            picUser.Size = new Size(40, 40);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(201, 199, 197);
            lblUsername.Location = new Point(59, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "KaoPun";
            // 
            // lblNumReviews
            // 
            lblNumReviews.Anchor = AnchorStyles.Left;
            lblNumReviews.AutoSize = true;
            lblNumReviews.ForeColor = Color.FromArgb(140, 133, 123);
            lblNumReviews.Location = new Point(59, 40);
            lblNumReviews.Name = "lblNumReviews";
            lblNumReviews.Size = new Size(120, 15);
            lblNumReviews.TabIndex = 2;
            lblNumReviews.Text = "324 films, 272 reviews";
            // 
            // btnLists
            // 
            btnLists.AutoSize = true;
            btnLists.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLists.Dock = DockStyle.Fill;
            btnLists.FlatAppearance.BorderSize = 0;
            btnLists.FlatStyle = FlatStyle.Flat;
            btnLists.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLists.ForeColor = Color.FromArgb(140, 133, 123);
            btnLists.Image = Properties.Resources.grid;
            btnLists.ImageAlign = ContentAlignment.TopCenter;
            btnLists.Location = new Point(54, 0);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(71, 33);
            btnLists.TabIndex = 5;
            btnLists.Text = "708";
            btnLists.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLists.UseVisualStyleBackColor = true;
            // 
            // btnWatched
            // 
            btnWatched.AutoSize = true;
            btnWatched.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWatched.Dock = DockStyle.Left;
            btnWatched.FlatAppearance.BorderSize = 0;
            btnWatched.FlatStyle = FlatStyle.Flat;
            btnWatched.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWatched.ForeColor = Color.FromArgb(140, 133, 123);
            btnWatched.Image = Properties.Resources.eye_green;
            btnWatched.ImageAlign = ContentAlignment.TopCenter;
            btnWatched.Location = new Point(0, 0);
            btnWatched.Name = "btnWatched";
            btnWatched.Size = new Size(54, 33);
            btnWatched.TabIndex = 5;
            btnWatched.Text = "56";
            btnWatched.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWatched.UseVisualStyleBackColor = true;
            // 
            // btnLiked
            // 
            btnLiked.AutoSize = true;
            btnLiked.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLiked.Dock = DockStyle.Right;
            btnLiked.FlatAppearance.BorderSize = 0;
            btnLiked.FlatStyle = FlatStyle.Flat;
            btnLiked.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLiked.ForeColor = Color.FromArgb(140, 133, 123);
            btnLiked.Image = Properties.Resources.liked;
            btnLiked.ImageAlign = ContentAlignment.TopCenter;
            btnLiked.Location = new Point(125, 0);
            btnLiked.Name = "btnLiked";
            btnLiked.Size = new Size(55, 33);
            btnLiked.TabIndex = 5;
            btnLiked.Text = "70";
            btnLiked.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLiked.UseVisualStyleBackColor = true;
            // 
            // pnStats
            // 
            pnStats.Anchor = AnchorStyles.Right;
            pnStats.AutoSize = true;
            pnStats.Controls.Add(btnLists);
            pnStats.Controls.Add(btnLiked);
            pnStats.Controls.Add(btnWatched);
            pnStats.Location = new Point(336, 18);
            pnStats.Name = "pnStats";
            pnStats.Size = new Size(180, 33);
            pnStats.TabIndex = 6;
            // 
            // btnFollow
            // 
            btnFollow.Anchor = AnchorStyles.Right;
            btnFollow.FlatAppearance.BorderSize = 0;
            btnFollow.FlatStyle = FlatStyle.Flat;
            btnFollow.Image = Properties.Resources.add_follow;
            btnFollow.Location = new Point(549, 18);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(33, 33);
            btnFollow.TabIndex = 7;
            btnFollow.UseVisualStyleBackColor = true;
            btnFollow.Click += btnFollow_Click;
            // 
            // UserListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnFollow);
            Controls.Add(pnStats);
            Controls.Add(lblNumReviews);
            Controls.Add(lblUsername);
            Controls.Add(picUser);
            MinimumSize = new Size(440, 0);
            Name = "UserListItem";
            Size = new Size(588, 71);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnStats.ResumeLayout(false);
            pnStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Label lblUsername;
        private Label lblNumReviews;
        private Button btnLists;
        private Button btnWatched;
        private Button btnLiked;
        private Panel pnStats;
        private Button btnFollow;
    }
}
