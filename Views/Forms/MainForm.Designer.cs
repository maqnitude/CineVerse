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
            btnUser = new Button();
            picLogo = new PictureBox();
            ucSearchBar = new Views.UserControls.SearchBar();
            btnMembersTab = new Button();
            btnListsTab = new Button();
            btnMoviesTab = new Button();
            btnHomeTab = new Button();
            pnMain = new Panel();
            pnNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnNavBar
            // 
            pnNavBar.BackColor = Color.FromArgb(18, 22, 26);
            pnNavBar.Controls.Add(btnUser);
            pnNavBar.Controls.Add(picLogo);
            pnNavBar.Controls.Add(ucSearchBar);
            pnNavBar.Controls.Add(btnMembersTab);
            pnNavBar.Controls.Add(btnListsTab);
            pnNavBar.Controls.Add(btnMoviesTab);
            pnNavBar.Controls.Add(btnHomeTab);
            pnNavBar.Dock = DockStyle.Top;
            pnNavBar.Location = new Point(0, 0);
            pnNavBar.Margin = new Padding(4, 5, 4, 5);
            pnNavBar.Name = "pnNavBar";
            pnNavBar.Size = new Size(1626, 70);
            pnNavBar.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(0, 157, 26);
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.user;
            btnUser.ImageAlign = ContentAlignment.TopLeft;
            btnUser.Location = new Point(1470, 15);
            btnUser.Margin = new Padding(11, 13, 11, 13);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(136, 40);
            btnUser.TabIndex = 0;
            btnUser.Text = "User123";
            btnUser.TextAlign = ContentAlignment.MiddleRight;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.cineverse_logo;
            picLogo.Location = new Point(9, 6);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(140, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // ucSearchBar
            // 
            ucSearchBar.BackColor = Color.FromArgb(35, 42, 51);
            ucSearchBar.Location = new Point(1170, 16);
            ucSearchBar.Name = "ucSearchBar";
            ucSearchBar.Size = new Size(267, 37);
            ucSearchBar.TabIndex = 0;
            // 
            // btnMembersTab
            // 
            btnMembersTab.BackColor = Color.FromArgb(68, 85, 102);
            btnMembersTab.FlatAppearance.BorderSize = 0;
            btnMembersTab.FlatStyle = FlatStyle.Flat;
            btnMembersTab.Font = new Font("Segoe UI", 11F);
            btnMembersTab.ForeColor = Color.FromArgb(170, 187, 204);
            btnMembersTab.Location = new Point(588, 15);
            btnMembersTab.Margin = new Padding(0, 13, 6, 13);
            btnMembersTab.Name = "btnMembersTab";
            btnMembersTab.Size = new Size(137, 40);
            btnMembersTab.TabIndex = 0;
            btnMembersTab.Text = "Members";
            btnMembersTab.UseVisualStyleBackColor = false;
            // 
            // btnListsTab
            // 
            btnListsTab.BackColor = Color.FromArgb(68, 85, 102);
            btnListsTab.FlatAppearance.BorderSize = 0;
            btnListsTab.FlatStyle = FlatStyle.Flat;
            btnListsTab.Font = new Font("Segoe UI", 11F);
            btnListsTab.ForeColor = Color.FromArgb(170, 187, 204);
            btnListsTab.Location = new Point(446, 15);
            btnListsTab.Margin = new Padding(0, 13, 6, 13);
            btnListsTab.Name = "btnListsTab";
            btnListsTab.Size = new Size(137, 40);
            btnListsTab.TabIndex = 0;
            btnListsTab.Text = "Lists";
            btnListsTab.UseVisualStyleBackColor = false;
            // 
            // btnMoviesTab
            // 
            btnMoviesTab.BackColor = Color.FromArgb(68, 85, 102);
            btnMoviesTab.FlatAppearance.BorderSize = 0;
            btnMoviesTab.FlatStyle = FlatStyle.Flat;
            btnMoviesTab.Font = new Font("Segoe UI", 11F);
            btnMoviesTab.ForeColor = Color.FromArgb(170, 187, 204);
            btnMoviesTab.Location = new Point(303, 15);
            btnMoviesTab.Margin = new Padding(0, 13, 6, 13);
            btnMoviesTab.Name = "btnMoviesTab";
            btnMoviesTab.Size = new Size(137, 40);
            btnMoviesTab.TabIndex = 0;
            btnMoviesTab.Text = "Movies";
            btnMoviesTab.UseVisualStyleBackColor = false;
            // 
            // btnHomeTab
            // 
            btnHomeTab.BackColor = Color.FromArgb(68, 85, 102);
            btnHomeTab.FlatAppearance.BorderSize = 0;
            btnHomeTab.FlatStyle = FlatStyle.Flat;
            btnHomeTab.Font = new Font("Segoe UI", 11F);
            btnHomeTab.ForeColor = Color.FromArgb(170, 187, 204);
            btnHomeTab.Location = new Point(160, 15);
            btnHomeTab.Margin = new Padding(11, 13, 6, 13);
            btnHomeTab.Name = "btnHomeTab";
            btnHomeTab.Size = new Size(137, 40);
            btnHomeTab.TabIndex = 0;
            btnHomeTab.Text = "Home";
            btnHomeTab.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(31, 40, 47);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 70);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1626, 1115);
            pnMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 1185);
            Controls.Add(pnMain);
            Controls.Add(pnNavBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "CineVerse";
            pnNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNavBar;
        private Button btnHomeTab;
        private Panel pnMain;
        private Button btnUser;
        private PictureBox picLogo;
        private Button btnMoviesTab;
        private Button btnListsTab;
        private Button btnMembersTab;
        private Views.UserControls.SearchBar ucSearchBar;
    }
}