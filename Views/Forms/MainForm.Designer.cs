namespace CineVerse.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            pnNavBar = new Panel();
            pSearchAndUser = new Panel();
            pnUserWrapper = new Panel();
            btnUser = new Button();
            picUser = new PictureBox();
            searchBar = new Views.UserControls.SearchBar();
            lblPostsTab = new Label();
            lblListsTab = new Label();
            lblMoviesTab = new Label();
            lblHomeTab = new Label();
            picLogo = new PictureBox();
            pnMain = new Panel();
            cmsUserDropdown = new ContextMenuStrip(components);
            homeToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            diaryToolStripMenuItem = new ToolStripMenuItem();
            reviewsToolStripMenuItem = new ToolStripMenuItem();
            watchlistToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem = new ToolStripMenuItem();
            likesToolStripMenuItem = new ToolStripMenuItem();
            tagsToolStripMenuItem = new ToolStripMenuItem();
            networkToolStripMenuItem = new ToolStripMenuItem();
            separator = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pnNavBar.SuspendLayout();
            pSearchAndUser.SuspendLayout();
            pnUserWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            cmsUserDropdown.SuspendLayout();
            SuspendLayout();
            // 
            // pnNavBar
            // 
            pnNavBar.BackColor = Color.FromArgb(35, 42, 51);
            pnNavBar.Controls.Add(pSearchAndUser);
            pnNavBar.Controls.Add(lblPostsTab);
            pnNavBar.Controls.Add(lblListsTab);
            pnNavBar.Controls.Add(lblMoviesTab);
            pnNavBar.Controls.Add(lblHomeTab);
            pnNavBar.Controls.Add(picLogo);
            pnNavBar.Dock = DockStyle.Top;
            pnNavBar.Location = new Point(0, 0);
            pnNavBar.Name = "pnNavBar";
            pnNavBar.Size = new Size(1354, 58);
            pnNavBar.TabIndex = 0;
            // 
            // pSearchAndUser
            // 
            pSearchAndUser.Anchor = AnchorStyles.Right;
            pSearchAndUser.AutoSize = true;
            pSearchAndUser.Controls.Add(pnUserWrapper);
            pSearchAndUser.Controls.Add(searchBar);
            pSearchAndUser.Location = new Point(990, 7);
            pSearchAndUser.Name = "pSearchAndUser";
            pSearchAndUser.Size = new Size(352, 43);
            pSearchAndUser.TabIndex = 2;
            // 
            // pnUserWrapper
            // 
            pnUserWrapper.AutoSize = true;
            pnUserWrapper.BackColor = Color.FromArgb(0, 138, 22);
            pnUserWrapper.BorderStyle = BorderStyle.FixedSingle;
            pnUserWrapper.Controls.Add(btnUser);
            pnUserWrapper.Controls.Add(picUser);
            pnUserWrapper.Location = new Point(244, 4);
            pnUserWrapper.Name = "pnUserWrapper";
            pnUserWrapper.Size = new Size(103, 36);
            pnUserWrapper.TabIndex = 1;
            // 
            // btnUser
            // 
            btnUser.AutoSize = true;
            btnUser.BackColor = Color.FromArgb(0, 138, 22);
            btnUser.Dock = DockStyle.Fill;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.down;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(36, 0);
            btnUser.Margin = new Padding(8);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(65, 34);
            btnUser.TabIndex = 0;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleRight;
            btnUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Left;
            picUser.Image = Properties.Resources.user_big;
            picUser.Location = new Point(0, 0);
            picUser.Name = "picUser";
            picUser.Size = new Size(36, 34);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Left;
            searchBar.BackColor = Color.FromArgb(44, 52, 64);
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(0, 5);
            searchBar.Margin = new Padding(1);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(233, 36);
            searchBar.TabIndex = 0;
            // 
            // lblPostsTab
            // 
            lblPostsTab.AutoSize = true;
            lblPostsTab.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblPostsTab.ForeColor = Color.FromArgb(178, 172, 162);
            lblPostsTab.Location = new Point(356, 20);
            lblPostsTab.Name = "lblPostsTab";
            lblPostsTab.Size = new Size(117, 21);
            lblPostsTab.TabIndex = 2;
            lblPostsTab.Text = "DISCUSSIONS";
            lblPostsTab.Click += lblPostsTab_Click;
            // 
            // lblListsTab
            // 
            lblListsTab.AutoSize = true;
            lblListsTab.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblListsTab.ForeColor = Color.FromArgb(178, 172, 162);
            lblListsTab.Location = new Point(297, 20);
            lblListsTab.Name = "lblListsTab";
            lblListsTab.Size = new Size(53, 21);
            lblListsTab.TabIndex = 2;
            lblListsTab.Text = "LISTS";
            lblListsTab.Click += lblListsTab_Click;
            // 
            // lblMoviesTab
            // 
            lblMoviesTab.AutoSize = true;
            lblMoviesTab.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblMoviesTab.ForeColor = Color.FromArgb(178, 172, 162);
            lblMoviesTab.Location = new Point(218, 20);
            lblMoviesTab.Name = "lblMoviesTab";
            lblMoviesTab.Size = new Size(73, 21);
            lblMoviesTab.TabIndex = 2;
            lblMoviesTab.Text = "MOVIES";
            lblMoviesTab.Click += lblMoviesTab_Click;
            // 
            // lblHomeTab
            // 
            lblHomeTab.AutoSize = true;
            lblHomeTab.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblHomeTab.ForeColor = Color.FromArgb(178, 172, 162);
            lblHomeTab.Location = new Point(152, 20);
            lblHomeTab.Name = "lblHomeTab";
            lblHomeTab.Size = new Size(60, 21);
            lblHomeTab.TabIndex = 2;
            lblHomeTab.Text = "HOME";
            lblHomeTab.Click += lblHomeTab_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.cineverse_logo;
            picLogo.Location = new Point(12, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 50);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnMain
            // 
            pnMain.AutoScroll = true;
            pnMain.BackColor = Color.FromArgb(16, 19, 22);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 58);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1354, 884);
            pnMain.TabIndex = 1;
            // 
            // cmsUserDropdown
            // 
            cmsUserDropdown.BackColor = Color.FromArgb(72, 87, 101);
            cmsUserDropdown.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, profileToolStripMenuItem, moviesToolStripMenuItem, diaryToolStripMenuItem, reviewsToolStripMenuItem, watchlistToolStripMenuItem, listsToolStripMenuItem, likesToolStripMenuItem, tagsToolStripMenuItem, networkToolStripMenuItem, separator, settingsToolStripMenuItem, signOutToolStripMenuItem });
            cmsUserDropdown.Name = "cmsUserDropdown";
            cmsUserDropdown.RenderMode = ToolStripRenderMode.System;
            cmsUserDropdown.Size = new Size(125, 274);
            cmsUserDropdown.Closed += cmsUserDropdown_Closed;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            homeToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(124, 22);
            homeToolStripMenuItem.Text = "Home";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            profileToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(124, 22);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            moviesToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            moviesToolStripMenuItem.Size = new Size(124, 22);
            moviesToolStripMenuItem.Text = "Movies";
            // 
            // diaryToolStripMenuItem
            // 
            diaryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            diaryToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            diaryToolStripMenuItem.Size = new Size(124, 22);
            diaryToolStripMenuItem.Text = "Diary";
            // 
            // reviewsToolStripMenuItem
            // 
            reviewsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            reviewsToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            reviewsToolStripMenuItem.Size = new Size(124, 22);
            reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // watchlistToolStripMenuItem
            // 
            watchlistToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            watchlistToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            watchlistToolStripMenuItem.Name = "watchlistToolStripMenuItem";
            watchlistToolStripMenuItem.Size = new Size(124, 22);
            watchlistToolStripMenuItem.Text = "Watchlist";
            // 
            // listsToolStripMenuItem
            // 
            listsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            listsToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            listsToolStripMenuItem.Size = new Size(124, 22);
            listsToolStripMenuItem.Text = "Lists";
            // 
            // likesToolStripMenuItem
            // 
            likesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            likesToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            likesToolStripMenuItem.Name = "likesToolStripMenuItem";
            likesToolStripMenuItem.Size = new Size(124, 22);
            likesToolStripMenuItem.Text = "Likes";
            // 
            // tagsToolStripMenuItem
            // 
            tagsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            tagsToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Size = new Size(124, 22);
            tagsToolStripMenuItem.Text = "Tags";
            // 
            // networkToolStripMenuItem
            // 
            networkToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            networkToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            networkToolStripMenuItem.Size = new Size(124, 22);
            networkToolStripMenuItem.Text = "Network";
            // 
            // separator
            // 
            separator.Name = "separator";
            separator.Size = new Size(121, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            settingsToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(124, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            signOutToolStripMenuItem.ForeColor = Color.FromArgb(198, 193, 185);
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(124, 22);
            signOutToolStripMenuItem.Text = "Sign out";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 942);
            Controls.Add(pnMain);
            Controls.Add(pnNavBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "CineVerse";
            pnNavBar.ResumeLayout(false);
            pnNavBar.PerformLayout();
            pSearchAndUser.ResumeLayout(false);
            pSearchAndUser.PerformLayout();
            pnUserWrapper.ResumeLayout(false);
            pnUserWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            cmsUserDropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNavBar;
        private Panel pnMain;
        private Button btnUser;
        private PictureBox picLogo;
        private Views.UserControls.SearchBar searchBar;
        private Label lblHomeTab;
        private Label lblListsTab;
        private Label lblMoviesTab;
        private Label lblPostsTab;
        private Panel pnUserWrapper;
        private PictureBox picUser;
        private Panel pSearchAndUser;
        private ContextMenuStrip cmsUserDropdown;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem diaryToolStripMenuItem;
        private ToolStripMenuItem reviewsToolStripMenuItem;
        private ToolStripMenuItem watchlistToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem likesToolStripMenuItem;
        private ToolStripMenuItem tagsToolStripMenuItem;
        private ToolStripMenuItem networkToolStripMenuItem;
        private ToolStripSeparator separator;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
    }
}