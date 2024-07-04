namespace CineVerse.Views.UserControls
{
    partial class ActivityItemReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityItemReview));
            picUser = new PictureBox();
            pnContent = new Panel();
            lblBodyText = new Label();
            pnFooter = new Panel();
            lblNumLikes = new Label();
            btnLike = new Button();
            pnBelowHeadline = new Panel();
            pnRating = new Panel();
            lblRating = new Label();
            picStar = new PictureBox();
            lblMaxRating = new Label();
            pnHeadline = new Panel();
            lblMovieReleaseYear = new Label();
            lblMovieTitle = new Label();
            pnAttribution = new Panel();
            lblTime = new Label();
            pnContext = new Panel();
            lblUsername = new Label();
            lblActivity = new Label();
            picMoviePoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnContent.SuspendLayout();
            pnFooter.SuspendLayout();
            pnBelowHeadline.SuspendLayout();
            pnRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).BeginInit();
            pnHeadline.SuspendLayout();
            pnAttribution.SuspendLayout();
            pnContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).BeginInit();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.user_big;
            picUser.Location = new Point(3, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(24, 24);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // pnContent
            // 
            pnContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnContent.AutoSize = true;
            pnContent.Controls.Add(lblBodyText);
            pnContent.Controls.Add(pnFooter);
            pnContent.Controls.Add(pnBelowHeadline);
            pnContent.Controls.Add(pnHeadline);
            pnContent.Controls.Add(pnAttribution);
            pnContent.Location = new Point(119, 3);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(715, 225);
            pnContent.TabIndex = 1;
            // 
            // lblBodyText
            // 
            lblBodyText.Dock = DockStyle.Fill;
            lblBodyText.ForeColor = Color.FromArgb(178, 172, 162);
            lblBodyText.Location = new Point(0, 68);
            lblBodyText.Name = "lblBodyText";
            lblBodyText.Padding = new Padding(3);
            lblBodyText.Size = new Size(715, 137);
            lblBodyText.TabIndex = 14;
            lblBodyText.Text = resources.GetString("lblBodyText.Text");
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(lblNumLikes);
            pnFooter.Controls.Add(btnLike);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 205);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(715, 20);
            pnFooter.TabIndex = 13;
            // 
            // lblNumLikes
            // 
            lblNumLikes.Anchor = AnchorStyles.Left;
            lblNumLikes.AutoSize = true;
            lblNumLikes.ForeColor = Color.FromArgb(157, 148, 136);
            lblNumLikes.Location = new Point(99, 3);
            lblNumLikes.Name = "lblNumLikes";
            lblNumLikes.Size = new Size(60, 15);
            lblNumLikes.TabIndex = 6;
            lblNumLikes.Text = "1,104 likes";
            // 
            // btnLike
            // 
            btnLike.Anchor = AnchorStyles.Left;
            btnLike.AutoSize = true;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.ForeColor = Color.FromArgb(157, 148, 136);
            btnLike.Image = Properties.Resources.like_small;
            btnLike.Location = new Point(2, -3);
            btnLike.Margin = new Padding(2);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(94, 25);
            btnLike.TabIndex = 5;
            btnLike.Text = "Like review";
            btnLike.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLike.UseVisualStyleBackColor = true;
            // 
            // pnBelowHeadline
            // 
            pnBelowHeadline.Controls.Add(pnRating);
            pnBelowHeadline.Dock = DockStyle.Top;
            pnBelowHeadline.Location = new Point(0, 48);
            pnBelowHeadline.Name = "pnBelowHeadline";
            pnBelowHeadline.Size = new Size(715, 20);
            pnBelowHeadline.TabIndex = 12;
            // 
            // pnRating
            // 
            pnRating.AutoSize = true;
            pnRating.Controls.Add(lblRating);
            pnRating.Controls.Add(picStar);
            pnRating.Controls.Add(lblMaxRating);
            pnRating.Dock = DockStyle.Left;
            pnRating.Location = new Point(0, 0);
            pnRating.Name = "pnRating";
            pnRating.Size = new Size(62, 20);
            pnRating.TabIndex = 10;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Dock = DockStyle.Fill;
            lblRating.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ScrollBar;
            lblRating.Location = new Point(20, 0);
            lblRating.Margin = new Padding(0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(18, 20);
            lblRating.TabIndex = 7;
            lblRating.Text = "4";
            lblRating.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picStar
            // 
            picStar.Dock = DockStyle.Left;
            picStar.Image = Properties.Resources.star;
            picStar.Location = new Point(0, 0);
            picStar.Margin = new Padding(2);
            picStar.Name = "picStar";
            picStar.Size = new Size(20, 20);
            picStar.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar.TabIndex = 6;
            picStar.TabStop = false;
            // 
            // lblMaxRating
            // 
            lblMaxRating.Dock = DockStyle.Right;
            lblMaxRating.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaxRating.ForeColor = SystemColors.ScrollBar;
            lblMaxRating.Location = new Point(38, 0);
            lblMaxRating.Margin = new Padding(0);
            lblMaxRating.Name = "lblMaxRating";
            lblMaxRating.Size = new Size(24, 20);
            lblMaxRating.TabIndex = 8;
            lblMaxRating.Text = "/5";
            lblMaxRating.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnHeadline
            // 
            pnHeadline.Controls.Add(lblMovieReleaseYear);
            pnHeadline.Controls.Add(lblMovieTitle);
            pnHeadline.Dock = DockStyle.Top;
            pnHeadline.Location = new Point(0, 18);
            pnHeadline.Name = "pnHeadline";
            pnHeadline.Size = new Size(715, 30);
            pnHeadline.TabIndex = 11;
            // 
            // lblMovieReleaseYear
            // 
            lblMovieReleaseYear.AutoSize = true;
            lblMovieReleaseYear.Dock = DockStyle.Fill;
            lblMovieReleaseYear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieReleaseYear.ForeColor = Color.FromArgb(168, 160, 149);
            lblMovieReleaseYear.Location = new Point(259, 0);
            lblMovieReleaseYear.Name = "lblMovieReleaseYear";
            lblMovieReleaseYear.Size = new Size(56, 25);
            lblMovieReleaseYear.TabIndex = 1;
            lblMovieReleaseYear.Text = "2024";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Dock = DockStyle.Left;
            lblMovieTitle.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(0, 0);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(259, 25);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "A Quiet Place: Day One";
            // 
            // pnAttribution
            // 
            pnAttribution.Controls.Add(lblTime);
            pnAttribution.Controls.Add(pnContext);
            pnAttribution.Dock = DockStyle.Top;
            pnAttribution.Location = new Point(0, 0);
            pnAttribution.Name = "pnAttribution";
            pnAttribution.Size = new Size(715, 18);
            pnAttribution.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Right;
            lblTime.ForeColor = Color.FromArgb(168, 160, 149);
            lblTime.Location = new Point(695, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(20, 15);
            lblTime.TabIndex = 1;
            lblTime.Text = "1d";
            // 
            // pnContext
            // 
            pnContext.AutoSize = true;
            pnContext.Controls.Add(lblUsername);
            pnContext.Controls.Add(lblActivity);
            pnContext.Dock = DockStyle.Left;
            pnContext.Location = new Point(0, 0);
            pnContext.Name = "pnContext";
            pnContext.Size = new Size(117, 18);
            pnContext.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.ForeColor = Color.FromArgb(164, 184, 200);
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "CinemaJoe";
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Dock = DockStyle.Right;
            lblActivity.ForeColor = Color.FromArgb(157, 148, 136);
            lblActivity.Location = new Point(65, 0);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(52, 15);
            lblActivity.TabIndex = 0;
            lblActivity.Text = "watched";
            // 
            // picMoviePoster
            // 
            picMoviePoster.Location = new Point(33, 3);
            picMoviePoster.Name = "picMoviePoster";
            picMoviePoster.Size = new Size(76, 111);
            picMoviePoster.TabIndex = 2;
            picMoviePoster.TabStop = false;
            // 
            // ActivityItemReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picMoviePoster);
            Controls.Add(pnContent);
            Controls.Add(picUser);
            Name = "ActivityItemReview";
            Size = new Size(844, 235);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnContent.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            pnBelowHeadline.ResumeLayout(false);
            pnBelowHeadline.PerformLayout();
            pnRating.ResumeLayout(false);
            pnRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).EndInit();
            pnHeadline.ResumeLayout(false);
            pnHeadline.PerformLayout();
            pnAttribution.ResumeLayout(false);
            pnAttribution.PerformLayout();
            pnContext.ResumeLayout(false);
            pnContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Panel pnContent;
        private PictureBox picMoviePoster;
        private Panel pnAttribution;
        private Panel pnContext;
        private Label lblUsername;
        private Label lblActivity;
        private Label lblTime;
        private Panel pnRating;
        private Label lblRating;
        private PictureBox picStar;
        private Label lblMaxRating;
        private Panel pnHeadline;
        private Label lblMovieReleaseYear;
        private Label lblMovieTitle;
        private Panel pnBelowHeadline;
        private Panel pnFooter;
        private Label lblBodyText;
        private Button btnLike;
        private Label lblNumLikes;
    }
}
