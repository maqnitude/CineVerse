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
            starRatingControl = new UserControls.StarRatingControl();
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
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Dock = DockStyle.Fill;
            lblMovieTitle.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(0, 0);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(151, 27);
            lblMovieTitle.TabIndex = 2;
            lblMovieTitle.Text = "Inside Out 2";
            // 
            // pnHeader
            // 
            pnHeader.AutoSize = true;
            pnHeader.Controls.Add(lblMovieTitle);
            pnHeader.Controls.Add(lblReleaseYear);
            pnHeader.Location = new Point(200, 59);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(203, 27);
            pnHeader.TabIndex = 5;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Dock = DockStyle.Right;
            lblReleaseYear.Font = new Font("Segoe UI", 14F);
            lblReleaseYear.ForeColor = Color.FromArgb(173, 196, 214);
            lblReleaseYear.Location = new Point(151, 0);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(52, 25);
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
            pnRatingSection.Controls.Add(starRatingControl);
            pnRatingSection.Controls.Add(pnRatingHeader);
            pnRatingSection.Location = new Point(200, 255);
            pnRatingSection.Name = "pnRatingSection";
            pnRatingSection.Size = new Size(160, 52);
            pnRatingSection.TabIndex = 8;
            // 
            // starRatingControl
            // 
            starRatingControl.BackColor = Color.Transparent;
            starRatingControl.Dock = DockStyle.Fill;
            starRatingControl.Location = new Point(0, 20);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.Rating = 0D;
            starRatingControl.Size = new Size(160, 32);
            starRatingControl.TabIndex = 1;
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
            lblRatingStatus.Text = "0 out of 5";
            lblRatingStatus.TextAlign = ContentAlignment.TopRight;
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
            pnHeader.PerformLayout();
            pnReviewContainer.ResumeLayout(false);
            pnReviewContainer.PerformLayout();
            pnRatingSection.ResumeLayout(false);
            pnRatingHeader.ResumeLayout(false);
            pnLikeSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLike).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox picLike;
        private Button btnSave;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel pnRatingHeader;
        private Label lblRatingStatus;
        private Label lblRatingHeader;
        private UserControls.StarRatingControl starRatingControl;
    }
}