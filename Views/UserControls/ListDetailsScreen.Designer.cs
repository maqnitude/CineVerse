namespace CineVerse.Views.UserControls
{
    partial class ListDetailsScreen
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
            pnUserSummary = new Panel();
            pnListByUser = new Panel();
            lblUser = new Label();
            lblListBy = new Label();
            picUser = new PictureBox();
            picBackdrop = new PictureBox();
            pnMovieCards = new Panel();
            flpMovieCards = new FlowLayoutPanel();
            pnColumn2 = new Panel();
            pnActions = new Panel();
            pnShareAction = new Panel();
            btnShare = new Button();
            pnLikeAction = new Panel();
            btnLike = new Button();
            pnColumn1 = new Panel();
            pnListTitleIntro = new Panel();
            lblListOverview = new Label();
            lblListTitle = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            pnUserSummary.SuspendLayout();
            pnListByUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBackdrop).BeginInit();
            pnMovieCards.SuspendLayout();
            pnColumn2.SuspendLayout();
            pnActions.SuspendLayout();
            pnShareAction.SuspendLayout();
            pnLikeAction.SuspendLayout();
            pnColumn1.SuspendLayout();
            pnListTitleIntro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnUserSummary
            // 
            pnUserSummary.Controls.Add(pnListByUser);
            pnUserSummary.Controls.Add(picUser);
            pnUserSummary.Dock = DockStyle.Top;
            pnUserSummary.Location = new Point(0, 0);
            pnUserSummary.Name = "pnUserSummary";
            pnUserSummary.Size = new Size(825, 38);
            pnUserSummary.TabIndex = 0;
            // 
            // pnListByUser
            // 
            pnListByUser.AutoSize = true;
            pnListByUser.Controls.Add(lblUser);
            pnListByUser.Controls.Add(lblListBy);
            pnListByUser.Location = new Point(39, 7);
            pnListByUser.Name = "pnListByUser";
            pnListByUser.Size = new Size(112, 25);
            pnListByUser.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(164, 184, 200);
            lblUser.Location = new Point(41, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(69, 15);
            lblUser.TabIndex = 1;
            lblUser.Text = "Zanderific";
            // 
            // lblListBy
            // 
            lblListBy.AutoSize = true;
            lblListBy.Dock = DockStyle.Left;
            lblListBy.ForeColor = Color.FromArgb(178, 172, 162);
            lblListBy.Location = new Point(0, 0);
            lblListBy.Name = "lblListBy";
            lblListBy.Size = new Size(41, 15);
            lblListBy.TabIndex = 0;
            lblListBy.Text = "List by";
            // 
            // picUser
            // 
            picUser.Location = new Point(8, 7);
            picUser.Name = "picUser";
            picUser.Size = new Size(25, 25);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // picBackdrop
            // 
            picBackdrop.Dock = DockStyle.Top;
            picBackdrop.Location = new Point(0, 0);
            picBackdrop.Name = "picBackdrop";
            picBackdrop.Size = new Size(1206, 379);
            picBackdrop.SizeMode = PictureBoxSizeMode.Zoom;
            picBackdrop.TabIndex = 1;
            picBackdrop.TabStop = false;
            // 
            // pnMovieCards
            // 
            pnMovieCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnMovieCards.AutoSize = true;
            pnMovieCards.Controls.Add(flpMovieCards);
            pnMovieCards.Location = new Point(39, 152);
            pnMovieCards.Name = "pnMovieCards";
            pnMovieCards.Size = new Size(753, 409);
            pnMovieCards.TabIndex = 2;
            // 
            // flpMovieCards
            // 
            flpMovieCards.AutoScroll = true;
            flpMovieCards.Dock = DockStyle.Fill;
            flpMovieCards.Location = new Point(0, 0);
            flpMovieCards.Name = "flpMovieCards";
            flpMovieCards.Size = new Size(753, 409);
            flpMovieCards.TabIndex = 0;
            // 
            // pnColumn2
            // 
            pnColumn2.Controls.Add(pnActions);
            pnColumn2.Dock = DockStyle.Right;
            pnColumn2.Location = new Point(825, 0);
            pnColumn2.Name = "pnColumn2";
            pnColumn2.Size = new Size(175, 573);
            pnColumn2.TabIndex = 3;
            // 
            // pnActions
            // 
            pnActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnActions.Controls.Add(pnShareAction);
            pnActions.Controls.Add(pnLikeAction);
            pnActions.Location = new Point(4, 19);
            pnActions.Name = "pnActions";
            pnActions.Size = new Size(166, 80);
            pnActions.TabIndex = 0;
            // 
            // pnShareAction
            // 
            pnShareAction.Controls.Add(btnShare);
            pnShareAction.Dock = DockStyle.Top;
            pnShareAction.Location = new Point(0, 40);
            pnShareAction.Name = "pnShareAction";
            pnShareAction.Size = new Size(166, 40);
            pnShareAction.TabIndex = 1;
            // 
            // btnShare
            // 
            btnShare.BackColor = Color.FromArgb(54, 68, 82);
            btnShare.Dock = DockStyle.Fill;
            btnShare.FlatStyle = FlatStyle.Flat;
            btnShare.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShare.ForeColor = Color.FromArgb(173, 196, 214);
            btnShare.Location = new Point(0, 0);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(166, 40);
            btnShare.TabIndex = 0;
            btnShare.Text = "Share";
            btnShare.UseVisualStyleBackColor = false;
            // 
            // pnLikeAction
            // 
            pnLikeAction.Controls.Add(btnLike);
            pnLikeAction.Dock = DockStyle.Top;
            pnLikeAction.Location = new Point(0, 0);
            pnLikeAction.Name = "pnLikeAction";
            pnLikeAction.Size = new Size(166, 40);
            pnLikeAction.TabIndex = 0;
            // 
            // btnLike
            // 
            btnLike.BackColor = Color.FromArgb(54, 68, 82);
            btnLike.Dock = DockStyle.Fill;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLike.ForeColor = Color.FromArgb(173, 196, 214);
            btnLike.Image = Properties.Resources.like_small;
            btnLike.ImageAlign = ContentAlignment.MiddleRight;
            btnLike.Location = new Point(0, 0);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(166, 40);
            btnLike.TabIndex = 0;
            btnLike.Text = " Like this list?";
            btnLike.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLike.UseVisualStyleBackColor = false;
            // 
            // pnColumn1
            // 
            pnColumn1.Controls.Add(pnListTitleIntro);
            pnColumn1.Controls.Add(pnUserSummary);
            pnColumn1.Controls.Add(pnMovieCards);
            pnColumn1.Dock = DockStyle.Fill;
            pnColumn1.Location = new Point(0, 0);
            pnColumn1.Name = "pnColumn1";
            pnColumn1.Size = new Size(825, 573);
            pnColumn1.TabIndex = 4;
            // 
            // pnListTitleIntro
            // 
            pnListTitleIntro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnListTitleIntro.AutoScroll = true;
            pnListTitleIntro.AutoSize = true;
            pnListTitleIntro.Controls.Add(lblListOverview);
            pnListTitleIntro.Controls.Add(lblListTitle);
            pnListTitleIntro.Location = new Point(37, 55);
            pnListTitleIntro.Name = "pnListTitleIntro";
            pnListTitleIntro.Size = new Size(755, 94);
            pnListTitleIntro.TabIndex = 3;
            // 
            // lblListOverview
            // 
            lblListOverview.Dock = DockStyle.Fill;
            lblListOverview.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListOverview.ForeColor = Color.FromArgb(178, 172, 162);
            lblListOverview.Location = new Point(0, 40);
            lblListOverview.Name = "lblListOverview";
            lblListOverview.Size = new Size(755, 54);
            lblListOverview.TabIndex = 1;
            lblListOverview.Text = "Movies that are so weird, weird to the point where you audibly react multiple times. It doesn’t matter if it’s a good weird or a bad weird, it’s just weird as fuck for a very specific reason.";
            // 
            // lblListTitle
            // 
            lblListTitle.Dock = DockStyle.Top;
            lblListTitle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblListTitle.Location = new Point(0, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(755, 40);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Movies That Will Make You Say “What the Fuck” At Least 3 Times\r\n\r\n";
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnColumn1);
            panel1.Controls.Add(pnColumn2);
            panel1.Location = new Point(103, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 573);
            panel1.TabIndex = 9;
            // 
            // ListDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(picBackdrop);
            Name = "ListDetailsScreen";
            Size = new Size(1206, 961);
            pnUserSummary.ResumeLayout(false);
            pnUserSummary.PerformLayout();
            pnListByUser.ResumeLayout(false);
            pnListByUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBackdrop).EndInit();
            pnMovieCards.ResumeLayout(false);
            pnColumn2.ResumeLayout(false);
            pnActions.ResumeLayout(false);
            pnShareAction.ResumeLayout(false);
            pnLikeAction.ResumeLayout(false);
            pnColumn1.ResumeLayout(false);
            pnColumn1.PerformLayout();
            pnListTitleIntro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnUserSummary;
        private Panel pnListByUser;
        private Label lblUser;
        private Label lblListBy;
        private PictureBox picUser;
        private PictureBox picBackdrop;
        private Panel pnMovieCards;
        private Panel pnColumn2;
        private Panel pnColumn1;
        private Panel pnListTitleIntro;
        private Label lblListOverview;
        private Label lblListTitle;
        private Panel pnActions;
        private Panel pnShareAction;
        private Panel pnLikeAction;
        private Button btnLike;
        private Button btnShare;
        private Button btnBack;
        private FlowLayoutPanel flpMovieCards;
        private Panel panel1;
    }
}
