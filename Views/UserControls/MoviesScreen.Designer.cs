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
            menuStripBrowsingTools = new MenuStrip();
            toolStripMenuDecade = new ToolStripMenuItem();
            toolStripMenuItemAll = new ToolStripMenuItem();
            toolStripMenuItemUpcoming = new ToolStripMenuItem();
            toolStripMenuItem2020s = new ToolStripMenuItem();
            toolStripMenuItem2010s = new ToolStripMenuItem();
            toolStripMenuItem2000s = new ToolStripMenuItem();
            toolStripMenuItem1990s = new ToolStripMenuItem();
            toolStripMenuItem1980s = new ToolStripMenuItem();
            toolStripMenuRating = new ToolStripMenuItem();
            toolStripMenuItemHighest = new ToolStripMenuItem();
            toolStripMenuItemLowest = new ToolStripMenuItem();
            lblBrowseBy = new Label();
            flpMovieCardsContainer = new FlowLayoutPanel();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            lblPageNumber = new Label();
            pnWrapper = new Panel();
            pnFooter = new Panel();
            pnlBrowseTooBar.SuspendLayout();
            menuStripBrowsingTools.SuspendLayout();
            pnWrapper.SuspendLayout();
            pnFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrowseTooBar
            // 
            pnlBrowseTooBar.BackColor = Color.FromArgb(32, 38, 45);
            pnlBrowseTooBar.Controls.Add(menuStripBrowsingTools);
            pnlBrowseTooBar.Controls.Add(lblBrowseBy);
            pnlBrowseTooBar.Dock = DockStyle.Top;
            pnlBrowseTooBar.Location = new Point(0, 0);
            pnlBrowseTooBar.Margin = new Padding(0);
            pnlBrowseTooBar.Name = "pnlBrowseTooBar";
            pnlBrowseTooBar.Size = new Size(950, 22);
            pnlBrowseTooBar.TabIndex = 0;
            // 
            // menuStripBrowsingTools
            // 
            menuStripBrowsingTools.AutoSize = false;
            menuStripBrowsingTools.BackColor = Color.FromArgb(32, 38, 45);
            menuStripBrowsingTools.Dock = DockStyle.None;
            menuStripBrowsingTools.Items.AddRange(new ToolStripItem[] { toolStripMenuDecade, toolStripMenuRating });
            menuStripBrowsingTools.Location = new Point(104, 0);
            menuStripBrowsingTools.Name = "menuStripBrowsingTools";
            menuStripBrowsingTools.RenderMode = ToolStripRenderMode.Professional;
            menuStripBrowsingTools.Size = new Size(258, 24);
            menuStripBrowsingTools.TabIndex = 0;
            menuStripBrowsingTools.Text = "DECADE";
            // 
            // toolStripMenuDecade
            // 
            toolStripMenuDecade.BackColor = Color.FromArgb(32, 38, 45);
            toolStripMenuDecade.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAll, toolStripMenuItemUpcoming, toolStripMenuItem2020s, toolStripMenuItem2010s, toolStripMenuItem2000s, toolStripMenuItem1990s, toolStripMenuItem1980s });
            toolStripMenuDecade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuDecade.ForeColor = Color.FromArgb(178, 172, 162);
            toolStripMenuDecade.Name = "toolStripMenuDecade";
            toolStripMenuDecade.Size = new Size(71, 20);
            toolStripMenuDecade.Text = "DECADE";
            // 
            // toolStripMenuItemAll
            // 
            toolStripMenuItemAll.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItemAll.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItemAll.Name = "toolStripMenuItemAll";
            toolStripMenuItemAll.Size = new Size(180, 22);
            toolStripMenuItemAll.Text = "All";
            toolStripMenuItemAll.Click += toolStripMenuItemAll_Click;
            // 
            // toolStripMenuItemUpcoming
            // 
            toolStripMenuItemUpcoming.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItemUpcoming.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItemUpcoming.Name = "toolStripMenuItemUpcoming";
            toolStripMenuItemUpcoming.Size = new Size(180, 22);
            toolStripMenuItemUpcoming.Text = "Upcoming";
            toolStripMenuItemUpcoming.Click += toolStripMenuItemUpcoming_Click;
            // 
            // toolStripMenuItem2020s
            // 
            toolStripMenuItem2020s.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItem2020s.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItem2020s.Name = "toolStripMenuItem2020s";
            toolStripMenuItem2020s.Size = new Size(180, 22);
            toolStripMenuItem2020s.Text = "2020s";
            toolStripMenuItem2020s.Click += toolStripMenuItem2020s_Click;
            // 
            // toolStripMenuItem2010s
            // 
            toolStripMenuItem2010s.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItem2010s.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItem2010s.Name = "toolStripMenuItem2010s";
            toolStripMenuItem2010s.Size = new Size(180, 22);
            toolStripMenuItem2010s.Text = "2010s";
            toolStripMenuItem2010s.Click += toolStripMenuItem2010s_Click;
            // 
            // toolStripMenuItem2000s
            // 
            toolStripMenuItem2000s.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItem2000s.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItem2000s.Name = "toolStripMenuItem2000s";
            toolStripMenuItem2000s.Size = new Size(180, 22);
            toolStripMenuItem2000s.Text = "2000s";
            toolStripMenuItem2000s.Click += toolStripMenuItem2000s_Click;
            // 
            // toolStripMenuItem1990s
            // 
            toolStripMenuItem1990s.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItem1990s.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItem1990s.Name = "toolStripMenuItem1990s";
            toolStripMenuItem1990s.Size = new Size(180, 22);
            toolStripMenuItem1990s.Text = "1990s";
            toolStripMenuItem1990s.Click += toolStripMenuItem1990s_Click;
            // 
            // toolStripMenuItem1980s
            // 
            toolStripMenuItem1980s.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItem1980s.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItem1980s.Name = "toolStripMenuItem1980s";
            toolStripMenuItem1980s.Size = new Size(180, 22);
            toolStripMenuItem1980s.Text = "1980s";
            toolStripMenuItem1980s.Click += toolStripMenuItem1980s_Click;
            // 
            // toolStripMenuRating
            // 
            toolStripMenuRating.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemHighest, toolStripMenuItemLowest });
            toolStripMenuRating.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuRating.ForeColor = Color.FromArgb(178, 172, 162);
            toolStripMenuRating.Name = "toolStripMenuRating";
            toolStripMenuRating.Size = new Size(67, 20);
            toolStripMenuRating.Text = "RATING";
            // 
            // toolStripMenuItemHighest
            // 
            toolStripMenuItemHighest.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItemHighest.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItemHighest.Name = "toolStripMenuItemHighest";
            toolStripMenuItemHighest.Size = new Size(180, 22);
            toolStripMenuItemHighest.Text = "Highest First";
            toolStripMenuItemHighest.Click += toolStripMenuItemHighest_Click;
            // 
            // toolStripMenuItemLowest
            // 
            toolStripMenuItemLowest.BackColor = Color.FromArgb(72, 87, 101);
            toolStripMenuItemLowest.ForeColor = Color.FromArgb(232, 230, 227);
            toolStripMenuItemLowest.Name = "toolStripMenuItemLowest";
            toolStripMenuItemLowest.Size = new Size(180, 22);
            toolStripMenuItemLowest.Text = "Lowest First";
            toolStripMenuItemLowest.Click += toolStripMenuItemLowest_Click;
            // 
            // lblBrowseBy
            // 
            lblBrowseBy.Dock = DockStyle.Left;
            lblBrowseBy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrowseBy.ForeColor = Color.White;
            lblBrowseBy.Location = new Point(0, 0);
            lblBrowseBy.Margin = new Padding(4, 0, 4, 0);
            lblBrowseBy.Name = "lblBrowseBy";
            lblBrowseBy.Size = new Size(96, 22);
            lblBrowseBy.TabIndex = 0;
            lblBrowseBy.Text = "BROWSE BY";
            lblBrowseBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpMovieCardsContainer
            // 
            flpMovieCardsContainer.AutoScroll = true;
            flpMovieCardsContainer.Dock = DockStyle.Fill;
            flpMovieCardsContainer.Location = new Point(0, 22);
            flpMovieCardsContainer.Margin = new Padding(4);
            flpMovieCardsContainer.Name = "flpMovieCardsContainer";
            flpMovieCardsContainer.Padding = new Padding(4);
            flpMovieCardsContainer.Size = new Size(950, 806);
            flpMovieCardsContainer.TabIndex = 3;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextPage.BackColor = Color.FromArgb(32, 38, 45);
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.ForeColor = Color.FromArgb(178, 172, 162);
            btnNextPage.Location = new Point(891, 0);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(56, 30);
            btnNextPage.TabIndex = 5;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevPage.BackColor = Color.FromArgb(32, 38, 45);
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.ForeColor = Color.FromArgb(178, 172, 162);
            btnPrevPage.Location = new Point(3, 0);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(79, 30);
            btnPrevPage.TabIndex = 6;
            btnPrevPage.Text = "Previous";
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // lblPageNumber
            // 
            lblPageNumber.Anchor = AnchorStyles.Bottom;
            lblPageNumber.AutoSize = true;
            lblPageNumber.BackColor = Color.Transparent;
            lblPageNumber.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.ForeColor = Color.FromArgb(178, 172, 162);
            lblPageNumber.Location = new Point(467, 3);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(18, 21);
            lblPageNumber.TabIndex = 7;
            lblPageNumber.Text = "1";
            // 
            // pnWrapper
            // 
            pnWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnWrapper.Controls.Add(flpMovieCardsContainer);
            pnWrapper.Controls.Add(pnFooter);
            pnWrapper.Controls.Add(pnlBrowseTooBar);
            pnWrapper.Location = new Point(120, 0);
            pnWrapper.Name = "pnWrapper";
            pnWrapper.Size = new Size(950, 858);
            pnWrapper.TabIndex = 8;
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(btnPrevPage);
            pnFooter.Controls.Add(btnNextPage);
            pnFooter.Controls.Add(lblPageNumber);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 828);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(950, 30);
            pnFooter.TabIndex = 0;
            // 
            // MoviesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnWrapper);
            Name = "MoviesScreen";
            Size = new Size(1193, 858);
            pnlBrowseTooBar.ResumeLayout(false);
            menuStripBrowsingTools.ResumeLayout(false);
            menuStripBrowsingTools.PerformLayout();
            pnWrapper.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBrowseTooBar;
        private Label lblBrowseBy;
        private Button btnNextPage;
        private Button btnPrevPage;
        private Label lblPageNumber;
        private Panel pnWrapper;
        private Panel pnFooter;
        private FlowLayoutPanel flpMovieCardsContainer;
        private MenuStrip menuStripBrowsingTools;
        private ToolStripMenuItem toolStripMenuDecade;
        private ToolStripMenuItem toolStripMenuItemAll;
        private ToolStripMenuItem toolStripMenuItemUpcoming;
        private ToolStripMenuItem toolStripMenuItem2020s;
        private ToolStripMenuItem toolStripMenuItem2010s;
        private ToolStripMenuItem toolStripMenuItem2000s;
        private ToolStripMenuItem toolStripMenuItem1990s;
        private ToolStripMenuItem toolStripMenuItem1980s;
        private ToolStripMenuItem toolStripMenuRating;
        private ToolStripMenuItem toolStripMenuItemHighest;
        private ToolStripMenuItem toolStripMenuItemLowest;
    }
}
