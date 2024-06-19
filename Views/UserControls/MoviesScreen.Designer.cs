namespace CineVerse.Views.UserControls
{
    partial class MoviesScreen
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
            pnlBrowseTooBar = new Panel();
            lblBrowseBy = new Label();
            menuStrip1 = new MenuStrip();
            dECADEToolStripMenuItem = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            upcomingToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem1 = new ToolStripMenuItem();
            sToolStripMenuItem2 = new ToolStripMenuItem();
            sToolStripMenuItem3 = new ToolStripMenuItem();
            sToolStripMenuItem4 = new ToolStripMenuItem();
            sToolStripMenuItem5 = new ToolStripMenuItem();
            sToolStripMenuItem6 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            rATINGToolStripMenuItem = new ToolStripMenuItem();
            highestToolStripMenuItem = new ToolStripMenuItem();
            lowestToolStripMenuItem = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            gENREToolStripMenuItem = new ToolStripMenuItem();
            actionToolStripMenuItem = new ToolStripMenuItem();
            fantasyToolStripMenuItem = new ToolStripMenuItem();
            horrorToolStripMenuItem = new ToolStripMenuItem();
            scienceFictionToolStripMenuItem = new ToolStripMenuItem();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            flpMovieCardsContainer = new FlowLayoutPanel();
            pnlBrowseTooBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrowseTooBar
            // 
            pnlBrowseTooBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBrowseTooBar.BackColor = Color.FromArgb(18, 22, 26);
            pnlBrowseTooBar.Controls.Add(lblBrowseBy);
            pnlBrowseTooBar.Controls.Add(menuStrip1);
            pnlBrowseTooBar.Controls.Add(menuStrip2);
            pnlBrowseTooBar.Controls.Add(menuStrip3);
            pnlBrowseTooBar.Location = new Point(0, 0);
            pnlBrowseTooBar.Margin = new Padding(0);
            pnlBrowseTooBar.Name = "pnlBrowseTooBar";
            pnlBrowseTooBar.Size = new Size(992, 32);
            pnlBrowseTooBar.TabIndex = 0;
            // 
            // lblBrowseBy
            // 
            lblBrowseBy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrowseBy.ForeColor = Color.White;
            lblBrowseBy.Location = new Point(4, 0);
            lblBrowseBy.Margin = new Padding(4, 0, 4, 0);
            lblBrowseBy.Name = "lblBrowseBy";
            lblBrowseBy.Size = new Size(96, 32);
            lblBrowseBy.TabIndex = 0;
            lblBrowseBy.Text = "BROWSE BY";
            lblBrowseBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(120, 120, 120);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dECADEToolStripMenuItem });
            menuStrip1.Location = new Point(104, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(56, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dECADEToolStripMenuItem
            // 
            dECADEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allToolStripMenuItem, upcomingToolStripMenuItem, sToolStripMenuItem, sToolStripMenuItem1, sToolStripMenuItem2, sToolStripMenuItem3, sToolStripMenuItem4, sToolStripMenuItem5, sToolStripMenuItem6 });
            dECADEToolStripMenuItem.Name = "dECADEToolStripMenuItem";
            dECADEToolStripMenuItem.Size = new Size(48, 28);
            dECADEToolStripMenuItem.Text = "YEAR";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(131, 22);
            allToolStripMenuItem.Text = "All";
            // 
            // upcomingToolStripMenuItem
            // 
            upcomingToolStripMenuItem.Name = "upcomingToolStripMenuItem";
            upcomingToolStripMenuItem.Size = new Size(131, 22);
            upcomingToolStripMenuItem.Text = "Upcoming";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(131, 22);
            sToolStripMenuItem.Text = "2020s";
            // 
            // sToolStripMenuItem1
            // 
            sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            sToolStripMenuItem1.Size = new Size(131, 22);
            sToolStripMenuItem1.Text = "2010s";
            // 
            // sToolStripMenuItem2
            // 
            sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            sToolStripMenuItem2.Size = new Size(131, 22);
            sToolStripMenuItem2.Text = "2000s";
            // 
            // sToolStripMenuItem3
            // 
            sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            sToolStripMenuItem3.Size = new Size(131, 22);
            sToolStripMenuItem3.Text = "1990s";
            // 
            // sToolStripMenuItem4
            // 
            sToolStripMenuItem4.Name = "sToolStripMenuItem4";
            sToolStripMenuItem4.Size = new Size(131, 22);
            sToolStripMenuItem4.Text = "1980s";
            // 
            // sToolStripMenuItem5
            // 
            sToolStripMenuItem5.Name = "sToolStripMenuItem5";
            sToolStripMenuItem5.Size = new Size(131, 22);
            sToolStripMenuItem5.Text = "1970s";
            // 
            // sToolStripMenuItem6
            // 
            sToolStripMenuItem6.Name = "sToolStripMenuItem6";
            sToolStripMenuItem6.Size = new Size(131, 22);
            sToolStripMenuItem6.Text = "1960s";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.FromArgb(120, 120, 120);
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip2.Items.AddRange(new ToolStripItem[] { rATINGToolStripMenuItem });
            menuStrip2.Location = new Point(160, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(72, 32);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // rATINGToolStripMenuItem
            // 
            rATINGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { highestToolStripMenuItem, lowestToolStripMenuItem });
            rATINGToolStripMenuItem.Name = "rATINGToolStripMenuItem";
            rATINGToolStripMenuItem.Size = new Size(63, 28);
            rATINGToolStripMenuItem.Text = "RATING";
            // 
            // highestToolStripMenuItem
            // 
            highestToolStripMenuItem.Name = "highestToolStripMenuItem";
            highestToolStripMenuItem.Size = new Size(117, 22);
            highestToolStripMenuItem.Text = "Highest";
            // 
            // lowestToolStripMenuItem
            // 
            lowestToolStripMenuItem.Name = "lowestToolStripMenuItem";
            lowestToolStripMenuItem.Size = new Size(117, 22);
            lowestToolStripMenuItem.Text = "Lowest";
            // 
            // menuStrip3
            // 
            menuStrip3.AutoSize = false;
            menuStrip3.BackColor = Color.FromArgb(120, 120, 120);
            menuStrip3.Dock = DockStyle.None;
            menuStrip3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip3.Items.AddRange(new ToolStripItem[] { gENREToolStripMenuItem });
            menuStrip3.Location = new Point(232, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(64, 32);
            menuStrip3.TabIndex = 3;
            menuStrip3.Text = "menuStrip3";
            // 
            // gENREToolStripMenuItem
            // 
            gENREToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { actionToolStripMenuItem, fantasyToolStripMenuItem, horrorToolStripMenuItem, scienceFictionToolStripMenuItem });
            gENREToolStripMenuItem.Name = "gENREToolStripMenuItem";
            gENREToolStripMenuItem.Size = new Size(57, 28);
            gENREToolStripMenuItem.Text = "GENRE";
            // 
            // actionToolStripMenuItem
            // 
            actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            actionToolStripMenuItem.Size = new Size(157, 22);
            actionToolStripMenuItem.Text = "Action";
            // 
            // fantasyToolStripMenuItem
            // 
            fantasyToolStripMenuItem.Name = "fantasyToolStripMenuItem";
            fantasyToolStripMenuItem.Size = new Size(157, 22);
            fantasyToolStripMenuItem.Text = "Fantasy";
            // 
            // horrorToolStripMenuItem
            // 
            horrorToolStripMenuItem.Name = "horrorToolStripMenuItem";
            horrorToolStripMenuItem.Size = new Size(157, 22);
            horrorToolStripMenuItem.Text = "Horror";
            // 
            // scienceFictionToolStripMenuItem
            // 
            scienceFictionToolStripMenuItem.Name = "scienceFictionToolStripMenuItem";
            scienceFictionToolStripMenuItem.Size = new Size(157, 22);
            scienceFictionToolStripMenuItem.Text = "Science Fiction";
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNextPage.Location = new Point(892, 497);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(96, 32);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrevPage.Location = new Point(4, 497);
            btnPrevPage.Margin = new Padding(4);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(96, 32);
            btnPrevPage.TabIndex = 2;
            btnPrevPage.Text = "Previous";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // flpMovieCardsContainer
            // 
            flpMovieCardsContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpMovieCardsContainer.AutoScroll = true;
            flpMovieCardsContainer.Location = new Point(4, 36);
            flpMovieCardsContainer.Margin = new Padding(4);
            flpMovieCardsContainer.Name = "flpMovieCardsContainer";
            flpMovieCardsContainer.Padding = new Padding(4);
            flpMovieCardsContainer.Size = new Size(984, 453);
            flpMovieCardsContainer.TabIndex = 3;
            // 
            // MoviesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 40, 47);
            Controls.Add(flpMovieCardsContainer);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Controls.Add(pnlBrowseTooBar);
            Name = "MoviesScreen";
            Size = new Size(992, 533);
            pnlBrowseTooBar.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBrowseTooBar;
        private Label lblBrowseBy;
        private Button btnNextPage;
        private Button btnPrevPage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dECADEToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem upcomingToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem1;
        private ToolStripMenuItem sToolStripMenuItem2;
        private ToolStripMenuItem sToolStripMenuItem3;
        private ToolStripMenuItem sToolStripMenuItem4;
        private ToolStripMenuItem sToolStripMenuItem5;
        private ToolStripMenuItem sToolStripMenuItem6;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem rATINGToolStripMenuItem;
        private ToolStripMenuItem highestToolStripMenuItem;
        private ToolStripMenuItem lowestToolStripMenuItem;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem gENREToolStripMenuItem;
        private ToolStripMenuItem actionToolStripMenuItem;
        private ToolStripMenuItem fantasyToolStripMenuItem;
        private ToolStripMenuItem horrorToolStripMenuItem;
        private ToolStripMenuItem scienceFictionToolStripMenuItem;
        private FlowLayoutPanel flpMovieCardsContainer;
    }
}
