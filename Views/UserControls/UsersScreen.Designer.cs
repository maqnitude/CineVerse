namespace CineVerse.Views.UserControls
{
    partial class UsersScreen
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
            pnColumnRight = new Panel();
            pnFolloweesBlock = new Panel();
            pnFolloweesList = new Panel();
            pnFollowingHeader = new Panel();
            btnMoreFollowing = new Button();
            pnFollowingHeading = new Label();
            pnPopularMembersBlock = new Panel();
            pnPopularMembersList = new Panel();
            pnPopularHeader = new Panel();
            btnMorePopular = new Button();
            lblPopularHeading = new Label();
            pnColumnLeft = new Panel();
            pnPublicMembersBlock = new Panel();
            pnPublicMembersList = new Panel();
            pnTableHeader = new Panel();
            pnColStats = new Panel();
            lblColLists = new Label();
            lblColLikes = new Label();
            lblColWatched = new Label();
            lblColName = new Label();
            pnPublicHeader = new Panel();
            btnMorePublic = new Button();
            lblPublicHeading = new Label();
            pnColumnRight.SuspendLayout();
            pnFolloweesBlock.SuspendLayout();
            pnFollowingHeader.SuspendLayout();
            pnPopularMembersBlock.SuspendLayout();
            pnPopularHeader.SuspendLayout();
            pnColumnLeft.SuspendLayout();
            pnPublicMembersBlock.SuspendLayout();
            pnTableHeader.SuspendLayout();
            pnColStats.SuspendLayout();
            pnPublicHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnColumnRight
            // 
            pnColumnRight.Controls.Add(pnFolloweesBlock);
            pnColumnRight.Controls.Add(pnPopularMembersBlock);
            pnColumnRight.Dock = DockStyle.Right;
            pnColumnRight.Location = new Point(742, 0);
            pnColumnRight.Name = "pnColumnRight";
            pnColumnRight.Size = new Size(258, 800);
            pnColumnRight.TabIndex = 0;
            // 
            // pnFolloweesBlock
            // 
            pnFolloweesBlock.Controls.Add(pnFolloweesList);
            pnFolloweesBlock.Controls.Add(pnFollowingHeader);
            pnFolloweesBlock.Location = new Point(22, 370);
            pnFolloweesBlock.Name = "pnFolloweesBlock";
            pnFolloweesBlock.Size = new Size(216, 288);
            pnFolloweesBlock.TabIndex = 0;
            // 
            // pnFolloweesList
            // 
            pnFolloweesList.Dock = DockStyle.Fill;
            pnFolloweesList.Location = new Point(0, 22);
            pnFolloweesList.Name = "pnFolloweesList";
            pnFolloweesList.Size = new Size(216, 266);
            pnFolloweesList.TabIndex = 2;
            // 
            // pnFollowingHeader
            // 
            pnFollowingHeader.BorderStyle = BorderStyle.FixedSingle;
            pnFollowingHeader.Controls.Add(btnMoreFollowing);
            pnFollowingHeader.Controls.Add(pnFollowingHeading);
            pnFollowingHeader.Dock = DockStyle.Top;
            pnFollowingHeader.Location = new Point(0, 0);
            pnFollowingHeader.Name = "pnFollowingHeader";
            pnFollowingHeader.Size = new Size(216, 22);
            pnFollowingHeader.TabIndex = 1;
            // 
            // btnMoreFollowing
            // 
            btnMoreFollowing.AutoSize = true;
            btnMoreFollowing.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMoreFollowing.Dock = DockStyle.Right;
            btnMoreFollowing.FlatAppearance.BorderSize = 0;
            btnMoreFollowing.FlatStyle = FlatStyle.Flat;
            btnMoreFollowing.ForeColor = Color.FromArgb(157, 148, 136);
            btnMoreFollowing.Location = new Point(169, 0);
            btnMoreFollowing.Name = "btnMoreFollowing";
            btnMoreFollowing.Size = new Size(45, 20);
            btnMoreFollowing.TabIndex = 1;
            btnMoreFollowing.Text = "More";
            btnMoreFollowing.TextAlign = ContentAlignment.TopCenter;
            btnMoreFollowing.UseVisualStyleBackColor = true;
            // 
            // pnFollowingHeading
            // 
            pnFollowingHeading.AutoSize = true;
            pnFollowingHeading.Dock = DockStyle.Left;
            pnFollowingHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnFollowingHeading.ForeColor = Color.FromArgb(178, 172, 162);
            pnFollowingHeading.Location = new Point(0, 0);
            pnFollowingHeading.Name = "pnFollowingHeading";
            pnFollowingHeading.Size = new Size(83, 17);
            pnFollowingHeading.TabIndex = 0;
            pnFollowingHeading.Text = "FOLLOWING";
            // 
            // pnPopularMembersBlock
            // 
            pnPopularMembersBlock.Controls.Add(pnPopularMembersList);
            pnPopularMembersBlock.Controls.Add(pnPopularHeader);
            pnPopularMembersBlock.Location = new Point(22, 49);
            pnPopularMembersBlock.Name = "pnPopularMembersBlock";
            pnPopularMembersBlock.Size = new Size(216, 288);
            pnPopularMembersBlock.TabIndex = 0;
            // 
            // pnPopularMembersList
            // 
            pnPopularMembersList.Dock = DockStyle.Fill;
            pnPopularMembersList.Location = new Point(0, 22);
            pnPopularMembersList.Name = "pnPopularMembersList";
            pnPopularMembersList.Size = new Size(216, 266);
            pnPopularMembersList.TabIndex = 1;
            // 
            // pnPopularHeader
            // 
            pnPopularHeader.BorderStyle = BorderStyle.FixedSingle;
            pnPopularHeader.Controls.Add(btnMorePopular);
            pnPopularHeader.Controls.Add(lblPopularHeading);
            pnPopularHeader.Dock = DockStyle.Top;
            pnPopularHeader.Location = new Point(0, 0);
            pnPopularHeader.Name = "pnPopularHeader";
            pnPopularHeader.Size = new Size(216, 22);
            pnPopularHeader.TabIndex = 0;
            // 
            // btnMorePopular
            // 
            btnMorePopular.AutoSize = true;
            btnMorePopular.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMorePopular.Dock = DockStyle.Right;
            btnMorePopular.FlatAppearance.BorderSize = 0;
            btnMorePopular.FlatStyle = FlatStyle.Flat;
            btnMorePopular.ForeColor = Color.FromArgb(157, 148, 136);
            btnMorePopular.Location = new Point(169, 0);
            btnMorePopular.Name = "btnMorePopular";
            btnMorePopular.Size = new Size(45, 20);
            btnMorePopular.TabIndex = 1;
            btnMorePopular.Text = "More";
            btnMorePopular.TextAlign = ContentAlignment.TopCenter;
            btnMorePopular.UseVisualStyleBackColor = true;
            // 
            // lblPopularHeading
            // 
            lblPopularHeading.AutoSize = true;
            lblPopularHeading.Dock = DockStyle.Left;
            lblPopularHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopularHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblPopularHeading.Location = new Point(0, 0);
            lblPopularHeading.Name = "lblPopularHeading";
            lblPopularHeading.Size = new Size(139, 17);
            lblPopularHeading.TabIndex = 0;
            lblPopularHeading.Text = "POPULAR REVIEWERS";
            // 
            // pnColumnLeft
            // 
            pnColumnLeft.Controls.Add(pnPublicMembersBlock);
            pnColumnLeft.Dock = DockStyle.Fill;
            pnColumnLeft.Location = new Point(0, 0);
            pnColumnLeft.Name = "pnColumnLeft";
            pnColumnLeft.Size = new Size(742, 800);
            pnColumnLeft.TabIndex = 1;
            // 
            // pnPublicMembersBlock
            // 
            pnPublicMembersBlock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnPublicMembersBlock.Controls.Add(pnPublicMembersList);
            pnPublicMembersBlock.Controls.Add(pnTableHeader);
            pnPublicMembersBlock.Controls.Add(pnPublicHeader);
            pnPublicMembersBlock.Location = new Point(47, 49);
            pnPublicMembersBlock.Name = "pnPublicMembersBlock";
            pnPublicMembersBlock.Size = new Size(644, 696);
            pnPublicMembersBlock.TabIndex = 0;
            // 
            // pnPublicMembersList
            // 
            pnPublicMembersList.Dock = DockStyle.Fill;
            pnPublicMembersList.Location = new Point(0, 51);
            pnPublicMembersList.Name = "pnPublicMembersList";
            pnPublicMembersList.Size = new Size(644, 645);
            pnPublicMembersList.TabIndex = 2;
            // 
            // pnTableHeader
            // 
            pnTableHeader.BackColor = Color.Black;
            pnTableHeader.BorderStyle = BorderStyle.FixedSingle;
            pnTableHeader.Controls.Add(pnColStats);
            pnTableHeader.Controls.Add(lblColName);
            pnTableHeader.Dock = DockStyle.Top;
            pnTableHeader.Location = new Point(0, 22);
            pnTableHeader.Name = "pnTableHeader";
            pnTableHeader.Size = new Size(644, 29);
            pnTableHeader.TabIndex = 1;
            // 
            // pnColStats
            // 
            pnColStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnColStats.Controls.Add(lblColLists);
            pnColStats.Controls.Add(lblColLikes);
            pnColStats.Controls.Add(lblColWatched);
            pnColStats.Location = new Point(382, 2);
            pnColStats.Name = "pnColStats";
            pnColStats.Size = new Size(180, 19);
            pnColStats.TabIndex = 1;
            // 
            // lblColLists
            // 
            lblColLists.Anchor = AnchorStyles.None;
            lblColLists.AutoSize = true;
            lblColLists.ForeColor = Color.FromArgb(178, 172, 162);
            lblColLists.Location = new Point(78, 0);
            lblColLists.Name = "lblColLists";
            lblColLists.Size = new Size(34, 15);
            lblColLists.TabIndex = 0;
            lblColLists.Text = "LISTS";
            // 
            // lblColLikes
            // 
            lblColLikes.Anchor = AnchorStyles.Right;
            lblColLikes.AutoSize = true;
            lblColLikes.ForeColor = Color.FromArgb(178, 172, 162);
            lblColLikes.Location = new Point(141, 0);
            lblColLikes.Name = "lblColLikes";
            lblColLikes.Size = new Size(35, 15);
            lblColLikes.TabIndex = 0;
            lblColLikes.Text = "LIKES";
            // 
            // lblColWatched
            // 
            lblColWatched.Anchor = AnchorStyles.Left;
            lblColWatched.AutoSize = true;
            lblColWatched.ForeColor = Color.FromArgb(178, 172, 162);
            lblColWatched.Location = new Point(0, 0);
            lblColWatched.Name = "lblColWatched";
            lblColWatched.Size = new Size(61, 15);
            lblColWatched.TabIndex = 0;
            lblColWatched.Text = "WATCHED";
            // 
            // lblColName
            // 
            lblColName.AutoSize = true;
            lblColName.ForeColor = Color.FromArgb(178, 172, 162);
            lblColName.Location = new Point(2, 2);
            lblColName.Name = "lblColName";
            lblColName.Size = new Size(41, 15);
            lblColName.TabIndex = 0;
            lblColName.Text = "NAME";
            // 
            // pnPublicHeader
            // 
            pnPublicHeader.BackColor = Color.FromArgb(24, 26, 27);
            pnPublicHeader.Controls.Add(btnMorePublic);
            pnPublicHeader.Controls.Add(lblPublicHeading);
            pnPublicHeader.Dock = DockStyle.Top;
            pnPublicHeader.Location = new Point(0, 0);
            pnPublicHeader.Name = "pnPublicHeader";
            pnPublicHeader.Size = new Size(644, 22);
            pnPublicHeader.TabIndex = 0;
            // 
            // btnMorePublic
            // 
            btnMorePublic.AutoSize = true;
            btnMorePublic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMorePublic.Dock = DockStyle.Right;
            btnMorePublic.FlatAppearance.BorderSize = 0;
            btnMorePublic.FlatStyle = FlatStyle.Flat;
            btnMorePublic.ForeColor = Color.FromArgb(157, 148, 136);
            btnMorePublic.Location = new Point(599, 0);
            btnMorePublic.Name = "btnMorePublic";
            btnMorePublic.Size = new Size(45, 22);
            btnMorePublic.TabIndex = 2;
            btnMorePublic.Text = "More";
            btnMorePublic.TextAlign = ContentAlignment.TopCenter;
            btnMorePublic.UseVisualStyleBackColor = true;
            // 
            // lblPublicHeading
            // 
            lblPublicHeading.AutoSize = true;
            lblPublicHeading.Dock = DockStyle.Left;
            lblPublicHeading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblPublicHeading.Location = new Point(0, 0);
            lblPublicHeading.Name = "lblPublicHeading";
            lblPublicHeading.Size = new Size(132, 20);
            lblPublicHeading.TabIndex = 0;
            lblPublicHeading.Text = "PUBLIC MEMBERS";
            // 
            // UsersScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(pnColumnLeft);
            Controls.Add(pnColumnRight);
            Name = "UsersScreen";
            Size = new Size(1000, 800);
            pnColumnRight.ResumeLayout(false);
            pnFolloweesBlock.ResumeLayout(false);
            pnFollowingHeader.ResumeLayout(false);
            pnFollowingHeader.PerformLayout();
            pnPopularMembersBlock.ResumeLayout(false);
            pnPopularHeader.ResumeLayout(false);
            pnPopularHeader.PerformLayout();
            pnColumnLeft.ResumeLayout(false);
            pnPublicMembersBlock.ResumeLayout(false);
            pnTableHeader.ResumeLayout(false);
            pnTableHeader.PerformLayout();
            pnColStats.ResumeLayout(false);
            pnColStats.PerformLayout();
            pnPublicHeader.ResumeLayout(false);
            pnPublicHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnColumnRight;
        private Panel pnColumnLeft;
        private Panel pnPublicMembersBlock;
        private Panel pnFolloweesBlock;
        private Panel pnPopularMembersBlock;
        private Panel pnPopularHeader;
        private Label lblPopularHeading;
        private Button btnMorePopular;
        private Panel pnPublicHeader;
        private Label lblPublicHeading;
        private Button btnMorePublic;
        private Panel pnTableHeader;
        private Label lblColLists;
        private Label lblColLikes;
        private Label lblColWatched;
        private Label lblColName;
        private Panel pnColStats;
        private Panel pnFollowingHeader;
        private Button btnMoreFollowing;
        private Label pnFollowingHeading;
        private Panel pnFolloweesList;
        private Panel pnPopularMembersList;
        private Panel pnPublicMembersList;
    }
}
