namespace CineVerse.Views.UserControls
{
    partial class HomeScreen
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
            lblWelcomeMessage = new Label();
            pnWrapper = new Panel();
            pnContents = new Panel();
            pnRow5 = new Panel();
            pnRow5ColLeft = new Panel();
            flpUserAvatars = new FlowLayoutPanel();
            lblDiscussionHeading = new Label();
            pnRow5ColRight = new Panel();
            pnFollowees = new Panel();
            lblFollowingHeading = new Label();
            pnRow4 = new Panel();
            pnLists = new Panel();
            lblPopularListsHeading = new Label();
            pnRow3 = new Panel();
            pnRow3ColLeft = new Panel();
            pnReviews = new Panel();
            lblTopReviewsHeading = new Label();
            pnRow3ColRight = new Panel();
            pnActivities = new Panel();
            lblActivitiesHeading = new Label();
            pnRow2 = new Panel();
            pnRecommendations = new Panel();
            lblRecommendationsHeading = new Label();
            pnRow1 = new Panel();
            pnMovies = new Panel();
            lblTopRatedHeading = new Label();
            pnWrapper.SuspendLayout();
            pnContents.SuspendLayout();
            pnRow5.SuspendLayout();
            pnRow5ColLeft.SuspendLayout();
            pnRow5ColRight.SuspendLayout();
            pnRow4.SuspendLayout();
            pnRow3.SuspendLayout();
            pnRow3ColLeft.SuspendLayout();
            pnRow3ColRight.SuspendLayout();
            pnRow2.SuspendLayout();
            pnRow1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.Dock = DockStyle.Top;
            lblWelcomeMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeMessage.ForeColor = Color.FromArgb(164, 184, 200);
            lblWelcomeMessage.Location = new Point(0, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(950, 42);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = "Welcome Message!\r\n";
            lblWelcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnWrapper
            // 
            pnWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnWrapper.AutoScroll = true;
            pnWrapper.Controls.Add(pnContents);
            pnWrapper.Controls.Add(lblWelcomeMessage);
            pnWrapper.Location = new Point(238, 0);
            pnWrapper.Name = "pnWrapper";
            pnWrapper.Size = new Size(950, 1234);
            pnWrapper.TabIndex = 1;
            // 
            // pnContents
            // 
            pnContents.Controls.Add(pnRow5);
            pnContents.Controls.Add(pnRow4);
            pnContents.Controls.Add(pnRow3);
            pnContents.Controls.Add(pnRow2);
            pnContents.Controls.Add(pnRow1);
            pnContents.Dock = DockStyle.Fill;
            pnContents.Location = new Point(0, 42);
            pnContents.Name = "pnContents";
            pnContents.Size = new Size(950, 1192);
            pnContents.TabIndex = 1;
            // 
            // pnRow5
            // 
            pnRow5.Controls.Add(pnRow5ColLeft);
            pnRow5.Controls.Add(pnRow5ColRight);
            pnRow5.Dock = DockStyle.Fill;
            pnRow5.Location = new Point(0, 987);
            pnRow5.Name = "pnRow5";
            pnRow5.Size = new Size(950, 205);
            pnRow5.TabIndex = 4;
            // 
            // pnRow5ColLeft
            // 
            pnRow5ColLeft.Controls.Add(flpUserAvatars);
            pnRow5ColLeft.Controls.Add(lblDiscussionHeading);
            pnRow5ColLeft.Dock = DockStyle.Fill;
            pnRow5ColLeft.Location = new Point(0, 0);
            pnRow5ColLeft.Name = "pnRow5ColLeft";
            pnRow5ColLeft.Size = new Size(355, 205);
            pnRow5ColLeft.TabIndex = 1;
            // 
            // flpUserAvatars
            // 
            flpUserAvatars.Dock = DockStyle.Fill;
            flpUserAvatars.Location = new Point(0, 17);
            flpUserAvatars.Name = "flpUserAvatars";
            flpUserAvatars.Size = new Size(355, 188);
            flpUserAvatars.TabIndex = 2;
            // 
            // lblDiscussionHeading
            // 
            lblDiscussionHeading.AutoSize = true;
            lblDiscussionHeading.Dock = DockStyle.Top;
            lblDiscussionHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscussionHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblDiscussionHeading.Location = new Point(0, 0);
            lblDiscussionHeading.Name = "lblDiscussionHeading";
            lblDiscussionHeading.Size = new Size(83, 17);
            lblDiscussionHeading.TabIndex = 1;
            lblDiscussionHeading.Text = "DISCUSSION";
            // 
            // pnRow5ColRight
            // 
            pnRow5ColRight.Controls.Add(pnFollowees);
            pnRow5ColRight.Controls.Add(lblFollowingHeading);
            pnRow5ColRight.Dock = DockStyle.Right;
            pnRow5ColRight.Location = new Point(355, 0);
            pnRow5ColRight.Name = "pnRow5ColRight";
            pnRow5ColRight.Size = new Size(595, 205);
            pnRow5ColRight.TabIndex = 0;
            // 
            // pnFollowees
            // 
            pnFollowees.Dock = DockStyle.Fill;
            pnFollowees.Location = new Point(0, 17);
            pnFollowees.Name = "pnFollowees";
            pnFollowees.Size = new Size(595, 188);
            pnFollowees.TabIndex = 2;
            // 
            // lblFollowingHeading
            // 
            lblFollowingHeading.AutoSize = true;
            lblFollowingHeading.Dock = DockStyle.Top;
            lblFollowingHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFollowingHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblFollowingHeading.Location = new Point(0, 0);
            lblFollowingHeading.Name = "lblFollowingHeading";
            lblFollowingHeading.Size = new Size(83, 17);
            lblFollowingHeading.TabIndex = 1;
            lblFollowingHeading.Text = "FOLLOWING";
            // 
            // pnRow4
            // 
            pnRow4.Controls.Add(pnLists);
            pnRow4.Controls.Add(lblPopularListsHeading);
            pnRow4.Dock = DockStyle.Top;
            pnRow4.Location = new Point(0, 815);
            pnRow4.Name = "pnRow4";
            pnRow4.Size = new Size(950, 172);
            pnRow4.TabIndex = 3;
            // 
            // pnLists
            // 
            pnLists.Dock = DockStyle.Fill;
            pnLists.Location = new Point(0, 17);
            pnLists.Name = "pnLists";
            pnLists.Size = new Size(950, 155);
            pnLists.TabIndex = 1;
            // 
            // lblPopularListsHeading
            // 
            lblPopularListsHeading.AutoSize = true;
            lblPopularListsHeading.Dock = DockStyle.Top;
            lblPopularListsHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopularListsHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblPopularListsHeading.Location = new Point(0, 0);
            lblPopularListsHeading.Name = "lblPopularListsHeading";
            lblPopularListsHeading.Size = new Size(101, 17);
            lblPopularListsHeading.TabIndex = 0;
            lblPopularListsHeading.Text = "POPULAR LISTS";
            // 
            // pnRow3
            // 
            pnRow3.Controls.Add(pnRow3ColLeft);
            pnRow3.Controls.Add(pnRow3ColRight);
            pnRow3.Dock = DockStyle.Top;
            pnRow3.Location = new Point(0, 344);
            pnRow3.Name = "pnRow3";
            pnRow3.Size = new Size(950, 471);
            pnRow3.TabIndex = 2;
            // 
            // pnRow3ColLeft
            // 
            pnRow3ColLeft.Controls.Add(pnReviews);
            pnRow3ColLeft.Controls.Add(lblTopReviewsHeading);
            pnRow3ColLeft.Dock = DockStyle.Fill;
            pnRow3ColLeft.Location = new Point(0, 0);
            pnRow3ColLeft.Name = "pnRow3ColLeft";
            pnRow3ColLeft.Size = new Size(643, 471);
            pnRow3ColLeft.TabIndex = 1;
            // 
            // pnReviews
            // 
            pnReviews.Dock = DockStyle.Fill;
            pnReviews.Location = new Point(0, 17);
            pnReviews.Name = "pnReviews";
            pnReviews.Size = new Size(643, 454);
            pnReviews.TabIndex = 1;
            // 
            // lblTopReviewsHeading
            // 
            lblTopReviewsHeading.AutoSize = true;
            lblTopReviewsHeading.Dock = DockStyle.Top;
            lblTopReviewsHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTopReviewsHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblTopReviewsHeading.Location = new Point(0, 0);
            lblTopReviewsHeading.Name = "lblTopReviewsHeading";
            lblTopReviewsHeading.Size = new Size(90, 17);
            lblTopReviewsHeading.TabIndex = 0;
            lblTopReviewsHeading.Text = "TOP REVIEWS";
            // 
            // pnRow3ColRight
            // 
            pnRow3ColRight.Controls.Add(pnActivities);
            pnRow3ColRight.Controls.Add(lblActivitiesHeading);
            pnRow3ColRight.Dock = DockStyle.Right;
            pnRow3ColRight.Location = new Point(643, 0);
            pnRow3ColRight.Name = "pnRow3ColRight";
            pnRow3ColRight.Size = new Size(307, 471);
            pnRow3ColRight.TabIndex = 0;
            // 
            // pnActivities
            // 
            pnActivities.Dock = DockStyle.Fill;
            pnActivities.Location = new Point(0, 17);
            pnActivities.Name = "pnActivities";
            pnActivities.Size = new Size(307, 454);
            pnActivities.TabIndex = 2;
            // 
            // lblActivitiesHeading
            // 
            lblActivitiesHeading.AutoSize = true;
            lblActivitiesHeading.Dock = DockStyle.Top;
            lblActivitiesHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblActivitiesHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblActivitiesHeading.Location = new Point(0, 0);
            lblActivitiesHeading.Name = "lblActivitiesHeading";
            lblActivitiesHeading.Size = new Size(132, 17);
            lblActivitiesHeading.TabIndex = 1;
            lblActivitiesHeading.Text = "FRIENDS' ACTIVITIES";
            // 
            // pnRow2
            // 
            pnRow2.Controls.Add(pnRecommendations);
            pnRow2.Controls.Add(lblRecommendationsHeading);
            pnRow2.Dock = DockStyle.Top;
            pnRow2.Location = new Point(0, 172);
            pnRow2.Name = "pnRow2";
            pnRow2.Size = new Size(950, 172);
            pnRow2.TabIndex = 1;
            // 
            // pnRecommendations
            // 
            pnRecommendations.Dock = DockStyle.Fill;
            pnRecommendations.Location = new Point(0, 17);
            pnRecommendations.Name = "pnRecommendations";
            pnRecommendations.Size = new Size(950, 155);
            pnRecommendations.TabIndex = 1;
            // 
            // lblRecommendationsHeading
            // 
            lblRecommendationsHeading.AutoSize = true;
            lblRecommendationsHeading.Dock = DockStyle.Top;
            lblRecommendationsHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecommendationsHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblRecommendationsHeading.Location = new Point(0, 0);
            lblRecommendationsHeading.Name = "lblRecommendationsHeading";
            lblRecommendationsHeading.Size = new Size(182, 17);
            lblRecommendationsHeading.TabIndex = 0;
            lblRecommendationsHeading.Text = "MOVIE RECOMMENDATIONS";
            // 
            // pnRow1
            // 
            pnRow1.Controls.Add(pnMovies);
            pnRow1.Controls.Add(lblTopRatedHeading);
            pnRow1.Dock = DockStyle.Top;
            pnRow1.Location = new Point(0, 0);
            pnRow1.Name = "pnRow1";
            pnRow1.Size = new Size(950, 172);
            pnRow1.TabIndex = 0;
            // 
            // pnMovies
            // 
            pnMovies.Dock = DockStyle.Fill;
            pnMovies.Location = new Point(0, 17);
            pnMovies.Name = "pnMovies";
            pnMovies.Size = new Size(950, 155);
            pnMovies.TabIndex = 1;
            // 
            // lblTopRatedHeading
            // 
            lblTopRatedHeading.AutoSize = true;
            lblTopRatedHeading.Dock = DockStyle.Top;
            lblTopRatedHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopRatedHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblTopRatedHeading.Location = new Point(0, 0);
            lblTopRatedHeading.Name = "lblTopRatedHeading";
            lblTopRatedHeading.Size = new Size(127, 17);
            lblTopRatedHeading.TabIndex = 0;
            lblTopRatedHeading.Text = "TOP RATED MOVIES";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(pnWrapper);
            Name = "HomeScreen";
            Size = new Size(1426, 1237);
            pnWrapper.ResumeLayout(false);
            pnContents.ResumeLayout(false);
            pnRow5.ResumeLayout(false);
            pnRow5ColLeft.ResumeLayout(false);
            pnRow5ColLeft.PerformLayout();
            pnRow5ColRight.ResumeLayout(false);
            pnRow5ColRight.PerformLayout();
            pnRow4.ResumeLayout(false);
            pnRow4.PerformLayout();
            pnRow3.ResumeLayout(false);
            pnRow3ColLeft.ResumeLayout(false);
            pnRow3ColLeft.PerformLayout();
            pnRow3ColRight.ResumeLayout(false);
            pnRow3ColRight.PerformLayout();
            pnRow2.ResumeLayout(false);
            pnRow2.PerformLayout();
            pnRow1.ResumeLayout(false);
            pnRow1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcomeMessage;
        private Panel pnWrapper;
        private Panel pnContents;
        private Panel pnRow1;
        private Panel pnMovies;
        private Label lblTopRatedHeading;
        private Panel pnRow2;
        private Panel pnRecommendations;
        private Label lblRecommendationsHeading;
        private Panel pnRow3;
        private Panel pnRow3ColLeft;
        private Panel pnRow3ColRight;
        private Label lblTopReviewsHeading;
        private Label lblActivitiesHeading;
        private Panel pnReviews;
        private Panel pnActivities;
        private Panel pnRow4;
        private Panel pnLists;
        private Label lblPopularListsHeading;
        private Panel pnRow5;
        private Panel pnRow5ColRight;
        private Panel pnRow5ColLeft;
        private FlowLayoutPanel flpUserAvatars;
        private Label lblDiscussionHeading;
        private Panel pnFollowees;
        private Label lblFollowingHeading;
    }
}
