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
            pnNavBar = new Panel();
            pSearchAndUser = new Panel();
            pnUserWrapper = new Panel();
            btnUser = new Button();
            picUser = new PictureBox();
            searchBar = new Views.UserControls.SearchBar();
            lblDiscussionsTab = new Label();
            lblListsTab = new Label();
            lblMoviesTab = new Label();
            lblHomeTab = new Label();
            picLogo = new PictureBox();
            pnMain = new Panel();
            pnNavBar.SuspendLayout();
            pSearchAndUser.SuspendLayout();
            pnUserWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnNavBar
            // 
            pnNavBar.BackColor = Color.FromArgb(35, 42, 51);
            pnNavBar.Controls.Add(pSearchAndUser);
            pnNavBar.Controls.Add(lblDiscussionsTab);
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
            pSearchAndUser.Location = new Point(1009, 7);
            pSearchAndUser.Name = "pSearchAndUser";
            pSearchAndUser.Size = new Size(333, 43);
            pSearchAndUser.TabIndex = 2;
            // 
            // pnUserWrapper
            // 
            pnUserWrapper.AutoSize = true;
            pnUserWrapper.BackColor = Color.FromArgb(0, 157, 26);
            pnUserWrapper.Controls.Add(btnUser);
            pnUserWrapper.Controls.Add(picUser);
            pnUserWrapper.Location = new Point(229, 4);
            pnUserWrapper.Name = "pnUserWrapper";
            pnUserWrapper.Size = new Size(101, 36);
            pnUserWrapper.TabIndex = 1;
            // 
            // btnUser
            // 
            btnUser.AutoSize = true;
            btnUser.BackColor = Color.Transparent;
            btnUser.Dock = DockStyle.Fill;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.down;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(36, 0);
            btnUser.Margin = new Padding(8);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(65, 36);
            btnUser.TabIndex = 0;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleRight;
            btnUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Left;
            picUser.Image = Properties.Resources.user;
            picUser.Location = new Point(0, 0);
            picUser.Name = "picUser";
            picUser.Size = new Size(36, 36);
            picUser.SizeMode = PictureBoxSizeMode.CenterImage;
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
            searchBar.Size = new Size(221, 36);
            searchBar.TabIndex = 0;
            // 
            // lblDiscussionsTab
            // 
            lblDiscussionsTab.AutoSize = true;
            lblDiscussionsTab.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblDiscussionsTab.ForeColor = Color.FromArgb(178, 172, 162);
            lblDiscussionsTab.Location = new Point(356, 20);
            lblDiscussionsTab.Name = "lblDiscussionsTab";
            lblDiscussionsTab.Size = new Size(117, 21);
            lblDiscussionsTab.TabIndex = 2;
            lblDiscussionsTab.Text = "DISCUSSIONS";
            lblDiscussionsTab.Click += lblDiscussionsTab_Click;
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
        private Label lblDiscussionsTab;
        private Panel pnUserWrapper;
        private PictureBox picUser;
        private Panel pSearchAndUser;
    }
}