namespace CineVerse.Views.UserControls
{
    partial class MovieDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailsScreen));
            pnBackdrop = new Panel();
            pnHeader = new Panel();
            picMoviePoster = new PictureBox();
            lblMovieTitle = new Label();
            lblReleaseYear = new Label();
            lblDirectorName = new Label();
            lblDirectedBy = new Label();
            lblTagline = new Label();
            pnHeaderInfo = new Panel();
            lblOverviewHeader = new Label();
            lblOverviewParagraph = new Label();
            pnContentWrapper = new Panel();
            pnColumn2 = new Panel();
            pnColumn1 = new Panel();
            pnActions = new Panel();
            pnActionsRow1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pnActionsRow2 = new Panel();
            lblRate = new Label();
            pnActionsRow3 = new Panel();
            lblShowActivity = new Label();
            pnActionsRow4 = new Panel();
            lblReviewOrLog = new Label();
            pnActionsRow5 = new Panel();
            lblAddToLists = new Label();
            pnActionsRow6 = new Panel();
            lblShare = new Label();
            pnRatingStars = new Panel();
            picStar1 = new PictureBox();
            picStar2 = new PictureBox();
            picStar3 = new PictureBox();
            picStar4 = new PictureBox();
            picStar5 = new PictureBox();
            pnBackdrop.SuspendLayout();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).BeginInit();
            pnHeaderInfo.SuspendLayout();
            pnContentWrapper.SuspendLayout();
            pnColumn2.SuspendLayout();
            pnActions.SuspendLayout();
            pnActionsRow1.SuspendLayout();
            pnActionsRow2.SuspendLayout();
            pnActionsRow3.SuspendLayout();
            pnActionsRow4.SuspendLayout();
            pnActionsRow5.SuspendLayout();
            pnActionsRow6.SuspendLayout();
            pnRatingStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            SuspendLayout();
            // 
            // pnBackdrop
            // 
            pnBackdrop.BackgroundImage = (Image)resources.GetObject("pnBackdrop.BackgroundImage");
            pnBackdrop.BackgroundImageLayout = ImageLayout.Zoom;
            pnBackdrop.Controls.Add(pnHeader);
            pnBackdrop.Dock = DockStyle.Top;
            pnBackdrop.Location = new Point(0, 0);
            pnBackdrop.Name = "pnBackdrop";
            pnBackdrop.Size = new Size(1065, 452);
            pnBackdrop.TabIndex = 0;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Transparent;
            pnHeader.Controls.Add(pnHeaderInfo);
            pnHeader.Controls.Add(lblDirectedBy);
            pnHeader.Controls.Add(lblDirectorName);
            pnHeader.Controls.Add(lblReleaseYear);
            pnHeader.Controls.Add(lblMovieTitle);
            pnHeader.Controls.Add(picMoviePoster);
            pnHeader.Dock = DockStyle.Fill;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1065, 452);
            pnHeader.TabIndex = 0;
            // 
            // picMoviePoster
            // 
            picMoviePoster.Anchor = AnchorStyles.Left;
            picMoviePoster.Image = (Image)resources.GetObject("picMoviePoster.Image");
            picMoviePoster.Location = new Point(48, 39);
            picMoviePoster.Name = "picMoviePoster";
            picMoviePoster.Size = new Size(240, 360);
            picMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picMoviePoster.TabIndex = 0;
            picMoviePoster.TabStop = false;
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(294, 189);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(365, 29);
            lblMovieTitle.TabIndex = 1;
            lblMovieTitle.Text = "The Shawshank Redemption";
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Font = new Font("Segoe UI", 14F);
            lblReleaseYear.ForeColor = Color.FromArgb(180, 221, 255);
            lblReleaseYear.Location = new Point(294, 228);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(52, 25);
            lblReleaseYear.TabIndex = 2;
            lblReleaseYear.Text = "1994";
            // 
            // lblDirectorName
            // 
            lblDirectorName.AutoSize = true;
            lblDirectorName.Font = new Font("Segoe UI", 14F);
            lblDirectorName.ForeColor = Color.FromArgb(180, 221, 255);
            lblDirectorName.Location = new Point(463, 228);
            lblDirectorName.Name = "lblDirectorName";
            lblDirectorName.Size = new Size(142, 25);
            lblDirectorName.TabIndex = 3;
            lblDirectorName.Text = "Frank Darabont";
            // 
            // lblDirectedBy
            // 
            lblDirectedBy.AutoSize = true;
            lblDirectedBy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDirectedBy.ForeColor = Color.FromArgb(178, 172, 162);
            lblDirectedBy.Location = new Point(352, 228);
            lblDirectedBy.Name = "lblDirectedBy";
            lblDirectedBy.Size = new Size(108, 25);
            lblDirectedBy.TabIndex = 4;
            lblDirectedBy.Text = "Directed by";
            // 
            // lblTagline
            // 
            lblTagline.Dock = DockStyle.Top;
            lblTagline.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(0, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(634, 23);
            lblTagline.TabIndex = 5;
            lblTagline.Text = "Fear can hold you prisoner. Hope can set you free\r\n";
            // 
            // pnHeaderInfo
            // 
            pnHeaderInfo.Controls.Add(lblOverviewParagraph);
            pnHeaderInfo.Controls.Add(lblOverviewHeader);
            pnHeaderInfo.Controls.Add(lblTagline);
            pnHeaderInfo.Location = new Point(294, 271);
            pnHeaderInfo.Name = "pnHeaderInfo";
            pnHeaderInfo.Size = new Size(634, 167);
            pnHeaderInfo.TabIndex = 6;
            // 
            // lblOverviewHeader
            // 
            lblOverviewHeader.Dock = DockStyle.Top;
            lblOverviewHeader.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverviewHeader.ForeColor = Color.FromArgb(178, 172, 162);
            lblOverviewHeader.Location = new Point(0, 23);
            lblOverviewHeader.Name = "lblOverviewHeader";
            lblOverviewHeader.Size = new Size(634, 23);
            lblOverviewHeader.TabIndex = 6;
            lblOverviewHeader.Text = "Overview";
            // 
            // lblOverviewParagraph
            // 
            lblOverviewParagraph.Dock = DockStyle.Fill;
            lblOverviewParagraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverviewParagraph.ForeColor = Color.White;
            lblOverviewParagraph.Location = new Point(0, 46);
            lblOverviewParagraph.Name = "lblOverviewParagraph";
            lblOverviewParagraph.Size = new Size(634, 121);
            lblOverviewParagraph.TabIndex = 7;
            lblOverviewParagraph.Text = resources.GetString("lblOverviewParagraph.Text");
            // 
            // pnContentWrapper
            // 
            pnContentWrapper.Controls.Add(pnColumn1);
            pnContentWrapper.Controls.Add(pnColumn2);
            pnContentWrapper.Dock = DockStyle.Fill;
            pnContentWrapper.Location = new Point(0, 452);
            pnContentWrapper.Name = "pnContentWrapper";
            pnContentWrapper.Size = new Size(1065, 517);
            pnContentWrapper.TabIndex = 1;
            // 
            // pnColumn2
            // 
            pnColumn2.Controls.Add(pnActions);
            pnColumn2.Dock = DockStyle.Right;
            pnColumn2.Location = new Point(813, 0);
            pnColumn2.Name = "pnColumn2";
            pnColumn2.Size = new Size(252, 517);
            pnColumn2.TabIndex = 0;
            // 
            // pnColumn1
            // 
            pnColumn1.Dock = DockStyle.Fill;
            pnColumn1.Location = new Point(0, 0);
            pnColumn1.Name = "pnColumn1";
            pnColumn1.Size = new Size(813, 517);
            pnColumn1.TabIndex = 1;
            // 
            // pnActions
            // 
            pnActions.BackColor = Color.FromArgb(54, 68, 82);
            pnActions.Controls.Add(pnActionsRow6);
            pnActions.Controls.Add(pnActionsRow5);
            pnActions.Controls.Add(pnActionsRow4);
            pnActions.Controls.Add(pnActionsRow3);
            pnActions.Controls.Add(pnActionsRow2);
            pnActions.Controls.Add(pnActionsRow1);
            pnActions.Dock = DockStyle.Top;
            pnActions.Location = new Point(0, 0);
            pnActions.Name = "pnActions";
            pnActions.Size = new Size(252, 345);
            pnActions.TabIndex = 0;
            // 
            // pnActionsRow1
            // 
            pnActionsRow1.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow1.Controls.Add(button3);
            pnActionsRow1.Controls.Add(button2);
            pnActionsRow1.Controls.Add(button1);
            pnActionsRow1.Dock = DockStyle.Top;
            pnActionsRow1.Location = new Point(0, 0);
            pnActionsRow1.Name = "pnActionsRow1";
            pnActionsRow1.Size = new Size(252, 90);
            pnActionsRow1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(178, 172, 162);
            button1.Image = Properties.Resources.eye_big;
            button1.Location = new Point(5, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 80);
            button1.TabIndex = 0;
            button1.Text = "Watch";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(178, 172, 162);
            button2.Image = Properties.Resources.like_big;
            button2.Location = new Point(87, 5);
            button2.Name = "button2";
            button2.Size = new Size(75, 80);
            button2.TabIndex = 0;
            button2.Text = "Like";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(178, 172, 162);
            button3.Image = Properties.Resources.add_big;
            button3.Location = new Point(168, 5);
            button3.Name = "button3";
            button3.Size = new Size(75, 80);
            button3.TabIndex = 0;
            button3.Text = "Watchlist";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // pnActionsRow2
            // 
            pnActionsRow2.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow2.Controls.Add(pnRatingStars);
            pnActionsRow2.Controls.Add(lblRate);
            pnActionsRow2.Dock = DockStyle.Top;
            pnActionsRow2.Location = new Point(0, 90);
            pnActionsRow2.Name = "pnActionsRow2";
            pnActionsRow2.Size = new Size(252, 75);
            pnActionsRow2.TabIndex = 1;
            // 
            // lblRate
            // 
            lblRate.Dock = DockStyle.Top;
            lblRate.Font = new Font("Segoe UI", 10F);
            lblRate.ForeColor = Color.FromArgb(178, 172, 162);
            lblRate.Location = new Point(0, 0);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(250, 23);
            lblRate.TabIndex = 0;
            lblRate.Text = "Rate";
            lblRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow3
            // 
            pnActionsRow3.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow3.Controls.Add(lblShowActivity);
            pnActionsRow3.Dock = DockStyle.Top;
            pnActionsRow3.Location = new Point(0, 165);
            pnActionsRow3.Name = "pnActionsRow3";
            pnActionsRow3.Size = new Size(252, 45);
            pnActionsRow3.TabIndex = 2;
            // 
            // lblShowActivity
            // 
            lblShowActivity.Dock = DockStyle.Fill;
            lblShowActivity.Font = new Font("Segoe UI", 10F);
            lblShowActivity.ForeColor = Color.FromArgb(178, 172, 162);
            lblShowActivity.Location = new Point(0, 0);
            lblShowActivity.Name = "lblShowActivity";
            lblShowActivity.Size = new Size(250, 43);
            lblShowActivity.TabIndex = 0;
            lblShowActivity.Text = "Show your activity";
            lblShowActivity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow4
            // 
            pnActionsRow4.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow4.Controls.Add(lblReviewOrLog);
            pnActionsRow4.Dock = DockStyle.Top;
            pnActionsRow4.Location = new Point(0, 210);
            pnActionsRow4.Name = "pnActionsRow4";
            pnActionsRow4.Size = new Size(252, 45);
            pnActionsRow4.TabIndex = 3;
            // 
            // lblReviewOrLog
            // 
            lblReviewOrLog.Dock = DockStyle.Fill;
            lblReviewOrLog.Font = new Font("Segoe UI", 10F);
            lblReviewOrLog.ForeColor = Color.FromArgb(178, 172, 162);
            lblReviewOrLog.Location = new Point(0, 0);
            lblReviewOrLog.Name = "lblReviewOrLog";
            lblReviewOrLog.Size = new Size(250, 43);
            lblReviewOrLog.TabIndex = 0;
            lblReviewOrLog.Text = "Review or log ...";
            lblReviewOrLog.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow5
            // 
            pnActionsRow5.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow5.Controls.Add(lblAddToLists);
            pnActionsRow5.Dock = DockStyle.Top;
            pnActionsRow5.Location = new Point(0, 255);
            pnActionsRow5.Name = "pnActionsRow5";
            pnActionsRow5.Size = new Size(252, 45);
            pnActionsRow5.TabIndex = 4;
            // 
            // lblAddToLists
            // 
            lblAddToLists.Dock = DockStyle.Fill;
            lblAddToLists.Font = new Font("Segoe UI", 10F);
            lblAddToLists.ForeColor = Color.FromArgb(178, 172, 162);
            lblAddToLists.Location = new Point(0, 0);
            lblAddToLists.Name = "lblAddToLists";
            lblAddToLists.Size = new Size(250, 43);
            lblAddToLists.TabIndex = 0;
            lblAddToLists.Text = "Add to lists ...";
            lblAddToLists.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow6
            // 
            pnActionsRow6.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow6.Controls.Add(lblShare);
            pnActionsRow6.Dock = DockStyle.Fill;
            pnActionsRow6.Location = new Point(0, 300);
            pnActionsRow6.Name = "pnActionsRow6";
            pnActionsRow6.Size = new Size(252, 45);
            pnActionsRow6.TabIndex = 5;
            // 
            // lblShare
            // 
            lblShare.Dock = DockStyle.Fill;
            lblShare.Font = new Font("Segoe UI", 10F);
            lblShare.ForeColor = Color.FromArgb(178, 172, 162);
            lblShare.Location = new Point(0, 0);
            lblShare.Name = "lblShare";
            lblShare.Size = new Size(250, 43);
            lblShare.TabIndex = 0;
            lblShare.Text = "Share";
            lblShare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnRatingStars
            // 
            pnRatingStars.Controls.Add(picStar5);
            pnRatingStars.Controls.Add(picStar4);
            pnRatingStars.Controls.Add(picStar3);
            pnRatingStars.Controls.Add(picStar2);
            pnRatingStars.Controls.Add(picStar1);
            pnRatingStars.Dock = DockStyle.Fill;
            pnRatingStars.Location = new Point(0, 23);
            pnRatingStars.Name = "pnRatingStars";
            pnRatingStars.Size = new Size(250, 50);
            pnRatingStars.TabIndex = 1;
            // 
            // picStar1
            // 
            picStar1.Dock = DockStyle.Left;
            picStar1.Image = Properties.Resources.star_big;
            picStar1.Location = new Point(0, 0);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(50, 50);
            picStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar1.TabIndex = 0;
            picStar1.TabStop = false;
            // 
            // picStar2
            // 
            picStar2.Dock = DockStyle.Left;
            picStar2.Image = Properties.Resources.star_big;
            picStar2.Location = new Point(50, 0);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(50, 50);
            picStar2.TabIndex = 1;
            picStar2.TabStop = false;
            // 
            // picStar3
            // 
            picStar3.Dock = DockStyle.Left;
            picStar3.Image = Properties.Resources.star_big;
            picStar3.Location = new Point(100, 0);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(50, 50);
            picStar3.TabIndex = 2;
            picStar3.TabStop = false;
            // 
            // picStar4
            // 
            picStar4.Dock = DockStyle.Left;
            picStar4.Image = Properties.Resources.star_big;
            picStar4.Location = new Point(150, 0);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(50, 50);
            picStar4.TabIndex = 3;
            picStar4.TabStop = false;
            // 
            // picStar5
            // 
            picStar5.Dock = DockStyle.Left;
            picStar5.Image = Properties.Resources.star_big;
            picStar5.Location = new Point(200, 0);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(50, 50);
            picStar5.TabIndex = 4;
            picStar5.TabStop = false;
            // 
            // MovieDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(pnContentWrapper);
            Controls.Add(pnBackdrop);
            Margin = new Padding(2);
            Name = "MovieDetailsScreen";
            Size = new Size(1065, 969);
            Load += MovieDetailsScreen_Load;
            pnBackdrop.ResumeLayout(false);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).EndInit();
            pnHeaderInfo.ResumeLayout(false);
            pnContentWrapper.ResumeLayout(false);
            pnColumn2.ResumeLayout(false);
            pnActions.ResumeLayout(false);
            pnActionsRow1.ResumeLayout(false);
            pnActionsRow2.ResumeLayout(false);
            pnActionsRow3.ResumeLayout(false);
            pnActionsRow4.ResumeLayout(false);
            pnActionsRow5.ResumeLayout(false);
            pnActionsRow6.ResumeLayout(false);
            pnRatingStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackdrop;
        private Panel pnHeader;
        private PictureBox picMoviePoster;
        private Label lblMovieTitle;
        private Label lblDirectedBy;
        private Label lblDirectorName;
        private Label lblReleaseYear;
        private Label lblTagline;
        private Panel pnHeaderInfo;
        private Label lblOverviewParagraph;
        private Label lblOverviewHeader;
        private Panel pnContentWrapper;
        private Panel pnColumn1;
        private Panel pnColumn2;
        private Panel pnActions;
        private Panel pnActionsRow1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel pnActionsRow3;
        private Panel pnActionsRow2;
        private Label lblRate;
        private Panel pnActionsRow6;
        private Label lblShare;
        private Panel pnActionsRow5;
        private Label lblAddToLists;
        private Panel pnActionsRow4;
        private Label lblReviewOrLog;
        private Label lblShowActivity;
        private Panel pnRatingStars;
        private PictureBox picStar1;
        private PictureBox picStar5;
        private PictureBox picStar4;
        private PictureBox picStar3;
        private PictureBox picStar2;
    }
}
