namespace CineVerse.Views.UserControls
{
    partial class ProfileScreen
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
            pnProfileHeader = new Panel();
            lblBio = new Label();
            pnUsernameAndEdit = new Panel();
            lblUsername = new Label();
            btnEditProfile = new Button();
            picAvatar = new PictureBox();
            pnFollowersCount = new Panel();
            lblNumFollowers = new Label();
            lblFollowersFixed = new Label();
            pnFollowingCount = new Panel();
            lblNumFollowing = new Label();
            lblFollowingFixed = new Label();
            pnListsCount = new Panel();
            lblNumLists = new Label();
            lblListsFixed = new Label();
            pnMoviesCount = new Panel();
            lblNumMovies = new Label();
            lblMoviesFixed = new Label();
            pnProfileNavbar = new Panel();
            lblNetworkTab = new Label();
            lblTagsTab = new Label();
            lblLikesTab = new Label();
            lblListsTab = new Label();
            lblWatchlistTab = new Label();
            lblReviewsTab = new Label();
            lblDiaryTab = new Label();
            lblMoviesTab = new Label();
            lblActivityTab = new Label();
            lblProfileTab = new Label();
            pnMain = new Panel();
            pnFollowingSection = new Panel();
            pnFollowingUserCards = new Panel();
            lblFollowingHeading = new Label();
            pnRecentLikesSection = new Panel();
            pnLikedMovieCards = new Panel();
            lblRecentLikesHeading = new Label();
            pnFavouriteMoviesSection = new Panel();
            pnFavouriteMovieCards = new Panel();
            lblFavouriteMoviesHeading = new Label();
            pnProfileHeader.SuspendLayout();
            pnUsernameAndEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnFollowersCount.SuspendLayout();
            pnFollowingCount.SuspendLayout();
            pnListsCount.SuspendLayout();
            pnMoviesCount.SuspendLayout();
            pnProfileNavbar.SuspendLayout();
            pnMain.SuspendLayout();
            pnFollowingSection.SuspendLayout();
            pnRecentLikesSection.SuspendLayout();
            pnFavouriteMoviesSection.SuspendLayout();
            SuspendLayout();
            // 
            // pnProfileHeader
            // 
            pnProfileHeader.Controls.Add(lblBio);
            pnProfileHeader.Controls.Add(pnUsernameAndEdit);
            pnProfileHeader.Controls.Add(picAvatar);
            pnProfileHeader.Controls.Add(pnFollowersCount);
            pnProfileHeader.Controls.Add(pnFollowingCount);
            pnProfileHeader.Controls.Add(pnListsCount);
            pnProfileHeader.Controls.Add(pnMoviesCount);
            pnProfileHeader.Dock = DockStyle.Top;
            pnProfileHeader.Location = new Point(0, 0);
            pnProfileHeader.Name = "pnProfileHeader";
            pnProfileHeader.Size = new Size(974, 133);
            pnProfileHeader.TabIndex = 0;
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Font = new Font("Segoe UI", 9F);
            lblBio.ForeColor = Color.FromArgb(178, 172, 162);
            lblBio.Location = new Point(136, 70);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(128, 15);
            lblBio.TabIndex = 4;
            lblBio.Text = "Just a normal cinephile";
            // 
            // pnUsernameAndEdit
            // 
            pnUsernameAndEdit.AutoSize = true;
            pnUsernameAndEdit.Controls.Add(lblUsername);
            pnUsernameAndEdit.Controls.Add(btnEditProfile);
            pnUsernameAndEdit.Location = new Point(136, 26);
            pnUsernameAndEdit.Name = "pnUsernameAndEdit";
            pnUsernameAndEdit.Size = new Size(187, 28);
            pnUsernameAndEdit.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(232, 230, 227);
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "ZyklonX";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(68, 82, 95);
            btnEditProfile.Dock = DockStyle.Right;
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.FromArgb(184, 201, 215);
            btnEditProfile.Location = new Point(89, 0);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(98, 28);
            btnEditProfile.TabIndex = 0;
            btnEditProfile.Text = "EDIT PROFILE";
            btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(30, 13);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(100, 100);
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // pnFollowersCount
            // 
            pnFollowersCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnFollowersCount.AutoSize = true;
            pnFollowersCount.Controls.Add(lblNumFollowers);
            pnFollowersCount.Controls.Add(lblFollowersFixed);
            pnFollowersCount.Location = new Point(866, 28);
            pnFollowersCount.Name = "pnFollowersCount";
            pnFollowersCount.Size = new Size(81, 46);
            pnFollowersCount.TabIndex = 0;
            // 
            // lblNumFollowers
            // 
            lblNumFollowers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumFollowers.AutoSize = true;
            lblNumFollowers.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumFollowers.ForeColor = Color.FromArgb(196, 209, 220);
            lblNumFollowers.Location = new Point(25, 0);
            lblNumFollowers.Name = "lblNumFollowers";
            lblNumFollowers.Size = new Size(31, 31);
            lblNumFollowers.TabIndex = 1;
            lblNumFollowers.Text = "3";
            // 
            // lblFollowersFixed
            // 
            lblFollowersFixed.Dock = DockStyle.Bottom;
            lblFollowersFixed.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFollowersFixed.ForeColor = Color.FromArgb(157, 148, 136);
            lblFollowersFixed.Location = new Point(0, 31);
            lblFollowersFixed.Name = "lblFollowersFixed";
            lblFollowersFixed.Size = new Size(81, 15);
            lblFollowersFixed.TabIndex = 0;
            lblFollowersFixed.Text = "FOLLOWERS";
            lblFollowersFixed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnFollowingCount
            // 
            pnFollowingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnFollowingCount.AutoSize = true;
            pnFollowingCount.Controls.Add(lblNumFollowing);
            pnFollowingCount.Controls.Add(lblFollowingFixed);
            pnFollowingCount.Location = new Point(783, 28);
            pnFollowingCount.Name = "pnFollowingCount";
            pnFollowingCount.Size = new Size(77, 46);
            pnFollowingCount.TabIndex = 0;
            // 
            // lblNumFollowing
            // 
            lblNumFollowing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumFollowing.AutoSize = true;
            lblNumFollowing.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumFollowing.ForeColor = Color.FromArgb(196, 209, 220);
            lblNumFollowing.Location = new Point(22, 0);
            lblNumFollowing.Name = "lblNumFollowing";
            lblNumFollowing.Size = new Size(32, 31);
            lblNumFollowing.TabIndex = 1;
            lblNumFollowing.Text = "4";
            // 
            // lblFollowingFixed
            // 
            lblFollowingFixed.Dock = DockStyle.Bottom;
            lblFollowingFixed.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFollowingFixed.ForeColor = Color.FromArgb(157, 148, 136);
            lblFollowingFixed.Location = new Point(0, 31);
            lblFollowingFixed.Name = "lblFollowingFixed";
            lblFollowingFixed.Size = new Size(77, 15);
            lblFollowingFixed.TabIndex = 0;
            lblFollowingFixed.Text = "FOLLOWING";
            lblFollowingFixed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnListsCount
            // 
            pnListsCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnListsCount.AutoSize = true;
            pnListsCount.Controls.Add(lblNumLists);
            pnListsCount.Controls.Add(lblListsFixed);
            pnListsCount.Location = new Point(725, 28);
            pnListsCount.Name = "pnListsCount";
            pnListsCount.Size = new Size(52, 46);
            pnListsCount.TabIndex = 0;
            // 
            // lblNumLists
            // 
            lblNumLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumLists.AutoSize = true;
            lblNumLists.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumLists.ForeColor = Color.FromArgb(196, 209, 220);
            lblNumLists.Location = new Point(13, 0);
            lblNumLists.Name = "lblNumLists";
            lblNumLists.Size = new Size(27, 31);
            lblNumLists.TabIndex = 1;
            lblNumLists.Text = "1";
            // 
            // lblListsFixed
            // 
            lblListsFixed.Dock = DockStyle.Bottom;
            lblListsFixed.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListsFixed.ForeColor = Color.FromArgb(157, 148, 136);
            lblListsFixed.Location = new Point(0, 31);
            lblListsFixed.Name = "lblListsFixed";
            lblListsFixed.Size = new Size(52, 15);
            lblListsFixed.TabIndex = 0;
            lblListsFixed.Text = "LISTS";
            lblListsFixed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnMoviesCount
            // 
            pnMoviesCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMoviesCount.AutoSize = true;
            pnMoviesCount.Controls.Add(lblNumMovies);
            pnMoviesCount.Controls.Add(lblMoviesFixed);
            pnMoviesCount.Location = new Point(637, 28);
            pnMoviesCount.Name = "pnMoviesCount";
            pnMoviesCount.Size = new Size(82, 46);
            pnMoviesCount.TabIndex = 0;
            // 
            // lblNumMovies
            // 
            lblNumMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumMovies.AutoSize = true;
            lblNumMovies.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumMovies.ForeColor = Color.FromArgb(196, 209, 220);
            lblNumMovies.Location = new Point(9, 0);
            lblNumMovies.Name = "lblNumMovies";
            lblNumMovies.Size = new Size(65, 31);
            lblNumMovies.TabIndex = 1;
            lblNumMovies.Text = "222";
            // 
            // lblMoviesFixed
            // 
            lblMoviesFixed.Dock = DockStyle.Bottom;
            lblMoviesFixed.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoviesFixed.ForeColor = Color.FromArgb(157, 148, 136);
            lblMoviesFixed.Location = new Point(0, 31);
            lblMoviesFixed.Name = "lblMoviesFixed";
            lblMoviesFixed.Size = new Size(82, 15);
            lblMoviesFixed.TabIndex = 0;
            lblMoviesFixed.Text = "MOVIES";
            lblMoviesFixed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnProfileNavbar
            // 
            pnProfileNavbar.BorderStyle = BorderStyle.FixedSingle;
            pnProfileNavbar.Controls.Add(lblNetworkTab);
            pnProfileNavbar.Controls.Add(lblTagsTab);
            pnProfileNavbar.Controls.Add(lblLikesTab);
            pnProfileNavbar.Controls.Add(lblListsTab);
            pnProfileNavbar.Controls.Add(lblWatchlistTab);
            pnProfileNavbar.Controls.Add(lblReviewsTab);
            pnProfileNavbar.Controls.Add(lblDiaryTab);
            pnProfileNavbar.Controls.Add(lblMoviesTab);
            pnProfileNavbar.Controls.Add(lblActivityTab);
            pnProfileNavbar.Controls.Add(lblProfileTab);
            pnProfileNavbar.Dock = DockStyle.Top;
            pnProfileNavbar.Location = new Point(0, 133);
            pnProfileNavbar.Name = "pnProfileNavbar";
            pnProfileNavbar.Size = new Size(974, 43);
            pnProfileNavbar.TabIndex = 1;
            // 
            // lblNetworkTab
            // 
            lblNetworkTab.AutoSize = true;
            lblNetworkTab.Font = new Font("Segoe UI", 10F);
            lblNetworkTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblNetworkTab.Location = new Point(724, 11);
            lblNetworkTab.Name = "lblNetworkTab";
            lblNetworkTab.Size = new Size(61, 19);
            lblNetworkTab.TabIndex = 0;
            lblNetworkTab.Text = "Network";
            // 
            // lblTagsTab
            // 
            lblTagsTab.AutoSize = true;
            lblTagsTab.Font = new Font("Segoe UI", 10F);
            lblTagsTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblTagsTab.Location = new Point(660, 11);
            lblTagsTab.Name = "lblTagsTab";
            lblTagsTab.Size = new Size(35, 19);
            lblTagsTab.TabIndex = 0;
            lblTagsTab.Text = "Tags";
            // 
            // lblLikesTab
            // 
            lblLikesTab.AutoSize = true;
            lblLikesTab.Font = new Font("Segoe UI", 10F);
            lblLikesTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblLikesTab.Location = new Point(593, 11);
            lblLikesTab.Name = "lblLikesTab";
            lblLikesTab.Size = new Size(39, 19);
            lblLikesTab.TabIndex = 0;
            lblLikesTab.Text = "Likes";
            // 
            // lblListsTab
            // 
            lblListsTab.AutoSize = true;
            lblListsTab.Font = new Font("Segoe UI", 10F);
            lblListsTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblListsTab.Location = new Point(526, 11);
            lblListsTab.Name = "lblListsTab";
            lblListsTab.Size = new Size(36, 19);
            lblListsTab.TabIndex = 0;
            lblListsTab.Text = "Lists";
            // 
            // lblWatchlistTab
            // 
            lblWatchlistTab.AutoSize = true;
            lblWatchlistTab.Font = new Font("Segoe UI", 10F);
            lblWatchlistTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblWatchlistTab.Location = new Point(435, 11);
            lblWatchlistTab.Name = "lblWatchlistTab";
            lblWatchlistTab.Size = new Size(64, 19);
            lblWatchlistTab.TabIndex = 0;
            lblWatchlistTab.Text = "Watchlist";
            // 
            // lblReviewsTab
            // 
            lblReviewsTab.AutoSize = true;
            lblReviewsTab.Font = new Font("Segoe UI", 10F);
            lblReviewsTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblReviewsTab.Location = new Point(349, 11);
            lblReviewsTab.Name = "lblReviewsTab";
            lblReviewsTab.Size = new Size(57, 19);
            lblReviewsTab.TabIndex = 0;
            lblReviewsTab.Text = "Reviews";
            // 
            // lblDiaryTab
            // 
            lblDiaryTab.AutoSize = true;
            lblDiaryTab.Font = new Font("Segoe UI", 10F);
            lblDiaryTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblDiaryTab.Location = new Point(281, 11);
            lblDiaryTab.Name = "lblDiaryTab";
            lblDiaryTab.Size = new Size(41, 19);
            lblDiaryTab.TabIndex = 0;
            lblDiaryTab.Text = "Diary";
            // 
            // lblMoviesTab
            // 
            lblMoviesTab.AutoSize = true;
            lblMoviesTab.Font = new Font("Segoe UI", 10F);
            lblMoviesTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblMoviesTab.Location = new Point(189, 11);
            lblMoviesTab.Name = "lblMoviesTab";
            lblMoviesTab.Size = new Size(53, 19);
            lblMoviesTab.TabIndex = 0;
            lblMoviesTab.Text = "Movies";
            // 
            // lblActivityTab
            // 
            lblActivityTab.AutoSize = true;
            lblActivityTab.Font = new Font("Segoe UI", 10F);
            lblActivityTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblActivityTab.Location = new Point(102, 11);
            lblActivityTab.Name = "lblActivityTab";
            lblActivityTab.Size = new Size(54, 19);
            lblActivityTab.TabIndex = 0;
            lblActivityTab.Text = "Activity";
            // 
            // lblProfileTab
            // 
            lblProfileTab.AutoSize = true;
            lblProfileTab.Font = new Font("Segoe UI", 10F);
            lblProfileTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblProfileTab.Location = new Point(29, 11);
            lblProfileTab.Name = "lblProfileTab";
            lblProfileTab.Size = new Size(47, 19);
            lblProfileTab.TabIndex = 0;
            lblProfileTab.Text = "Profile";
            // 
            // pnMain
            // 
            pnMain.Controls.Add(pnFollowingSection);
            pnMain.Controls.Add(pnRecentLikesSection);
            pnMain.Controls.Add(pnFavouriteMoviesSection);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 176);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(974, 610);
            pnMain.TabIndex = 2;
            // 
            // pnFollowingSection
            // 
            pnFollowingSection.Controls.Add(pnFollowingUserCards);
            pnFollowingSection.Controls.Add(lblFollowingHeading);
            pnFollowingSection.Location = new Point(30, 496);
            pnFollowingSection.Name = "pnFollowingSection";
            pnFollowingSection.Size = new Size(621, 80);
            pnFollowingSection.TabIndex = 2;
            // 
            // pnFollowingUserCards
            // 
            pnFollowingUserCards.Dock = DockStyle.Fill;
            pnFollowingUserCards.Location = new Point(0, 17);
            pnFollowingUserCards.Name = "pnFollowingUserCards";
            pnFollowingUserCards.Size = new Size(621, 63);
            pnFollowingUserCards.TabIndex = 1;
            // 
            // lblFollowingHeading
            // 
            lblFollowingHeading.AutoSize = true;
            lblFollowingHeading.Dock = DockStyle.Top;
            lblFollowingHeading.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            lblFollowingHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblFollowingHeading.Location = new Point(0, 0);
            lblFollowingHeading.Name = "lblFollowingHeading";
            lblFollowingHeading.Size = new Size(83, 17);
            lblFollowingHeading.TabIndex = 0;
            lblFollowingHeading.Text = "FOLLOWING";
            // 
            // pnRecentLikesSection
            // 
            pnRecentLikesSection.Controls.Add(pnLikedMovieCards);
            pnRecentLikesSection.Controls.Add(lblRecentLikesHeading);
            pnRecentLikesSection.Location = new Point(30, 269);
            pnRecentLikesSection.Name = "pnRecentLikesSection";
            pnRecentLikesSection.Size = new Size(621, 190);
            pnRecentLikesSection.TabIndex = 1;
            // 
            // pnLikedMovieCards
            // 
            pnLikedMovieCards.Dock = DockStyle.Fill;
            pnLikedMovieCards.Location = new Point(0, 17);
            pnLikedMovieCards.Name = "pnLikedMovieCards";
            pnLikedMovieCards.Size = new Size(621, 173);
            pnLikedMovieCards.TabIndex = 1;
            // 
            // lblRecentLikesHeading
            // 
            lblRecentLikesHeading.AutoSize = true;
            lblRecentLikesHeading.Dock = DockStyle.Top;
            lblRecentLikesHeading.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            lblRecentLikesHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblRecentLikesHeading.Location = new Point(0, 0);
            lblRecentLikesHeading.Name = "lblRecentLikesHeading";
            lblRecentLikesHeading.Size = new Size(91, 17);
            lblRecentLikesHeading.TabIndex = 0;
            lblRecentLikesHeading.Text = "RECENT LIKES";
            // 
            // pnFavouriteMoviesSection
            // 
            pnFavouriteMoviesSection.Controls.Add(pnFavouriteMovieCards);
            pnFavouriteMoviesSection.Controls.Add(lblFavouriteMoviesHeading);
            pnFavouriteMoviesSection.Location = new Point(30, 40);
            pnFavouriteMoviesSection.Name = "pnFavouriteMoviesSection";
            pnFavouriteMoviesSection.Size = new Size(621, 190);
            pnFavouriteMoviesSection.TabIndex = 0;
            // 
            // pnFavouriteMovieCards
            // 
            pnFavouriteMovieCards.Dock = DockStyle.Fill;
            pnFavouriteMovieCards.Location = new Point(0, 17);
            pnFavouriteMovieCards.Name = "pnFavouriteMovieCards";
            pnFavouriteMovieCards.Size = new Size(621, 173);
            pnFavouriteMovieCards.TabIndex = 1;
            // 
            // lblFavouriteMoviesHeading
            // 
            lblFavouriteMoviesHeading.AutoSize = true;
            lblFavouriteMoviesHeading.Dock = DockStyle.Top;
            lblFavouriteMoviesHeading.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            lblFavouriteMoviesHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblFavouriteMoviesHeading.Location = new Point(0, 0);
            lblFavouriteMoviesHeading.Name = "lblFavouriteMoviesHeading";
            lblFavouriteMoviesHeading.Size = new Size(127, 17);
            lblFavouriteMoviesHeading.TabIndex = 0;
            lblFavouriteMoviesHeading.Text = "FAVOURITE MOVIES";
            // 
            // ProfileScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(pnMain);
            Controls.Add(pnProfileNavbar);
            Controls.Add(pnProfileHeader);
            Name = "ProfileScreen";
            Size = new Size(974, 786);
            pnProfileHeader.ResumeLayout(false);
            pnProfileHeader.PerformLayout();
            pnUsernameAndEdit.ResumeLayout(false);
            pnUsernameAndEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnFollowersCount.ResumeLayout(false);
            pnFollowersCount.PerformLayout();
            pnFollowingCount.ResumeLayout(false);
            pnFollowingCount.PerformLayout();
            pnListsCount.ResumeLayout(false);
            pnListsCount.PerformLayout();
            pnMoviesCount.ResumeLayout(false);
            pnMoviesCount.PerformLayout();
            pnProfileNavbar.ResumeLayout(false);
            pnProfileNavbar.PerformLayout();
            pnMain.ResumeLayout(false);
            pnFollowingSection.ResumeLayout(false);
            pnFollowingSection.PerformLayout();
            pnRecentLikesSection.ResumeLayout(false);
            pnRecentLikesSection.PerformLayout();
            pnFavouriteMoviesSection.ResumeLayout(false);
            pnFavouriteMoviesSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnProfileHeader;
        private Panel pnProfileNavbar;
        private Panel pnMain;
        private Panel pnUsernameAndEdit;
        private PictureBox picAvatar;
        private Panel pnMoviesCount;
        private Button btnEditProfile;
        private Label lblBio;
        private Label lblUsername;
        private Label lblMoviesFixed;
        private Label lblNumMovies;
        private Panel pnFollowersCount;
        private Label lblNumFollowers;
        private Label lblFollowersFixed;
        private Panel pnFollowingCount;
        private Label lblNumFollowing;
        private Label lblFollowingFixed;
        private Panel pnListsCount;
        private Label lblNumLists;
        private Label lblListsFixed;
        private Label lblNetworkTab;
        private Label lblTagsTab;
        private Label lblLikesTab;
        private Label lblListsTab;
        private Label lblWatchlistTab;
        private Label lblReviewsTab;
        private Label lblDiaryTab;
        private Label lblMoviesTab;
        private Label lblActivityTab;
        private Label lblProfileTab;
        private Panel pnFavouriteMoviesSection;
        private Label lblFavouriteMoviesHeading;
        private Panel pnRecentLikesSection;
        private Panel pnLikedMovieCards;
        private Label lblRecentLikesHeading;
        private Panel pnFavouriteMovieCards;
        private Panel pnFollowingSection;
        private Panel pnFollowingUserCards;
        private Label lblFollowingHeading;
    }
}
