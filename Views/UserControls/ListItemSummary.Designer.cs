namespace CineVerse.Views.UserControls
{
    partial class ListItemSummary
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
            pnPosters = new Panel();
            picPoster5 = new PictureBox();
            picPoster4 = new PictureBox();
            picPoster3 = new PictureBox();
            picPoster2 = new PictureBox();
            picPoster1 = new PictureBox();
            lblListTitle = new Label();
            pnUser = new Panel();
            lblUsername = new Label();
            picUserAvatar = new PictureBox();
            lblNumMovies = new Label();
            lblListDescription = new Label();
            pnUserAndNumFilms = new Panel();
            pnPosters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoster4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoster3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoster2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoster1).BeginInit();
            pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            pnUserAndNumFilms.SuspendLayout();
            SuspendLayout();
            // 
            // pnPosters
            // 
            pnPosters.Controls.Add(picPoster5);
            pnPosters.Controls.Add(picPoster4);
            pnPosters.Controls.Add(picPoster3);
            pnPosters.Controls.Add(picPoster2);
            pnPosters.Controls.Add(picPoster1);
            pnPosters.Location = new Point(10, 6);
            pnPosters.Name = "pnPosters";
            pnPosters.Size = new Size(300, 150);
            pnPosters.TabIndex = 0;
            // 
            // picPoster5
            // 
            picPoster5.Location = new Point(200, 0);
            picPoster5.Name = "picPoster5";
            picPoster5.Size = new Size(100, 150);
            picPoster5.TabIndex = 4;
            picPoster5.TabStop = false;
            // 
            // picPoster4
            // 
            picPoster4.Location = new Point(150, 0);
            picPoster4.Name = "picPoster4";
            picPoster4.Size = new Size(100, 150);
            picPoster4.TabIndex = 3;
            picPoster4.TabStop = false;
            // 
            // picPoster3
            // 
            picPoster3.Location = new Point(100, 0);
            picPoster3.Name = "picPoster3";
            picPoster3.Size = new Size(100, 150);
            picPoster3.TabIndex = 2;
            picPoster3.TabStop = false;
            // 
            // picPoster2
            // 
            picPoster2.Location = new Point(50, 0);
            picPoster2.Name = "picPoster2";
            picPoster2.Size = new Size(100, 150);
            picPoster2.TabIndex = 1;
            picPoster2.TabStop = false;
            // 
            // picPoster1
            // 
            picPoster1.Location = new Point(0, 0);
            picPoster1.Name = "picPoster1";
            picPoster1.Size = new Size(100, 150);
            picPoster1.TabIndex = 0;
            picPoster1.TabStop = false;
            // 
            // lblListTitle
            // 
            lblListTitle.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblListTitle.Location = new Point(326, 6);
            lblListTitle.MaximumSize = new Size(0, 600);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(557, 29);
            lblListTitle.TabIndex = 1;
            lblListTitle.Text = "Movies That Will Make You Say “What the Fuck” At Least 3 Times";
            // 
            // pnUser
            // 
            pnUser.AutoSize = true;
            pnUser.Controls.Add(lblUsername);
            pnUser.Controls.Add(picUserAvatar);
            pnUser.Dock = DockStyle.Left;
            pnUser.Location = new Point(0, 0);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(68, 25);
            pnUser.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(164, 184, 200);
            lblUsername.Location = new Point(24, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(44, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "alanis";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picUserAvatar
            // 
            picUserAvatar.Dock = DockStyle.Left;
            picUserAvatar.Image = Properties.Resources.user;
            picUserAvatar.Location = new Point(0, 0);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.Size = new Size(24, 25);
            picUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picUserAvatar.TabIndex = 0;
            picUserAvatar.TabStop = false;
            // 
            // lblNumMovies
            // 
            lblNumMovies.AutoSize = true;
            lblNumMovies.Dock = DockStyle.Left;
            lblNumMovies.ForeColor = Color.FromArgb(157, 148, 136);
            lblNumMovies.Location = new Point(68, 0);
            lblNumMovies.Name = "lblNumMovies";
            lblNumMovies.Size = new Size(54, 15);
            lblNumMovies.TabIndex = 3;
            lblNumMovies.Text = "173 films";
            lblNumMovies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblListDescription
            // 
            lblListDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListDescription.Font = new Font("Segoe UI", 10F);
            lblListDescription.ForeColor = Color.FromArgb(178, 172, 162);
            lblListDescription.Location = new Point(326, 70);
            lblListDescription.Name = "lblListDescription";
            lblListDescription.Size = new Size(557, 70);
            lblListDescription.TabIndex = 4;
            lblListDescription.Text = "Movies that are so weird, weird to the point where you audibly react multiple times. It doesn’t matter if it’s…";
            // 
            // pnUserAndNumFilms
            // 
            pnUserAndNumFilms.AutoSize = true;
            pnUserAndNumFilms.Controls.Add(lblNumMovies);
            pnUserAndNumFilms.Controls.Add(pnUser);
            pnUserAndNumFilms.Location = new Point(326, 38);
            pnUserAndNumFilms.Name = "pnUserAndNumFilms";
            pnUserAndNumFilms.Size = new Size(133, 25);
            pnUserAndNumFilms.TabIndex = 5;
            // 
            // ListItemSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 27);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnUserAndNumFilms);
            Controls.Add(lblListDescription);
            Controls.Add(lblListTitle);
            Controls.Add(pnPosters);
            Name = "ListItemSummary";
            Size = new Size(910, 163);
            pnPosters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoster4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoster3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoster2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoster1).EndInit();
            pnUser.ResumeLayout(false);
            pnUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).EndInit();
            pnUserAndNumFilms.ResumeLayout(false);
            pnUserAndNumFilms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnPosters;
        private Label lblListTitle;
        private Panel pnUser;
        private PictureBox picUserAvatar;
        private Label lblUsername;
        private Label lblNumMovies;
        private Label lblListDescription;
        private PictureBox picPoster4;
        private PictureBox picPoster3;
        private PictureBox picPoster2;
        private PictureBox picPoster1;
        private PictureBox picPoster5;
        private Panel pnUserAndNumFilms;
    }
}
