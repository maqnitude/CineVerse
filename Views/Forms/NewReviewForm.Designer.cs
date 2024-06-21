namespace CineVerse.Views.Forms
{
    partial class NewReviewForm
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
            btnClose = new Button();
            picMoviePoster = new PictureBox();
            lblMovieTitle = new Label();
            pnHeader = new Panel();
            lblReleaseYear = new Label();
            txtReview = new TextBox();
            pnReviewContainer = new Panel();
            pnRatingSection = new Panel();
            pnStars = new Panel();
            picStar5 = new PictureBox();
            picStar4 = new PictureBox();
            picStar3 = new PictureBox();
            picStar2 = new PictureBox();
            picStar1 = new PictureBox();
            pnRatingHeader = new Panel();
            lblRatingStatus = new Label();
            lblRatingHeader = new Label();
            pnLikeSection = new Panel();
            picLike = new PictureBox();
            lblLikeHeader = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).BeginInit();
            pnHeader.SuspendLayout();
            pnReviewContainer.SuspendLayout();
            pnRatingSection.SuspendLayout();
            pnStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            pnRatingHeader.SuspendLayout();
            pnLikeSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLike).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(652, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // picMoviePoster
            // 
            picMoviePoster.Location = new Point(31, 59);
            picMoviePoster.Name = "picMoviePoster";
            picMoviePoster.Size = new Size(150, 225);
            picMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picMoviePoster.TabIndex = 1;
            picMoviePoster.TabStop = false;
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieTitle.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(4, 4);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(158, 23);
            lblMovieTitle.TabIndex = 2;
            lblMovieTitle.Text = "Inside Out 2";
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(lblReleaseYear);
            pnHeader.Controls.Add(lblMovieTitle);
            pnHeader.Location = new Point(200, 59);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(205, 32);
            pnHeader.TabIndex = 5;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReleaseYear.Font = new Font("Segoe UI", 14F);
            lblReleaseYear.ForeColor = Color.FromArgb(173, 196, 214);
            lblReleaseYear.Location = new Point(155, 4);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(53, 26);
            lblReleaseYear.TabIndex = 3;
            lblReleaseYear.Text = "2024";
            // 
            // txtReview
            // 
            txtReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReview.BackColor = Color.FromArgb(43, 47, 49);
            txtReview.BorderStyle = BorderStyle.None;
            txtReview.Font = new Font("Segoe UI", 10.5F);
            txtReview.ForeColor = Color.FromArgb(168, 160, 149);
            txtReview.Location = new Point(14, 13);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.PlaceholderText = "Add a review ...";
            txtReview.Size = new Size(416, 125);
            txtReview.TabIndex = 6;
            // 
            // pnReviewContainer
            // 
            pnReviewContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnReviewContainer.BackColor = Color.FromArgb(43, 47, 49);
            pnReviewContainer.Controls.Add(txtReview);
            pnReviewContainer.Location = new Point(200, 97);
            pnReviewContainer.Name = "pnReviewContainer";
            pnReviewContainer.Size = new Size(446, 152);
            pnReviewContainer.TabIndex = 7;
            // 
            // pnRatingSection
            // 
            pnRatingSection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnRatingSection.Controls.Add(pnStars);
            pnRatingSection.Controls.Add(pnRatingHeader);
            pnRatingSection.Location = new Point(200, 255);
            pnRatingSection.Name = "pnRatingSection";
            pnRatingSection.Size = new Size(160, 52);
            pnRatingSection.TabIndex = 8;
            // 
            // pnStars
            // 
            pnStars.Controls.Add(picStar5);
            pnStars.Controls.Add(picStar4);
            pnStars.Controls.Add(picStar3);
            pnStars.Controls.Add(picStar2);
            pnStars.Controls.Add(picStar1);
            pnStars.Dock = DockStyle.Fill;
            pnStars.Location = new Point(0, 20);
            pnStars.Name = "pnStars";
            pnStars.Size = new Size(160, 32);
            pnStars.TabIndex = 3;
            // 
            // picStar5
            // 
            picStar5.Dock = DockStyle.Left;
            picStar5.Image = Properties.Resources.star_fill_dark;
            picStar5.Location = new Point(128, 0);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(32, 32);
            picStar5.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar5.TabIndex = 6;
            picStar5.TabStop = false;
            // 
            // picStar4
            // 
            picStar4.Dock = DockStyle.Left;
            picStar4.Image = Properties.Resources.star_fill_dark;
            picStar4.Location = new Point(96, 0);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(32, 32);
            picStar4.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar4.TabIndex = 5;
            picStar4.TabStop = false;
            // 
            // picStar3
            // 
            picStar3.Dock = DockStyle.Left;
            picStar3.Image = Properties.Resources.star_fill_dark;
            picStar3.Location = new Point(64, 0);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(32, 32);
            picStar3.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar3.TabIndex = 4;
            picStar3.TabStop = false;
            // 
            // picStar2
            // 
            picStar2.Dock = DockStyle.Left;
            picStar2.Image = Properties.Resources.star_fill_dark;
            picStar2.Location = new Point(32, 0);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(32, 32);
            picStar2.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar2.TabIndex = 3;
            picStar2.TabStop = false;
            // 
            // picStar1
            // 
            picStar1.Dock = DockStyle.Left;
            picStar1.Image = Properties.Resources.star_fill_dark;
            picStar1.Location = new Point(0, 0);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(32, 32);
            picStar1.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar1.TabIndex = 2;
            picStar1.TabStop = false;
            // 
            // pnRatingHeader
            // 
            pnRatingHeader.Controls.Add(lblRatingStatus);
            pnRatingHeader.Controls.Add(lblRatingHeader);
            pnRatingHeader.Dock = DockStyle.Top;
            pnRatingHeader.Location = new Point(0, 0);
            pnRatingHeader.Name = "pnRatingHeader";
            pnRatingHeader.Size = new Size(160, 20);
            pnRatingHeader.TabIndex = 0;
            // 
            // lblRatingStatus
            // 
            lblRatingStatus.Dock = DockStyle.Fill;
            lblRatingStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRatingStatus.ForeColor = Color.FromArgb(200, 195, 188);
            lblRatingStatus.Location = new Point(48, 0);
            lblRatingStatus.Name = "lblRatingStatus";
            lblRatingStatus.Size = new Size(112, 20);
            lblRatingStatus.TabIndex = 1;
            lblRatingStatus.Text = "3 out of 5";
            lblRatingStatus.TextAlign = ContentAlignment.TopRight;
            lblRatingStatus.Visible = false;
            // 
            // lblRatingHeader
            // 
            lblRatingHeader.Dock = DockStyle.Left;
            lblRatingHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRatingHeader.ForeColor = Color.FromArgb(232, 230, 227);
            lblRatingHeader.Location = new Point(0, 0);
            lblRatingHeader.Name = "lblRatingHeader";
            lblRatingHeader.Size = new Size(48, 20);
            lblRatingHeader.TabIndex = 0;
            lblRatingHeader.Text = "Rating";
            // 
            // pnLikeSection
            // 
            pnLikeSection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnLikeSection.Controls.Add(picLike);
            pnLikeSection.Controls.Add(lblLikeHeader);
            pnLikeSection.Location = new Point(611, 254);
            pnLikeSection.Name = "pnLikeSection";
            pnLikeSection.Size = new Size(32, 50);
            pnLikeSection.TabIndex = 8;
            // 
            // picLike
            // 
            picLike.Dock = DockStyle.Fill;
            picLike.Image = Properties.Resources.like_fill_dark;
            picLike.Location = new Point(0, 18);
            picLike.Name = "picLike";
            picLike.Size = new Size(32, 32);
            picLike.SizeMode = PictureBoxSizeMode.StretchImage;
            picLike.TabIndex = 1;
            picLike.TabStop = false;
            picLike.Click += picLike_Click;
            // 
            // lblLikeHeader
            // 
            lblLikeHeader.Dock = DockStyle.Top;
            lblLikeHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLikeHeader.ForeColor = Color.FromArgb(232, 230, 227);
            lblLikeHeader.Location = new Point(0, 0);
            lblLikeHeader.Name = "lblLikeHeader";
            lblLikeHeader.Size = new Size(32, 18);
            lblLikeHeader.TabIndex = 0;
            lblLikeHeader.Text = "Like";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 138, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(216, 244, 202);
            btnSave.Location = new Point(568, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // NewReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 68, 82);
            ClientSize = new Size(695, 370);
            Controls.Add(btnSave);
            Controls.Add(pnLikeSection);
            Controls.Add(pnRatingSection);
            Controls.Add(pnReviewContainer);
            Controls.Add(pnHeader);
            Controls.Add(picMoviePoster);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewReviewForm";
            Text = "NewReviewForm";
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).EndInit();
            pnHeader.ResumeLayout(false);
            pnReviewContainer.ResumeLayout(false);
            pnReviewContainer.PerformLayout();
            pnRatingSection.ResumeLayout(false);
            pnStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            pnRatingHeader.ResumeLayout(false);
            pnLikeSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLike).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private PictureBox picMoviePoster;
        private Label lblMovieTitle;
        private Panel pnHeader;
        private Label lblReleaseYear;
        private TextBox txtReview;
        private Panel pnReviewContainer;
        private Panel pnRatingSection;
        private Panel pnLikeSection;
        private Label lblLikeHeader;
        private Panel pnStars;
        private PictureBox picStar4;
        private PictureBox picStar3;
        private PictureBox picStar2;
        private PictureBox picStar1;
        private PictureBox picLike;
        private Button btnSave;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox picStar5;
        private Panel pnRatingHeader;
        private Label lblRatingStatus;
        private Label lblRatingHeader;
    }
}