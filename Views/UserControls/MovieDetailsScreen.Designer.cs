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
            pnDirector = new Panel();
            lblDirectorName = new Label();
            lblDirectedBy = new Label();
            pnMovieTitle = new Panel();
            lblReleaseYear = new Label();
            lblMovieTitle = new Label();
            pnMovieFacts = new Panel();
            lblRuntime = new Label();
            lblGenres = new Label();
            lblReleaseDate = new Label();
            btnBack = new Button();
            pnHeaderInfo = new Panel();
            lblOverviewParagraph = new Label();
            lblOverviewHeader = new Label();
            lblTagline = new Label();
            picMoviePoster = new PictureBox();
            pnContentWrapper = new Panel();
            pnColumn1 = new Panel();
            pnReviewsSection = new Panel();
            pnReviews = new Panel();
            pnReviewsHeader = new Panel();
            lblReviewsHeader = new Label();
            btnMoreReviews = new Button();
            pnCrewSection = new Panel();
            pnCrew = new Panel();
            lblCrewHeader = new Label();
            pnCastSection = new Panel();
            pnCast = new Panel();
            lblCastHeader = new Label();
            pnColumn2 = new Panel();
            pnRevenueSection = new Panel();
            lblRevenue = new Label();
            lblRevenueHeader = new Label();
            pnBudgetSection = new Panel();
            lblBudget = new Label();
            lblBudgetHeader = new Label();
            pnOriginalLanguageSection = new Panel();
            lblOriginalLanguage = new Label();
            lblOriginalLanguageHeader = new Label();
            pnStatusSection = new Panel();
            lblStatus = new Label();
            lblStatusHeader = new Label();
            pnActions = new Panel();
            pnActionsRow6 = new Panel();
            lblShare = new Label();
            pnActionsRow5 = new Panel();
            lblAddToLists = new Label();
            pnActionsRow4 = new Panel();
            lblReviewOrLog = new Label();
            pnActionsRow3 = new Panel();
            lblShowActivity = new Label();
            pnActionsRow2 = new Panel();
            starRatingControl = new StarRatingControl();
            lblRate = new Label();
            pnActionsRow1 = new Panel();
            btnWatchlist = new Button();
            btnLike = new Button();
            btnWatch = new Button();
            pnBackdrop.SuspendLayout();
            pnHeader.SuspendLayout();
            pnDirector.SuspendLayout();
            pnMovieTitle.SuspendLayout();
            pnMovieFacts.SuspendLayout();
            pnHeaderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).BeginInit();
            pnContentWrapper.SuspendLayout();
            pnColumn1.SuspendLayout();
            pnReviewsSection.SuspendLayout();
            pnReviewsHeader.SuspendLayout();
            pnCrewSection.SuspendLayout();
            pnCastSection.SuspendLayout();
            pnColumn2.SuspendLayout();
            pnRevenueSection.SuspendLayout();
            pnBudgetSection.SuspendLayout();
            pnOriginalLanguageSection.SuspendLayout();
            pnStatusSection.SuspendLayout();
            pnActions.SuspendLayout();
            pnActionsRow6.SuspendLayout();
            pnActionsRow5.SuspendLayout();
            pnActionsRow4.SuspendLayout();
            pnActionsRow3.SuspendLayout();
            pnActionsRow2.SuspendLayout();
            pnActionsRow1.SuspendLayout();
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
            pnHeader.Controls.Add(pnDirector);
            pnHeader.Controls.Add(pnMovieTitle);
            pnHeader.Controls.Add(pnMovieFacts);
            pnHeader.Controls.Add(btnBack);
            pnHeader.Controls.Add(pnHeaderInfo);
            pnHeader.Controls.Add(picMoviePoster);
            pnHeader.Dock = DockStyle.Fill;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1065, 452);
            pnHeader.TabIndex = 0;
            // 
            // pnDirector
            // 
            pnDirector.Controls.Add(lblDirectorName);
            pnDirector.Controls.Add(lblDirectedBy);
            pnDirector.Location = new Point(314, 232);
            pnDirector.Name = "pnDirector";
            pnDirector.Size = new Size(450, 24);
            pnDirector.TabIndex = 11;
            // 
            // lblDirectorName
            // 
            lblDirectorName.AutoSize = true;
            lblDirectorName.Dock = DockStyle.Left;
            lblDirectorName.Font = new Font("Segoe UI", 14F);
            lblDirectorName.ForeColor = Color.FromArgb(180, 221, 255);
            lblDirectorName.Location = new Point(108, 0);
            lblDirectorName.Name = "lblDirectorName";
            lblDirectorName.Size = new Size(142, 25);
            lblDirectorName.TabIndex = 5;
            lblDirectorName.Text = "Frank Darabont";
            // 
            // lblDirectedBy
            // 
            lblDirectedBy.AutoSize = true;
            lblDirectedBy.Dock = DockStyle.Left;
            lblDirectedBy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDirectedBy.ForeColor = Color.FromArgb(178, 172, 162);
            lblDirectedBy.Location = new Point(0, 0);
            lblDirectedBy.Name = "lblDirectedBy";
            lblDirectedBy.Size = new Size(108, 25);
            lblDirectedBy.TabIndex = 4;
            lblDirectedBy.Text = "Directed by";
            // 
            // pnMovieTitle
            // 
            pnMovieTitle.AutoSize = true;
            pnMovieTitle.Controls.Add(lblReleaseYear);
            pnMovieTitle.Controls.Add(lblMovieTitle);
            pnMovieTitle.Location = new Point(314, 147);
            pnMovieTitle.Name = "pnMovieTitle";
            pnMovieTitle.Size = new Size(485, 36);
            pnMovieTitle.TabIndex = 10;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Dock = DockStyle.Left;
            lblReleaseYear.Font = new Font("Segoe UI", 16F);
            lblReleaseYear.ForeColor = Color.FromArgb(180, 221, 255);
            lblReleaseYear.Location = new Point(410, 0);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(75, 30);
            lblReleaseYear.TabIndex = 2;
            lblReleaseYear.Text = "(1994)";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Dock = DockStyle.Left;
            lblMovieTitle.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(0, 0);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(410, 31);
            lblMovieTitle.TabIndex = 1;
            lblMovieTitle.Text = "The Shawshank Redemption";
            // 
            // pnMovieFacts
            // 
            pnMovieFacts.AutoSize = true;
            pnMovieFacts.Controls.Add(lblRuntime);
            pnMovieFacts.Controls.Add(lblGenres);
            pnMovieFacts.Controls.Add(lblReleaseDate);
            pnMovieFacts.Location = new Point(314, 186);
            pnMovieFacts.Name = "pnMovieFacts";
            pnMovieFacts.Size = new Size(276, 30);
            pnMovieFacts.TabIndex = 9;
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Dock = DockStyle.Left;
            lblRuntime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRuntime.ForeColor = Color.White;
            lblRuntime.Location = new Point(210, 0);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Padding = new Padding(5);
            lblRuntime.Size = new Size(59, 27);
            lblRuntime.TabIndex = 4;
            lblRuntime.Text = "2h22m";
            // 
            // lblGenres
            // 
            lblGenres.AutoSize = true;
            lblGenres.Dock = DockStyle.Left;
            lblGenres.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblGenres.ForeColor = Color.White;
            lblGenres.Location = new Point(110, 0);
            lblGenres.Name = "lblGenres";
            lblGenres.Padding = new Padding(5);
            lblGenres.Size = new Size(100, 27);
            lblGenres.TabIndex = 3;
            lblGenres.Text = "Drama, Crime";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Dock = DockStyle.Left;
            lblReleaseDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblReleaseDate.ForeColor = Color.White;
            lblReleaseDate.Location = new Point(0, 0);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Padding = new Padding(5);
            lblReleaseDate.Size = new Size(110, 27);
            lblReleaseDate.TabIndex = 2;
            lblReleaseDate.Text = "09/23/1994 (US)";
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(15, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnHeaderInfo
            // 
            pnHeaderInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnHeaderInfo.AutoSize = true;
            pnHeaderInfo.Controls.Add(lblOverviewParagraph);
            pnHeaderInfo.Controls.Add(lblOverviewHeader);
            pnHeaderInfo.Controls.Add(lblTagline);
            pnHeaderInfo.Location = new Point(314, 264);
            pnHeaderInfo.Name = "pnHeaderInfo";
            pnHeaderInfo.Size = new Size(613, 182);
            pnHeaderInfo.TabIndex = 6;
            // 
            // lblOverviewParagraph
            // 
            lblOverviewParagraph.Dock = DockStyle.Top;
            lblOverviewParagraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverviewParagraph.ForeColor = Color.White;
            lblOverviewParagraph.Location = new Point(0, 47);
            lblOverviewParagraph.Name = "lblOverviewParagraph";
            lblOverviewParagraph.Size = new Size(613, 121);
            lblOverviewParagraph.TabIndex = 7;
            lblOverviewParagraph.Text = resources.GetString("lblOverviewParagraph.Text");
            // 
            // lblOverviewHeader
            // 
            lblOverviewHeader.AutoSize = true;
            lblOverviewHeader.Dock = DockStyle.Top;
            lblOverviewHeader.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverviewHeader.ForeColor = Color.FromArgb(198, 192, 182);
            lblOverviewHeader.Location = new Point(0, 23);
            lblOverviewHeader.Margin = new Padding(3, 10, 3, 0);
            lblOverviewHeader.Name = "lblOverviewHeader";
            lblOverviewHeader.Size = new Size(104, 24);
            lblOverviewHeader.TabIndex = 6;
            lblOverviewHeader.Text = "Overview";
            // 
            // lblTagline
            // 
            lblTagline.Dock = DockStyle.Top;
            lblTagline.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(0, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(613, 23);
            lblTagline.TabIndex = 5;
            lblTagline.Text = "\"Fear can hold you prisoner. Hope can set you free\r\n\"";
            // 
            // picMoviePoster
            // 
            picMoviePoster.Anchor = AnchorStyles.Left;
            picMoviePoster.Image = (Image)resources.GetObject("picMoviePoster.Image");
            picMoviePoster.Location = new Point(48, 61);
            picMoviePoster.Name = "picMoviePoster";
            picMoviePoster.Size = new Size(240, 360);
            picMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picMoviePoster.TabIndex = 0;
            picMoviePoster.TabStop = false;
            // 
            // pnContentWrapper
            // 
            pnContentWrapper.Controls.Add(pnColumn1);
            pnContentWrapper.Controls.Add(pnColumn2);
            pnContentWrapper.Dock = DockStyle.Fill;
            pnContentWrapper.Location = new Point(0, 452);
            pnContentWrapper.Name = "pnContentWrapper";
            pnContentWrapper.Size = new Size(1065, 1137);
            pnContentWrapper.TabIndex = 1;
            // 
            // pnColumn1
            // 
            pnColumn1.Controls.Add(pnReviewsSection);
            pnColumn1.Controls.Add(pnCrewSection);
            pnColumn1.Controls.Add(pnCastSection);
            pnColumn1.Dock = DockStyle.Fill;
            pnColumn1.Location = new Point(0, 0);
            pnColumn1.Name = "pnColumn1";
            pnColumn1.Size = new Size(813, 1137);
            pnColumn1.TabIndex = 1;
            // 
            // pnReviewsSection
            // 
            pnReviewsSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnReviewsSection.Controls.Add(pnReviews);
            pnReviewsSection.Controls.Add(pnReviewsHeader);
            pnReviewsSection.Location = new Point(27, 538);
            pnReviewsSection.Name = "pnReviewsSection";
            pnReviewsSection.Size = new Size(751, 531);
            pnReviewsSection.TabIndex = 2;
            // 
            // pnReviews
            // 
            pnReviews.AutoScroll = true;
            pnReviews.Dock = DockStyle.Fill;
            pnReviews.Location = new Point(0, 35);
            pnReviews.Name = "pnReviews";
            pnReviews.Size = new Size(751, 496);
            pnReviews.TabIndex = 1;
            // 
            // pnReviewsHeader
            // 
            pnReviewsHeader.BorderStyle = BorderStyle.FixedSingle;
            pnReviewsHeader.Controls.Add(lblReviewsHeader);
            pnReviewsHeader.Controls.Add(btnMoreReviews);
            pnReviewsHeader.Dock = DockStyle.Top;
            pnReviewsHeader.Location = new Point(0, 0);
            pnReviewsHeader.Name = "pnReviewsHeader";
            pnReviewsHeader.Size = new Size(751, 35);
            pnReviewsHeader.TabIndex = 0;
            // 
            // lblReviewsHeader
            // 
            lblReviewsHeader.Dock = DockStyle.Fill;
            lblReviewsHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblReviewsHeader.ForeColor = Color.White;
            lblReviewsHeader.Location = new Point(0, 0);
            lblReviewsHeader.Name = "lblReviewsHeader";
            lblReviewsHeader.Size = new Size(686, 33);
            lblReviewsHeader.TabIndex = 2;
            lblReviewsHeader.Text = "Reviews";
            // 
            // btnMoreReviews
            // 
            btnMoreReviews.Dock = DockStyle.Right;
            btnMoreReviews.FlatAppearance.BorderSize = 0;
            btnMoreReviews.FlatStyle = FlatStyle.Flat;
            btnMoreReviews.Font = new Font("Segoe UI", 10F);
            btnMoreReviews.ForeColor = Color.White;
            btnMoreReviews.Location = new Point(686, 0);
            btnMoreReviews.Name = "btnMoreReviews";
            btnMoreReviews.Size = new Size(63, 33);
            btnMoreReviews.TabIndex = 1;
            btnMoreReviews.Text = "More";
            btnMoreReviews.UseVisualStyleBackColor = true;
            // 
            // pnCrewSection
            // 
            pnCrewSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnCrewSection.Controls.Add(pnCrew);
            pnCrewSection.Controls.Add(lblCrewHeader);
            pnCrewSection.Location = new Point(27, 286);
            pnCrewSection.Name = "pnCrewSection";
            pnCrewSection.Size = new Size(751, 205);
            pnCrewSection.TabIndex = 2;
            // 
            // pnCrew
            // 
            pnCrew.AutoScroll = true;
            pnCrew.Dock = DockStyle.Fill;
            pnCrew.Location = new Point(0, 24);
            pnCrew.Name = "pnCrew";
            pnCrew.Size = new Size(751, 181);
            pnCrew.TabIndex = 2;
            // 
            // lblCrewHeader
            // 
            lblCrewHeader.BorderStyle = BorderStyle.FixedSingle;
            lblCrewHeader.Dock = DockStyle.Top;
            lblCrewHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrewHeader.ForeColor = Color.White;
            lblCrewHeader.Location = new Point(0, 0);
            lblCrewHeader.Name = "lblCrewHeader";
            lblCrewHeader.Size = new Size(751, 24);
            lblCrewHeader.TabIndex = 1;
            lblCrewHeader.Text = "Crew";
            // 
            // pnCastSection
            // 
            pnCastSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnCastSection.Controls.Add(pnCast);
            pnCastSection.Controls.Add(lblCastHeader);
            pnCastSection.Location = new Point(27, 29);
            pnCastSection.Name = "pnCastSection";
            pnCastSection.Size = new Size(751, 205);
            pnCastSection.TabIndex = 2;
            // 
            // pnCast
            // 
            pnCast.AutoScroll = true;
            pnCast.Dock = DockStyle.Fill;
            pnCast.Location = new Point(0, 24);
            pnCast.Name = "pnCast";
            pnCast.Size = new Size(751, 181);
            pnCast.TabIndex = 2;
            // 
            // lblCastHeader
            // 
            lblCastHeader.BorderStyle = BorderStyle.FixedSingle;
            lblCastHeader.Dock = DockStyle.Top;
            lblCastHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCastHeader.ForeColor = Color.White;
            lblCastHeader.Location = new Point(0, 0);
            lblCastHeader.Name = "lblCastHeader";
            lblCastHeader.Size = new Size(751, 24);
            lblCastHeader.TabIndex = 1;
            lblCastHeader.Text = "Cast";
            // 
            // pnColumn2
            // 
            pnColumn2.Controls.Add(pnRevenueSection);
            pnColumn2.Controls.Add(pnBudgetSection);
            pnColumn2.Controls.Add(pnOriginalLanguageSection);
            pnColumn2.Controls.Add(pnStatusSection);
            pnColumn2.Controls.Add(pnActions);
            pnColumn2.Dock = DockStyle.Right;
            pnColumn2.Location = new Point(813, 0);
            pnColumn2.Name = "pnColumn2";
            pnColumn2.Size = new Size(252, 1137);
            pnColumn2.TabIndex = 0;
            // 
            // pnRevenueSection
            // 
            pnRevenueSection.Controls.Add(lblRevenue);
            pnRevenueSection.Controls.Add(lblRevenueHeader);
            pnRevenueSection.Dock = DockStyle.Top;
            pnRevenueSection.Location = new Point(0, 585);
            pnRevenueSection.Name = "pnRevenueSection";
            pnRevenueSection.Padding = new Padding(5);
            pnRevenueSection.Size = new Size(252, 80);
            pnRevenueSection.TabIndex = 2;
            // 
            // lblRevenue
            // 
            lblRevenue.Dock = DockStyle.Fill;
            lblRevenue.Font = new Font("Segoe UI", 10F);
            lblRevenue.ForeColor = Color.White;
            lblRevenue.Location = new Point(5, 33);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(242, 42);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "$28,341,469.00";
            // 
            // lblRevenueHeader
            // 
            lblRevenueHeader.Dock = DockStyle.Top;
            lblRevenueHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRevenueHeader.ForeColor = Color.White;
            lblRevenueHeader.Location = new Point(5, 5);
            lblRevenueHeader.Name = "lblRevenueHeader";
            lblRevenueHeader.Size = new Size(242, 28);
            lblRevenueHeader.TabIndex = 0;
            lblRevenueHeader.Text = "Revenue";
            // 
            // pnBudgetSection
            // 
            pnBudgetSection.Controls.Add(lblBudget);
            pnBudgetSection.Controls.Add(lblBudgetHeader);
            pnBudgetSection.Dock = DockStyle.Top;
            pnBudgetSection.Location = new Point(0, 505);
            pnBudgetSection.Name = "pnBudgetSection";
            pnBudgetSection.Padding = new Padding(5);
            pnBudgetSection.Size = new Size(252, 80);
            pnBudgetSection.TabIndex = 2;
            // 
            // lblBudget
            // 
            lblBudget.Dock = DockStyle.Fill;
            lblBudget.Font = new Font("Segoe UI", 10F);
            lblBudget.ForeColor = Color.White;
            lblBudget.Location = new Point(5, 33);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(242, 42);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "$25,000,000.00";
            // 
            // lblBudgetHeader
            // 
            lblBudgetHeader.Dock = DockStyle.Top;
            lblBudgetHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBudgetHeader.ForeColor = Color.White;
            lblBudgetHeader.Location = new Point(5, 5);
            lblBudgetHeader.Name = "lblBudgetHeader";
            lblBudgetHeader.Size = new Size(242, 28);
            lblBudgetHeader.TabIndex = 0;
            lblBudgetHeader.Text = "Budget";
            // 
            // pnOriginalLanguageSection
            // 
            pnOriginalLanguageSection.Controls.Add(lblOriginalLanguage);
            pnOriginalLanguageSection.Controls.Add(lblOriginalLanguageHeader);
            pnOriginalLanguageSection.Dock = DockStyle.Top;
            pnOriginalLanguageSection.Location = new Point(0, 425);
            pnOriginalLanguageSection.Name = "pnOriginalLanguageSection";
            pnOriginalLanguageSection.Padding = new Padding(5);
            pnOriginalLanguageSection.Size = new Size(252, 80);
            pnOriginalLanguageSection.TabIndex = 2;
            // 
            // lblOriginalLanguage
            // 
            lblOriginalLanguage.Dock = DockStyle.Fill;
            lblOriginalLanguage.Font = new Font("Segoe UI", 10F);
            lblOriginalLanguage.ForeColor = Color.White;
            lblOriginalLanguage.Location = new Point(5, 33);
            lblOriginalLanguage.Name = "lblOriginalLanguage";
            lblOriginalLanguage.Size = new Size(242, 42);
            lblOriginalLanguage.TabIndex = 1;
            lblOriginalLanguage.Text = "English";
            // 
            // lblOriginalLanguageHeader
            // 
            lblOriginalLanguageHeader.Dock = DockStyle.Top;
            lblOriginalLanguageHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOriginalLanguageHeader.ForeColor = Color.White;
            lblOriginalLanguageHeader.Location = new Point(5, 5);
            lblOriginalLanguageHeader.Name = "lblOriginalLanguageHeader";
            lblOriginalLanguageHeader.Size = new Size(242, 28);
            lblOriginalLanguageHeader.TabIndex = 0;
            lblOriginalLanguageHeader.Text = "Original Language";
            // 
            // pnStatusSection
            // 
            pnStatusSection.Controls.Add(lblStatus);
            pnStatusSection.Controls.Add(lblStatusHeader);
            pnStatusSection.Dock = DockStyle.Top;
            pnStatusSection.Location = new Point(0, 345);
            pnStatusSection.Name = "pnStatusSection";
            pnStatusSection.Padding = new Padding(5);
            pnStatusSection.Size = new Size(252, 80);
            pnStatusSection.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(5, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(242, 42);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Released";
            // 
            // lblStatusHeader
            // 
            lblStatusHeader.Dock = DockStyle.Top;
            lblStatusHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatusHeader.ForeColor = Color.White;
            lblStatusHeader.Location = new Point(5, 5);
            lblStatusHeader.Name = "lblStatusHeader";
            lblStatusHeader.Size = new Size(242, 28);
            lblStatusHeader.TabIndex = 0;
            lblStatusHeader.Text = "Status";
            // 
            // pnActions
            // 
            pnActions.BackColor = Color.FromArgb(54, 68, 82);
            pnActions.BorderStyle = BorderStyle.FixedSingle;
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
            // pnActionsRow6
            // 
            pnActionsRow6.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow6.Controls.Add(lblShare);
            pnActionsRow6.Dock = DockStyle.Fill;
            pnActionsRow6.Location = new Point(0, 300);
            pnActionsRow6.Name = "pnActionsRow6";
            pnActionsRow6.Size = new Size(250, 43);
            pnActionsRow6.TabIndex = 5;
            // 
            // lblShare
            // 
            lblShare.Dock = DockStyle.Fill;
            lblShare.Font = new Font("Segoe UI", 10F);
            lblShare.ForeColor = Color.FromArgb(178, 172, 162);
            lblShare.Location = new Point(0, 0);
            lblShare.Name = "lblShare";
            lblShare.Size = new Size(248, 41);
            lblShare.TabIndex = 0;
            lblShare.Text = "Share";
            lblShare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow5
            // 
            pnActionsRow5.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow5.Controls.Add(lblAddToLists);
            pnActionsRow5.Dock = DockStyle.Top;
            pnActionsRow5.Location = new Point(0, 255);
            pnActionsRow5.Name = "pnActionsRow5";
            pnActionsRow5.Size = new Size(250, 45);
            pnActionsRow5.TabIndex = 4;
            // 
            // lblAddToLists
            // 
            lblAddToLists.Dock = DockStyle.Fill;
            lblAddToLists.Font = new Font("Segoe UI", 10F);
            lblAddToLists.ForeColor = Color.FromArgb(178, 172, 162);
            lblAddToLists.Location = new Point(0, 0);
            lblAddToLists.Name = "lblAddToLists";
            lblAddToLists.Size = new Size(248, 43);
            lblAddToLists.TabIndex = 0;
            lblAddToLists.Text = "Add to lists ...";
            lblAddToLists.TextAlign = ContentAlignment.MiddleCenter;
            lblAddToLists.Click += lblAddToLists_Click;
            // 
            // pnActionsRow4
            // 
            pnActionsRow4.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow4.Controls.Add(lblReviewOrLog);
            pnActionsRow4.Dock = DockStyle.Top;
            pnActionsRow4.Location = new Point(0, 210);
            pnActionsRow4.Name = "pnActionsRow4";
            pnActionsRow4.Size = new Size(250, 45);
            pnActionsRow4.TabIndex = 3;
            // 
            // lblReviewOrLog
            // 
            lblReviewOrLog.Dock = DockStyle.Fill;
            lblReviewOrLog.Font = new Font("Segoe UI", 10F);
            lblReviewOrLog.ForeColor = Color.FromArgb(178, 172, 162);
            lblReviewOrLog.Location = new Point(0, 0);
            lblReviewOrLog.Name = "lblReviewOrLog";
            lblReviewOrLog.Size = new Size(248, 43);
            lblReviewOrLog.TabIndex = 0;
            lblReviewOrLog.Text = "Review or log ...";
            lblReviewOrLog.TextAlign = ContentAlignment.MiddleCenter;
            lblReviewOrLog.Click += lblReviewOrLog_Click;
            // 
            // pnActionsRow3
            // 
            pnActionsRow3.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow3.Controls.Add(lblShowActivity);
            pnActionsRow3.Dock = DockStyle.Top;
            pnActionsRow3.Location = new Point(0, 165);
            pnActionsRow3.Name = "pnActionsRow3";
            pnActionsRow3.Size = new Size(250, 45);
            pnActionsRow3.TabIndex = 2;
            // 
            // lblShowActivity
            // 
            lblShowActivity.Dock = DockStyle.Fill;
            lblShowActivity.Font = new Font("Segoe UI", 10F);
            lblShowActivity.ForeColor = Color.FromArgb(178, 172, 162);
            lblShowActivity.Location = new Point(0, 0);
            lblShowActivity.Name = "lblShowActivity";
            lblShowActivity.Size = new Size(248, 43);
            lblShowActivity.TabIndex = 0;
            lblShowActivity.Text = "Show your activity";
            lblShowActivity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow2
            // 
            pnActionsRow2.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow2.Controls.Add(starRatingControl);
            pnActionsRow2.Controls.Add(lblRate);
            pnActionsRow2.Dock = DockStyle.Top;
            pnActionsRow2.Location = new Point(0, 90);
            pnActionsRow2.Name = "pnActionsRow2";
            pnActionsRow2.Size = new Size(250, 75);
            pnActionsRow2.TabIndex = 1;
            // 
            // starRatingControl
            // 
            starRatingControl.BackColor = Color.Transparent;
            starRatingControl.Location = new Point(45, 35);
            starRatingControl.Margin = new Padding(4);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.Rating = 0;
            starRatingControl.Size = new Size(160, 32);
            starRatingControl.TabIndex = 1;
            // 
            // lblRate
            // 
            lblRate.Dock = DockStyle.Top;
            lblRate.Font = new Font("Segoe UI", 10F);
            lblRate.ForeColor = Color.FromArgb(178, 172, 162);
            lblRate.Location = new Point(0, 0);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(248, 23);
            lblRate.TabIndex = 0;
            lblRate.Text = "Rate";
            lblRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnActionsRow1
            // 
            pnActionsRow1.BorderStyle = BorderStyle.FixedSingle;
            pnActionsRow1.Controls.Add(btnWatchlist);
            pnActionsRow1.Controls.Add(btnLike);
            pnActionsRow1.Controls.Add(btnWatch);
            pnActionsRow1.Dock = DockStyle.Top;
            pnActionsRow1.Location = new Point(0, 0);
            pnActionsRow1.Name = "pnActionsRow1";
            pnActionsRow1.Size = new Size(250, 90);
            pnActionsRow1.TabIndex = 0;
            // 
            // btnWatchlist
            // 
            btnWatchlist.Anchor = AnchorStyles.Right;
            btnWatchlist.FlatAppearance.BorderSize = 0;
            btnWatchlist.FlatStyle = FlatStyle.Flat;
            btnWatchlist.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnWatchlist.ForeColor = Color.FromArgb(178, 172, 162);
            btnWatchlist.Image = Properties.Resources.add_big;
            btnWatchlist.Location = new Point(166, 5);
            btnWatchlist.Name = "btnWatchlist";
            btnWatchlist.Size = new Size(75, 80);
            btnWatchlist.TabIndex = 0;
            btnWatchlist.Text = "Watchlist";
            btnWatchlist.TextImageRelation = TextImageRelation.ImageAboveText;
            btnWatchlist.UseVisualStyleBackColor = true;
            // 
            // btnLike
            // 
            btnLike.Anchor = AnchorStyles.None;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLike.ForeColor = Color.FromArgb(178, 172, 162);
            btnLike.Image = Properties.Resources.like_big;
            btnLike.Location = new Point(86, 5);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(75, 80);
            btnLike.TabIndex = 0;
            btnLike.Text = "Like";
            btnLike.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLike.UseVisualStyleBackColor = true;
            // 
            // btnWatch
            // 
            btnWatch.Anchor = AnchorStyles.Left;
            btnWatch.FlatAppearance.BorderSize = 0;
            btnWatch.FlatStyle = FlatStyle.Flat;
            btnWatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnWatch.ForeColor = Color.FromArgb(178, 172, 162);
            btnWatch.Image = Properties.Resources.eye_big;
            btnWatch.Location = new Point(5, 5);
            btnWatch.Name = "btnWatch";
            btnWatch.Size = new Size(75, 80);
            btnWatch.TabIndex = 0;
            btnWatch.Text = "Watch";
            btnWatch.TextImageRelation = TextImageRelation.ImageAboveText;
            btnWatch.UseVisualStyleBackColor = true;
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
            Size = new Size(1065, 1589);
            Load += MovieDetailsScreen_Load;
            pnBackdrop.ResumeLayout(false);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnDirector.ResumeLayout(false);
            pnDirector.PerformLayout();
            pnMovieTitle.ResumeLayout(false);
            pnMovieTitle.PerformLayout();
            pnMovieFacts.ResumeLayout(false);
            pnMovieFacts.PerformLayout();
            pnHeaderInfo.ResumeLayout(false);
            pnHeaderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).EndInit();
            pnContentWrapper.ResumeLayout(false);
            pnColumn1.ResumeLayout(false);
            pnReviewsSection.ResumeLayout(false);
            pnReviewsHeader.ResumeLayout(false);
            pnCrewSection.ResumeLayout(false);
            pnCastSection.ResumeLayout(false);
            pnColumn2.ResumeLayout(false);
            pnRevenueSection.ResumeLayout(false);
            pnBudgetSection.ResumeLayout(false);
            pnOriginalLanguageSection.ResumeLayout(false);
            pnStatusSection.ResumeLayout(false);
            pnActions.ResumeLayout(false);
            pnActionsRow6.ResumeLayout(false);
            pnActionsRow5.ResumeLayout(false);
            pnActionsRow4.ResumeLayout(false);
            pnActionsRow3.ResumeLayout(false);
            pnActionsRow2.ResumeLayout(false);
            pnActionsRow1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackdrop;
        private Panel pnHeader;
        private PictureBox picMoviePoster;
        private Label lblMovieTitle;
        private Label lblDirectedBy;
        private Label lblReleaseDate;
        private Label lblTagline;
        private Panel pnHeaderInfo;
        private Label lblOverviewParagraph;
        private Label lblOverviewHeader;
        private Panel pnContentWrapper;
        private Panel pnColumn1;
        private Panel pnColumn2;
        private Panel pnActions;
        private Panel pnActionsRow1;
        private Button btnWatch;
        private Button btnWatchlist;
        private Button btnLike;
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
        private Label lblCastHeader;
        private Panel pnCrewSection;
        private Panel pnCrew;
        private Label lblCrewHeader;
        private Panel pnCastSection;
        private Panel pnCast;
        private Panel pnReviewsSection;
        private Panel pnReviewsHeader;
        private Label lblReviewsHeader;
        private Button btnMoreReviews;
        private Panel pnReviews;
        private Panel pnStatusSection;
        private Label lblStatus;
        private Label lblStatusHeader;
        private Panel pnOriginalLanguageSection;
        private Label lblOriginalLanguageHeader;
        private Panel pnRevenueSection;
        private Label lblRevenue;
        private Label lblRevenueHeader;
        private Panel pnBudgetSection;
        private Label lblBudget;
        private Label lblBudgetHeader;
        private Label lblOriginalLanguage;
        private Button btnBack;
        private Panel pnMovieFacts;
        private Label lblRuntime;
        private Label lblGenres;
        private Panel pnMovieTitle;
        private Label lblReleaseYear;
        private Panel pnDirector;
        private Label lblDirectorName;
        private StarRatingControl starRatingControl;
    }
}
