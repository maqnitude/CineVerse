namespace CineVerse.Views.UserControls
{
    partial class SettingsScreen
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
            lblSettings = new Label();
            pnMain = new Panel();
            pnForm = new Panel();
            pnLeftCol = new Panel();
            btnSave = new Button();
            pnVisibilityGroup = new Panel();
            cbbVisibility = new ComboBox();
            lblVisibilityHeading = new Label();
            pnBioGroup = new Panel();
            txtBio = new TextBox();
            lblBioHeading = new Label();
            tlpLocationAndWebsiteGroup = new TableLayoutPanel();
            pnWebsiteGroup = new Panel();
            pnWebsiteTextbox = new Panel();
            txtWebsite = new TextBox();
            lblWebsiteHeading = new Label();
            pnLocationGroup = new Panel();
            pnLocationTextbox = new Panel();
            txtLocation = new TextBox();
            lblLocationHeading = new Label();
            pnEmailGroup = new Panel();
            pnEmailTextbox = new Panel();
            txtEmail = new TextBox();
            lblEmailHeading = new Label();
            tlpNameGroup = new TableLayoutPanel();
            pnFamilyNameGroup = new Panel();
            pnFamilyNameTextbox = new Panel();
            txtFamilyName = new TextBox();
            lblFamilyNameHeading = new Label();
            pnGivenNameGroup = new Panel();
            pnGivenNameTextbox = new Panel();
            txtGivenName = new TextBox();
            lblGivenNameHeading = new Label();
            pnUsernameGroup = new Panel();
            pnUsernameTextbox = new Panel();
            txtUsername = new TextBox();
            lblUsernameHeading = new Label();
            lblProfileSection = new Label();
            pnRightCol = new Panel();
            pnAvatarSection = new Panel();
            lblAvatarSection = new Label();
            btnSelectAvatar = new Button();
            picAvatar = new PictureBox();
            pnFavouriteMoviesSection = new Panel();
            pnFavouriteMovieCards = new Panel();
            lblFavouriteMoviesSection = new Label();
            pnSettingsNavbar = new Panel();
            lblDataTab = new Label();
            lblNotificationsTab = new Label();
            lblConnectionsTab = new Label();
            lblAuthTab = new Label();
            lblProfileTab = new Label();
            btnBack = new Button();
            pnMain.SuspendLayout();
            pnForm.SuspendLayout();
            pnLeftCol.SuspendLayout();
            pnVisibilityGroup.SuspendLayout();
            pnBioGroup.SuspendLayout();
            tlpLocationAndWebsiteGroup.SuspendLayout();
            pnWebsiteGroup.SuspendLayout();
            pnWebsiteTextbox.SuspendLayout();
            pnLocationGroup.SuspendLayout();
            pnLocationTextbox.SuspendLayout();
            pnEmailGroup.SuspendLayout();
            pnEmailTextbox.SuspendLayout();
            tlpNameGroup.SuspendLayout();
            pnFamilyNameGroup.SuspendLayout();
            pnFamilyNameTextbox.SuspendLayout();
            pnGivenNameGroup.SuspendLayout();
            pnGivenNameTextbox.SuspendLayout();
            pnUsernameGroup.SuspendLayout();
            pnUsernameTextbox.SuspendLayout();
            pnRightCol.SuspendLayout();
            pnAvatarSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnFavouriteMoviesSection.SuspendLayout();
            pnSettingsNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Segoe UI", 16F);
            lblSettings.ForeColor = Color.FromArgb(164, 184, 200);
            lblSettings.Location = new Point(59, 16);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(174, 30);
            lblSettings.TabIndex = 0;
            lblSettings.Text = "Account Settings";
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.Controls.Add(pnForm);
            pnMain.Controls.Add(pnSettingsNavbar);
            pnMain.Location = new Point(18, 70);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(936, 769);
            pnMain.TabIndex = 1;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(pnLeftCol);
            pnForm.Controls.Add(pnRightCol);
            pnForm.Dock = DockStyle.Fill;
            pnForm.Location = new Point(0, 18);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(936, 751);
            pnForm.TabIndex = 1;
            // 
            // pnLeftCol
            // 
            pnLeftCol.Controls.Add(btnSave);
            pnLeftCol.Controls.Add(pnVisibilityGroup);
            pnLeftCol.Controls.Add(pnBioGroup);
            pnLeftCol.Controls.Add(tlpLocationAndWebsiteGroup);
            pnLeftCol.Controls.Add(pnEmailGroup);
            pnLeftCol.Controls.Add(tlpNameGroup);
            pnLeftCol.Controls.Add(pnUsernameGroup);
            pnLeftCol.Controls.Add(lblProfileSection);
            pnLeftCol.Dock = DockStyle.Fill;
            pnLeftCol.Location = new Point(0, 0);
            pnLeftCol.Name = "pnLeftCol";
            pnLeftCol.Size = new Size(593, 751);
            pnLeftCol.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(0, 138, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(216, 244, 202);
            btnSave.Location = new Point(17, 706);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnVisibilityGroup
            // 
            pnVisibilityGroup.AutoSize = true;
            pnVisibilityGroup.Controls.Add(cbbVisibility);
            pnVisibilityGroup.Controls.Add(lblVisibilityHeading);
            pnVisibilityGroup.Location = new Point(18, 601);
            pnVisibilityGroup.Name = "pnVisibilityGroup";
            pnVisibilityGroup.Size = new Size(258, 47);
            pnVisibilityGroup.TabIndex = 7;
            // 
            // cbbVisibility
            // 
            cbbVisibility.BackColor = Color.FromArgb(44, 52, 64);
            cbbVisibility.Dock = DockStyle.Fill;
            cbbVisibility.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbVisibility.FlatStyle = FlatStyle.Popup;
            cbbVisibility.Font = new Font("Segoe UI", 10F);
            cbbVisibility.ForeColor = Color.FromArgb(168, 160, 149);
            cbbVisibility.FormattingEnabled = true;
            cbbVisibility.Items.AddRange(new object[] { "Public", "Friends", "Private" });
            cbbVisibility.Location = new Point(0, 20);
            cbbVisibility.Name = "cbbVisibility";
            cbbVisibility.Size = new Size(258, 25);
            cbbVisibility.TabIndex = 1;
            // 
            // lblVisibilityHeading
            // 
            lblVisibilityHeading.Dock = DockStyle.Top;
            lblVisibilityHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVisibilityHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblVisibilityHeading.Location = new Point(0, 0);
            lblVisibilityHeading.Name = "lblVisibilityHeading";
            lblVisibilityHeading.Size = new Size(258, 20);
            lblVisibilityHeading.TabIndex = 0;
            lblVisibilityHeading.Text = "Profile visibility";
            // 
            // pnBioGroup
            // 
            pnBioGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnBioGroup.AutoSize = true;
            pnBioGroup.Controls.Add(txtBio);
            pnBioGroup.Controls.Add(lblBioHeading);
            pnBioGroup.Location = new Point(17, 385);
            pnBioGroup.Name = "pnBioGroup";
            pnBioGroup.Size = new Size(544, 191);
            pnBioGroup.TabIndex = 6;
            // 
            // txtBio
            // 
            txtBio.BackColor = Color.FromArgb(44, 52, 64);
            txtBio.BorderStyle = BorderStyle.None;
            txtBio.Dock = DockStyle.Fill;
            txtBio.Font = new Font("Segoe UI", 10F);
            txtBio.ForeColor = Color.FromArgb(168, 160, 149);
            txtBio.Location = new Point(0, 20);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(544, 171);
            txtBio.TabIndex = 1;
            // 
            // lblBioHeading
            // 
            lblBioHeading.Dock = DockStyle.Top;
            lblBioHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBioHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblBioHeading.Location = new Point(0, 0);
            lblBioHeading.Name = "lblBioHeading";
            lblBioHeading.Size = new Size(544, 20);
            lblBioHeading.TabIndex = 0;
            lblBioHeading.Text = "Bio";
            // 
            // tlpLocationAndWebsiteGroup
            // 
            tlpLocationAndWebsiteGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpLocationAndWebsiteGroup.ColumnCount = 2;
            tlpLocationAndWebsiteGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLocationAndWebsiteGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLocationAndWebsiteGroup.Controls.Add(pnWebsiteGroup, 1, 0);
            tlpLocationAndWebsiteGroup.Controls.Add(pnLocationGroup, 0, 0);
            tlpLocationAndWebsiteGroup.Location = new Point(17, 298);
            tlpLocationAndWebsiteGroup.Margin = new Padding(0);
            tlpLocationAndWebsiteGroup.Name = "tlpLocationAndWebsiteGroup";
            tlpLocationAndWebsiteGroup.RowCount = 1;
            tlpLocationAndWebsiteGroup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLocationAndWebsiteGroup.Size = new Size(554, 56);
            tlpLocationAndWebsiteGroup.TabIndex = 5;
            // 
            // pnWebsiteGroup
            // 
            pnWebsiteGroup.Controls.Add(pnWebsiteTextbox);
            pnWebsiteGroup.Controls.Add(lblWebsiteHeading);
            pnWebsiteGroup.Dock = DockStyle.Fill;
            pnWebsiteGroup.Location = new Point(277, 0);
            pnWebsiteGroup.Margin = new Padding(0);
            pnWebsiteGroup.Name = "pnWebsiteGroup";
            pnWebsiteGroup.Padding = new Padding(0, 0, 10, 0);
            pnWebsiteGroup.Size = new Size(277, 56);
            pnWebsiteGroup.TabIndex = 3;
            // 
            // pnWebsiteTextbox
            // 
            pnWebsiteTextbox.AutoSize = true;
            pnWebsiteTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnWebsiteTextbox.Controls.Add(txtWebsite);
            pnWebsiteTextbox.Dock = DockStyle.Fill;
            pnWebsiteTextbox.Location = new Point(0, 20);
            pnWebsiteTextbox.Name = "pnWebsiteTextbox";
            pnWebsiteTextbox.Size = new Size(267, 36);
            pnWebsiteTextbox.TabIndex = 2;
            // 
            // txtWebsite
            // 
            txtWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWebsite.BackColor = Color.FromArgb(44, 52, 64);
            txtWebsite.BorderStyle = BorderStyle.None;
            txtWebsite.Font = new Font("Segoe UI", 10F);
            txtWebsite.ForeColor = Color.FromArgb(168, 160, 149);
            txtWebsite.Location = new Point(4, 9);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(266, 18);
            txtWebsite.TabIndex = 0;
            // 
            // lblWebsiteHeading
            // 
            lblWebsiteHeading.Dock = DockStyle.Top;
            lblWebsiteHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblWebsiteHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblWebsiteHeading.Location = new Point(0, 0);
            lblWebsiteHeading.Name = "lblWebsiteHeading";
            lblWebsiteHeading.Size = new Size(267, 20);
            lblWebsiteHeading.TabIndex = 0;
            lblWebsiteHeading.Text = "Website";
            // 
            // pnLocationGroup
            // 
            pnLocationGroup.AutoSize = true;
            pnLocationGroup.Controls.Add(pnLocationTextbox);
            pnLocationGroup.Controls.Add(lblLocationHeading);
            pnLocationGroup.Dock = DockStyle.Fill;
            pnLocationGroup.Location = new Point(0, 0);
            pnLocationGroup.Margin = new Padding(0);
            pnLocationGroup.Name = "pnLocationGroup";
            pnLocationGroup.Padding = new Padding(0, 0, 15, 0);
            pnLocationGroup.Size = new Size(277, 56);
            pnLocationGroup.TabIndex = 2;
            // 
            // pnLocationTextbox
            // 
            pnLocationTextbox.AutoSize = true;
            pnLocationTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnLocationTextbox.Controls.Add(txtLocation);
            pnLocationTextbox.Dock = DockStyle.Fill;
            pnLocationTextbox.Location = new Point(0, 20);
            pnLocationTextbox.Name = "pnLocationTextbox";
            pnLocationTextbox.Size = new Size(262, 36);
            pnLocationTextbox.TabIndex = 2;
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocation.BackColor = Color.FromArgb(44, 52, 64);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.ForeColor = Color.FromArgb(168, 160, 149);
            txtLocation.Location = new Point(4, 9);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(258, 18);
            txtLocation.TabIndex = 0;
            // 
            // lblLocationHeading
            // 
            lblLocationHeading.Dock = DockStyle.Top;
            lblLocationHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLocationHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblLocationHeading.Location = new Point(0, 0);
            lblLocationHeading.Name = "lblLocationHeading";
            lblLocationHeading.Size = new Size(262, 20);
            lblLocationHeading.TabIndex = 0;
            lblLocationHeading.Text = "Location";
            // 
            // pnEmailGroup
            // 
            pnEmailGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnEmailGroup.Controls.Add(pnEmailTextbox);
            pnEmailGroup.Controls.Add(lblEmailHeading);
            pnEmailGroup.Location = new Point(17, 213);
            pnEmailGroup.Name = "pnEmailGroup";
            pnEmailGroup.Size = new Size(544, 56);
            pnEmailGroup.TabIndex = 4;
            // 
            // pnEmailTextbox
            // 
            pnEmailTextbox.AutoSize = true;
            pnEmailTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnEmailTextbox.Controls.Add(txtEmail);
            pnEmailTextbox.Dock = DockStyle.Fill;
            pnEmailTextbox.Location = new Point(0, 20);
            pnEmailTextbox.Name = "pnEmailTextbox";
            pnEmailTextbox.Size = new Size(544, 36);
            pnEmailTextbox.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(44, 52, 64);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(168, 160, 149);
            txtEmail.Location = new Point(4, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(534, 18);
            txtEmail.TabIndex = 0;
            // 
            // lblEmailHeading
            // 
            lblEmailHeading.Dock = DockStyle.Top;
            lblEmailHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmailHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblEmailHeading.Location = new Point(0, 0);
            lblEmailHeading.Name = "lblEmailHeading";
            lblEmailHeading.Size = new Size(544, 20);
            lblEmailHeading.TabIndex = 0;
            lblEmailHeading.Text = "Email address";
            // 
            // tlpNameGroup
            // 
            tlpNameGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpNameGroup.ColumnCount = 2;
            tlpNameGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNameGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNameGroup.Controls.Add(pnFamilyNameGroup, 1, 0);
            tlpNameGroup.Controls.Add(pnGivenNameGroup, 0, 0);
            tlpNameGroup.Location = new Point(17, 126);
            tlpNameGroup.Margin = new Padding(0);
            tlpNameGroup.Name = "tlpNameGroup";
            tlpNameGroup.RowCount = 1;
            tlpNameGroup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNameGroup.Size = new Size(554, 56);
            tlpNameGroup.TabIndex = 3;
            // 
            // pnFamilyNameGroup
            // 
            pnFamilyNameGroup.Controls.Add(pnFamilyNameTextbox);
            pnFamilyNameGroup.Controls.Add(lblFamilyNameHeading);
            pnFamilyNameGroup.Dock = DockStyle.Fill;
            pnFamilyNameGroup.Location = new Point(277, 0);
            pnFamilyNameGroup.Margin = new Padding(0);
            pnFamilyNameGroup.Name = "pnFamilyNameGroup";
            pnFamilyNameGroup.Padding = new Padding(0, 0, 10, 0);
            pnFamilyNameGroup.Size = new Size(277, 56);
            pnFamilyNameGroup.TabIndex = 3;
            // 
            // pnFamilyNameTextbox
            // 
            pnFamilyNameTextbox.AutoSize = true;
            pnFamilyNameTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnFamilyNameTextbox.Controls.Add(txtFamilyName);
            pnFamilyNameTextbox.Dock = DockStyle.Fill;
            pnFamilyNameTextbox.Location = new Point(0, 20);
            pnFamilyNameTextbox.Name = "pnFamilyNameTextbox";
            pnFamilyNameTextbox.Size = new Size(267, 36);
            pnFamilyNameTextbox.TabIndex = 2;
            // 
            // txtFamilyName
            // 
            txtFamilyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFamilyName.BackColor = Color.FromArgb(44, 52, 64);
            txtFamilyName.BorderStyle = BorderStyle.None;
            txtFamilyName.Font = new Font("Segoe UI", 10F);
            txtFamilyName.ForeColor = Color.FromArgb(168, 160, 149);
            txtFamilyName.Location = new Point(4, 9);
            txtFamilyName.Name = "txtFamilyName";
            txtFamilyName.Size = new Size(263, 18);
            txtFamilyName.TabIndex = 0;
            // 
            // lblFamilyNameHeading
            // 
            lblFamilyNameHeading.Dock = DockStyle.Top;
            lblFamilyNameHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFamilyNameHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblFamilyNameHeading.Location = new Point(0, 0);
            lblFamilyNameHeading.Name = "lblFamilyNameHeading";
            lblFamilyNameHeading.Size = new Size(267, 20);
            lblFamilyNameHeading.TabIndex = 0;
            lblFamilyNameHeading.Text = "Family name";
            // 
            // pnGivenNameGroup
            // 
            pnGivenNameGroup.AutoSize = true;
            pnGivenNameGroup.Controls.Add(pnGivenNameTextbox);
            pnGivenNameGroup.Controls.Add(lblGivenNameHeading);
            pnGivenNameGroup.Dock = DockStyle.Fill;
            pnGivenNameGroup.Location = new Point(0, 0);
            pnGivenNameGroup.Margin = new Padding(0);
            pnGivenNameGroup.Name = "pnGivenNameGroup";
            pnGivenNameGroup.Padding = new Padding(0, 0, 15, 0);
            pnGivenNameGroup.Size = new Size(277, 56);
            pnGivenNameGroup.TabIndex = 2;
            // 
            // pnGivenNameTextbox
            // 
            pnGivenNameTextbox.AutoSize = true;
            pnGivenNameTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnGivenNameTextbox.Controls.Add(txtGivenName);
            pnGivenNameTextbox.Dock = DockStyle.Fill;
            pnGivenNameTextbox.Location = new Point(0, 20);
            pnGivenNameTextbox.Name = "pnGivenNameTextbox";
            pnGivenNameTextbox.Size = new Size(262, 36);
            pnGivenNameTextbox.TabIndex = 2;
            // 
            // txtGivenName
            // 
            txtGivenName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGivenName.BackColor = Color.FromArgb(44, 52, 64);
            txtGivenName.BorderStyle = BorderStyle.None;
            txtGivenName.Font = new Font("Segoe UI", 10F);
            txtGivenName.ForeColor = Color.FromArgb(168, 160, 149);
            txtGivenName.Location = new Point(4, 9);
            txtGivenName.Name = "txtGivenName";
            txtGivenName.Size = new Size(258, 18);
            txtGivenName.TabIndex = 0;
            // 
            // lblGivenNameHeading
            // 
            lblGivenNameHeading.Dock = DockStyle.Top;
            lblGivenNameHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGivenNameHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblGivenNameHeading.Location = new Point(0, 0);
            lblGivenNameHeading.Name = "lblGivenNameHeading";
            lblGivenNameHeading.Size = new Size(262, 20);
            lblGivenNameHeading.TabIndex = 0;
            lblGivenNameHeading.Text = "Given name";
            // 
            // pnUsernameGroup
            // 
            pnUsernameGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnUsernameGroup.Controls.Add(pnUsernameTextbox);
            pnUsernameGroup.Controls.Add(lblUsernameHeading);
            pnUsernameGroup.Location = new Point(17, 46);
            pnUsernameGroup.Name = "pnUsernameGroup";
            pnUsernameGroup.Size = new Size(544, 56);
            pnUsernameGroup.TabIndex = 1;
            // 
            // pnUsernameTextbox
            // 
            pnUsernameTextbox.AutoSize = true;
            pnUsernameTextbox.BackColor = Color.FromArgb(44, 52, 64);
            pnUsernameTextbox.Controls.Add(txtUsername);
            pnUsernameTextbox.Dock = DockStyle.Fill;
            pnUsernameTextbox.Location = new Point(0, 20);
            pnUsernameTextbox.Name = "pnUsernameTextbox";
            pnUsernameTextbox.Size = new Size(544, 36);
            pnUsernameTextbox.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(44, 52, 64);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(168, 160, 149);
            txtUsername.Location = new Point(4, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(531, 18);
            txtUsername.TabIndex = 0;
            // 
            // lblUsernameHeading
            // 
            lblUsernameHeading.Dock = DockStyle.Top;
            lblUsernameHeading.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsernameHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblUsernameHeading.Location = new Point(0, 0);
            lblUsernameHeading.Name = "lblUsernameHeading";
            lblUsernameHeading.Size = new Size(544, 20);
            lblUsernameHeading.TabIndex = 0;
            lblUsernameHeading.Text = "Username";
            // 
            // lblProfileSection
            // 
            lblProfileSection.AutoSize = true;
            lblProfileSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileSection.ForeColor = Color.FromArgb(232, 230, 227);
            lblProfileSection.Location = new Point(17, 7);
            lblProfileSection.Name = "lblProfileSection";
            lblProfileSection.Size = new Size(67, 25);
            lblProfileSection.TabIndex = 0;
            lblProfileSection.Text = "Profile";
            // 
            // pnRightCol
            // 
            pnRightCol.Controls.Add(pnAvatarSection);
            pnRightCol.Controls.Add(pnFavouriteMoviesSection);
            pnRightCol.Dock = DockStyle.Right;
            pnRightCol.Location = new Point(593, 0);
            pnRightCol.Name = "pnRightCol";
            pnRightCol.Size = new Size(343, 751);
            pnRightCol.TabIndex = 0;
            // 
            // pnAvatarSection
            // 
            pnAvatarSection.Controls.Add(lblAvatarSection);
            pnAvatarSection.Controls.Add(btnSelectAvatar);
            pnAvatarSection.Controls.Add(picAvatar);
            pnAvatarSection.Dock = DockStyle.Fill;
            pnAvatarSection.Location = new Point(0, 0);
            pnAvatarSection.Name = "pnAvatarSection";
            pnAvatarSection.Size = new Size(343, 297);
            pnAvatarSection.TabIndex = 2;
            // 
            // lblAvatarSection
            // 
            lblAvatarSection.AutoSize = true;
            lblAvatarSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvatarSection.ForeColor = Color.FromArgb(232, 230, 227);
            lblAvatarSection.Location = new Point(6, 16);
            lblAvatarSection.Name = "lblAvatarSection";
            lblAvatarSection.Size = new Size(66, 25);
            lblAvatarSection.TabIndex = 10;
            lblAvatarSection.Text = "Avatar";
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Anchor = AnchorStyles.Bottom;
            btnSelectAvatar.BackColor = Color.FromArgb(0, 138, 22);
            btnSelectAvatar.FlatAppearance.BorderSize = 0;
            btnSelectAvatar.FlatStyle = FlatStyle.Flat;
            btnSelectAvatar.Font = new Font("Segoe UI Black", 9.5F, FontStyle.Bold);
            btnSelectAvatar.ForeColor = Color.FromArgb(216, 244, 202);
            btnSelectAvatar.Location = new Point(80, 229);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(180, 30);
            btnSelectAvatar.TabIndex = 9;
            btnSelectAvatar.Text = "SELECT NEW AVATAR";
            btnSelectAvatar.UseVisualStyleBackColor = false;
            btnSelectAvatar.Click += btnSelectAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.None;
            picAvatar.Location = new Point(100, 65);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(140, 140);
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // pnFavouriteMoviesSection
            // 
            pnFavouriteMoviesSection.Controls.Add(pnFavouriteMovieCards);
            pnFavouriteMoviesSection.Controls.Add(lblFavouriteMoviesSection);
            pnFavouriteMoviesSection.Dock = DockStyle.Bottom;
            pnFavouriteMoviesSection.Location = new Point(0, 297);
            pnFavouriteMoviesSection.Name = "pnFavouriteMoviesSection";
            pnFavouriteMoviesSection.Size = new Size(343, 454);
            pnFavouriteMoviesSection.TabIndex = 1;
            // 
            // pnFavouriteMovieCards
            // 
            pnFavouriteMovieCards.BorderStyle = BorderStyle.FixedSingle;
            pnFavouriteMovieCards.Location = new Point(6, 60);
            pnFavouriteMovieCards.Name = "pnFavouriteMovieCards";
            pnFavouriteMovieCards.Size = new Size(330, 162);
            pnFavouriteMovieCards.TabIndex = 2;
            // 
            // lblFavouriteMoviesSection
            // 
            lblFavouriteMoviesSection.AutoSize = true;
            lblFavouriteMoviesSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFavouriteMoviesSection.ForeColor = Color.FromArgb(232, 230, 227);
            lblFavouriteMoviesSection.Location = new Point(6, 20);
            lblFavouriteMoviesSection.Name = "lblFavouriteMoviesSection";
            lblFavouriteMoviesSection.Size = new Size(153, 25);
            lblFavouriteMoviesSection.TabIndex = 1;
            lblFavouriteMoviesSection.Text = "Favourite movies";
            // 
            // pnSettingsNavbar
            // 
            pnSettingsNavbar.BorderStyle = BorderStyle.FixedSingle;
            pnSettingsNavbar.Controls.Add(lblDataTab);
            pnSettingsNavbar.Controls.Add(lblNotificationsTab);
            pnSettingsNavbar.Controls.Add(lblConnectionsTab);
            pnSettingsNavbar.Controls.Add(lblAuthTab);
            pnSettingsNavbar.Controls.Add(lblProfileTab);
            pnSettingsNavbar.Dock = DockStyle.Top;
            pnSettingsNavbar.Location = new Point(0, 0);
            pnSettingsNavbar.Name = "pnSettingsNavbar";
            pnSettingsNavbar.Size = new Size(936, 18);
            pnSettingsNavbar.TabIndex = 0;
            // 
            // lblDataTab
            // 
            lblDataTab.AutoSize = true;
            lblDataTab.Dock = DockStyle.Left;
            lblDataTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDataTab.ForeColor = Color.FromArgb(47, 255, 125);
            lblDataTab.Location = new Point(343, 0);
            lblDataTab.Name = "lblDataTab";
            lblDataTab.Padding = new Padding(5, 0, 5, 0);
            lblDataTab.Size = new Size(50, 17);
            lblDataTab.TabIndex = 4;
            lblDataTab.Text = "DATA";
            // 
            // lblNotificationsTab
            // 
            lblNotificationsTab.AutoSize = true;
            lblNotificationsTab.Dock = DockStyle.Left;
            lblNotificationsTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNotificationsTab.ForeColor = Color.FromArgb(47, 255, 125);
            lblNotificationsTab.Location = new Point(230, 0);
            lblNotificationsTab.Name = "lblNotificationsTab";
            lblNotificationsTab.Padding = new Padding(5, 0, 5, 0);
            lblNotificationsTab.Size = new Size(113, 17);
            lblNotificationsTab.TabIndex = 3;
            lblNotificationsTab.Text = "NOTIFICATIONS";
            // 
            // lblConnectionsTab
            // 
            lblConnectionsTab.AutoSize = true;
            lblConnectionsTab.Dock = DockStyle.Left;
            lblConnectionsTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblConnectionsTab.ForeColor = Color.FromArgb(47, 255, 125);
            lblConnectionsTab.Location = new Point(121, 0);
            lblConnectionsTab.Name = "lblConnectionsTab";
            lblConnectionsTab.Padding = new Padding(5, 0, 5, 0);
            lblConnectionsTab.Size = new Size(109, 17);
            lblConnectionsTab.TabIndex = 2;
            lblConnectionsTab.Text = "CONNECTIONS";
            // 
            // lblAuthTab
            // 
            lblAuthTab.AutoSize = true;
            lblAuthTab.Dock = DockStyle.Left;
            lblAuthTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthTab.ForeColor = Color.FromArgb(47, 255, 125);
            lblAuthTab.Location = new Point(68, 0);
            lblAuthTab.Name = "lblAuthTab";
            lblAuthTab.Padding = new Padding(5, 0, 5, 0);
            lblAuthTab.Size = new Size(53, 17);
            lblAuthTab.TabIndex = 1;
            lblAuthTab.Text = "AUTH";
            // 
            // lblProfileTab
            // 
            lblProfileTab.AutoSize = true;
            lblProfileTab.Dock = DockStyle.Left;
            lblProfileTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProfileTab.ForeColor = Color.FromArgb(232, 230, 227);
            lblProfileTab.Location = new Point(0, 0);
            lblProfileTab.Name = "lblProfileTab";
            lblProfileTab.Padding = new Padding(5, 0, 5, 0);
            lblProfileTab.Size = new Size(68, 17);
            lblProfileTab.TabIndex = 0;
            lblProfileTab.Text = "PROFILE";
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(18, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(btnBack);
            Controls.Add(pnMain);
            Controls.Add(lblSettings);
            Name = "SettingsScreen";
            Size = new Size(976, 859);
            pnMain.ResumeLayout(false);
            pnForm.ResumeLayout(false);
            pnLeftCol.ResumeLayout(false);
            pnLeftCol.PerformLayout();
            pnVisibilityGroup.ResumeLayout(false);
            pnBioGroup.ResumeLayout(false);
            pnBioGroup.PerformLayout();
            tlpLocationAndWebsiteGroup.ResumeLayout(false);
            tlpLocationAndWebsiteGroup.PerformLayout();
            pnWebsiteGroup.ResumeLayout(false);
            pnWebsiteGroup.PerformLayout();
            pnWebsiteTextbox.ResumeLayout(false);
            pnWebsiteTextbox.PerformLayout();
            pnLocationGroup.ResumeLayout(false);
            pnLocationGroup.PerformLayout();
            pnLocationTextbox.ResumeLayout(false);
            pnLocationTextbox.PerformLayout();
            pnEmailGroup.ResumeLayout(false);
            pnEmailGroup.PerformLayout();
            pnEmailTextbox.ResumeLayout(false);
            pnEmailTextbox.PerformLayout();
            tlpNameGroup.ResumeLayout(false);
            tlpNameGroup.PerformLayout();
            pnFamilyNameGroup.ResumeLayout(false);
            pnFamilyNameGroup.PerformLayout();
            pnFamilyNameTextbox.ResumeLayout(false);
            pnFamilyNameTextbox.PerformLayout();
            pnGivenNameGroup.ResumeLayout(false);
            pnGivenNameGroup.PerformLayout();
            pnGivenNameTextbox.ResumeLayout(false);
            pnGivenNameTextbox.PerformLayout();
            pnUsernameGroup.ResumeLayout(false);
            pnUsernameGroup.PerformLayout();
            pnUsernameTextbox.ResumeLayout(false);
            pnUsernameTextbox.PerformLayout();
            pnRightCol.ResumeLayout(false);
            pnAvatarSection.ResumeLayout(false);
            pnAvatarSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnFavouriteMoviesSection.ResumeLayout(false);
            pnFavouriteMoviesSection.PerformLayout();
            pnSettingsNavbar.ResumeLayout(false);
            pnSettingsNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettings;
        private Panel pnMain;
        private Panel pnSettingsNavbar;
        private Label lblDataTab;
        private Label lblNotificationsTab;
        private Label lblConnectionsTab;
        private Label lblAuthTab;
        private Label lblProfileTab;
        private Panel pnForm;
        private Panel pnLeftCol;
        private Label lblProfileSection;
        private Panel pnRightCol;
        private Panel pnUsernameGroup;
        private Label lblUsernameHeading;
        private Panel pnUsernameTextbox;
        private TextBox txtUsername;
        private TableLayoutPanel tlpNameGroup;
        private Panel pnGivenNameGroup;
        private Panel pnGivenNameTextbox;
        private TextBox txtGivenName;
        private Label lblGivenNameHeading;
        private Panel pnFamilyNameGroup;
        private Panel pnFamilyNameTextbox;
        private TextBox txtFamilyName;
        private Label lblFamilyNameHeading;
        private Panel pnEmailGroup;
        private Panel pnEmailTextbox;
        private TextBox txtEmail;
        private Label lblEmailHeading;
        private Panel pnBioGroup;
        private Label lblBioHeading;
        private TableLayoutPanel tlpLocationAndWebsiteGroup;
        private Panel pnWebsiteGroup;
        private Panel pnWebsiteTextbox;
        private TextBox txtWebsite;
        private Label lblWebsiteHeading;
        private Panel pnLocationGroup;
        private Panel pnLocationTextbox;
        private TextBox txtLocation;
        private Label lblLocationHeading;
        private Panel pnVisibilityGroup;
        private Label lblVisibilityHeading;
        private ComboBox cbbVisibility;
        private Button btnSave;
        private Panel pnAvatarSection;
        private Button btnSelectAvatar;
        private PictureBox picAvatar;
        private Panel pnFavouriteMoviesSection;
        private Label lblAvatarSection;
        private Label lblFavouriteMoviesSection;
        private Panel pnFavouriteMovieCards;
        private Button btnBack;
        private TextBox txtBio;
    }
}
