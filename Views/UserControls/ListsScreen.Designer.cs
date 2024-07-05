namespace CineVerse.Views.UserControls
{
    partial class ListsScreen
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
            pnWrapper = new Panel();
            pnListsContainer = new Panel();
            pnFooter = new Panel();
            btnAddList = new Button();
            pnHeader = new Panel();
            menuStripBrowsingTools = new MenuStrip();
            filterByToolStripMenuItem = new ToolStripMenuItem();
            friendsToolStripMenuItem = new ToolStripMenuItem();
            sortByToolStripMenuItem = new ToolStripMenuItem();
            newestFirstToolStripMenuItem = new ToolStripMenuItem();
            oldestFirstToolStripMenuItem = new ToolStripMenuItem();
            txtSortedBy = new ToolStripTextBox();
            lblHeading = new Label();
            pnWrapper.SuspendLayout();
            pnFooter.SuspendLayout();
            pnHeader.SuspendLayout();
            menuStripBrowsingTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnWrapper
            // 
            pnWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnWrapper.Controls.Add(pnListsContainer);
            pnWrapper.Controls.Add(pnFooter);
            pnWrapper.Controls.Add(pnHeader);
            pnWrapper.Location = new Point(170, 1);
            pnWrapper.Margin = new Padding(128, 64, 128, 64);
            pnWrapper.Name = "pnWrapper";
            pnWrapper.Size = new Size(950, 708);
            pnWrapper.TabIndex = 0;
            // 
            // pnListsContainer
            // 
            pnListsContainer.AutoScroll = true;
            pnListsContainer.BorderStyle = BorderStyle.FixedSingle;
            pnListsContainer.Dock = DockStyle.Fill;
            pnListsContainer.Location = new Point(0, 26);
            pnListsContainer.Name = "pnListsContainer";
            pnListsContainer.Size = new Size(950, 645);
            pnListsContainer.TabIndex = 4;
            // 
            // pnFooter
            // 
            pnFooter.BorderStyle = BorderStyle.FixedSingle;
            pnFooter.Controls.Add(btnAddList);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 671);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(950, 37);
            pnFooter.TabIndex = 3;
            // 
            // btnAddList
            // 
            btnAddList.BackColor = Color.FromArgb(82, 95, 109);
            btnAddList.FlatAppearance.BorderSize = 0;
            btnAddList.FlatStyle = FlatStyle.Flat;
            btnAddList.Font = new Font("Segoe UI", 9F);
            btnAddList.ForeColor = Color.FromArgb(232, 230, 227);
            btnAddList.Location = new Point(865, 4);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(80, 28);
            btnAddList.TabIndex = 1;
            btnAddList.Text = "Add list";
            btnAddList.UseVisualStyleBackColor = false;
            btnAddList.Click += btnAddList_Click;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.FromArgb(32, 38, 45);
            pnHeader.BorderStyle = BorderStyle.FixedSingle;
            pnHeader.Controls.Add(menuStripBrowsingTools);
            pnHeader.Controls.Add(lblHeading);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(950, 26);
            pnHeader.TabIndex = 2;
            // 
            // menuStripBrowsingTools
            // 
            menuStripBrowsingTools.BackColor = Color.FromArgb(32, 38, 45);
            menuStripBrowsingTools.Dock = DockStyle.Fill;
            menuStripBrowsingTools.Items.AddRange(new ToolStripItem[] { filterByToolStripMenuItem, sortByToolStripMenuItem, txtSortedBy });
            menuStripBrowsingTools.Location = new Point(101, 0);
            menuStripBrowsingTools.Name = "menuStripBrowsingTools";
            menuStripBrowsingTools.RenderMode = ToolStripRenderMode.Professional;
            menuStripBrowsingTools.RightToLeft = RightToLeft.Yes;
            menuStripBrowsingTools.Size = new Size(847, 24);
            menuStripBrowsingTools.TabIndex = 1;
            menuStripBrowsingTools.Text = "menuStrip1";
            // 
            // filterByToolStripMenuItem
            // 
            filterByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { friendsToolStripMenuItem });
            filterByToolStripMenuItem.ForeColor = Color.FromArgb(178, 172, 162);
            filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
            filterByToolStripMenuItem.Size = new Size(52, 20);
            filterByToolStripMenuItem.Text = "Public";
            // 
            // friendsToolStripMenuItem
            // 
            friendsToolStripMenuItem.BackColor = Color.FromArgb(32, 38, 45);
            friendsToolStripMenuItem.ForeColor = Color.FromArgb(178, 172, 162);
            friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            friendsToolStripMenuItem.Size = new Size(112, 22);
            friendsToolStripMenuItem.Text = "Friends";
            // 
            // sortByToolStripMenuItem
            // 
            sortByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newestFirstToolStripMenuItem, oldestFirstToolStripMenuItem });
            sortByToolStripMenuItem.ForeColor = Color.FromArgb(178, 172, 162);
            sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            sortByToolStripMenuItem.Size = new Size(87, 20);
            sortByToolStripMenuItem.Text = "Date Created";
            // 
            // newestFirstToolStripMenuItem
            // 
            newestFirstToolStripMenuItem.BackColor = Color.FromArgb(32, 38, 45);
            newestFirstToolStripMenuItem.ForeColor = Color.FromArgb(178, 172, 162);
            newestFirstToolStripMenuItem.Name = "newestFirstToolStripMenuItem";
            newestFirstToolStripMenuItem.Size = new Size(113, 22);
            newestFirstToolStripMenuItem.Text = "Newest";
            newestFirstToolStripMenuItem.Click += newestFirstToolStripMenuItem_Click;
            // 
            // oldestFirstToolStripMenuItem
            // 
            oldestFirstToolStripMenuItem.BackColor = Color.FromArgb(32, 38, 45);
            oldestFirstToolStripMenuItem.ForeColor = Color.FromArgb(178, 172, 162);
            oldestFirstToolStripMenuItem.Name = "oldestFirstToolStripMenuItem";
            oldestFirstToolStripMenuItem.Size = new Size(113, 22);
            oldestFirstToolStripMenuItem.Text = "Oldest";
            oldestFirstToolStripMenuItem.Click += oldestFirstToolStripMenuItem_Click;
            // 
            // txtSortedBy
            // 
            txtSortedBy.BackColor = Color.FromArgb(32, 38, 45);
            txtSortedBy.BorderStyle = BorderStyle.None;
            txtSortedBy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSortedBy.ForeColor = Color.White;
            txtSortedBy.Name = "txtSortedBy";
            txtSortedBy.Size = new Size(100, 20);
            txtSortedBy.Text = "Sorted by";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Dock = DockStyle.Left;
            lblHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.FromArgb(178, 172, 162);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(101, 17);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "POPULAR LISTS";
            // 
            // ListsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnWrapper);
            Name = "ListsScreen";
            Size = new Size(1291, 708);
            pnWrapper.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            menuStripBrowsingTools.ResumeLayout(false);
            menuStripBrowsingTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnWrapper;
        private Button btnAddList;
        private Panel pnListsContainer;
        private Panel pnFooter;
        private Panel pnHeader;
        private Label lblHeading;
        private MenuStrip menuStripBrowsingTools;
        private ToolStripMenuItem filterByToolStripMenuItem;
        private ToolStripMenuItem sortByToolStripMenuItem;
        private ToolStripMenuItem friendsToolStripMenuItem;
        private ToolStripMenuItem newestFirstToolStripMenuItem;
        private ToolStripMenuItem oldestFirstToolStripMenuItem;
        private ToolStripTextBox txtSortedBy;
    }
}
