namespace CineVerse.Views.UserControls
{
    partial class CommentItem
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
            pnHeader = new Panel();
            picUser = new PictureBox();
            pnPostInfo = new Panel();
            lblTitle = new Label();
            pnBy = new Panel();
            lblUsername = new Label();
            lblBy = new Label();
            lblCreatedAt = new Label();
            panel4 = new Panel();
            rtbContent = new RichTextBox();
            pnToolBar = new Panel();
            btnReply = new Button();
            btnDownvote = new Button();
            btnUpvote = new Button();
            btnReport = new Button();
            btnIgnore = new Button();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnPostInfo.SuspendLayout();
            pnBy.SuspendLayout();
            panel4.SuspendLayout();
            pnToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.FromArgb(38, 48, 58);
            pnHeader.Controls.Add(picUser);
            pnHeader.Controls.Add(pnPostInfo);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(802, 70);
            pnHeader.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Location = new Point(13, 7);
            picUser.Name = "picUser";
            picUser.Size = new Size(43, 43);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // pnPostInfo
            // 
            pnPostInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnPostInfo.AutoSize = true;
            pnPostInfo.Controls.Add(lblTitle);
            pnPostInfo.Controls.Add(pnBy);
            pnPostInfo.Location = new Point(75, 6);
            pnPostInfo.Name = "pnPostInfo";
            pnPostInfo.Size = new Size(718, 56);
            pnPostInfo.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitle.Location = new Point(0, 1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(474, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Oppenheimer released in Japan - whose dumb idea was that?";
            // 
            // pnBy
            // 
            pnBy.AutoSize = true;
            pnBy.Controls.Add(lblUsername);
            pnBy.Controls.Add(lblBy);
            pnBy.Controls.Add(lblCreatedAt);
            pnBy.Location = new Point(3, 32);
            pnBy.Name = "pnBy";
            pnBy.Size = new Size(280, 21);
            pnBy.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(45, 210, 239);
            lblUsername.Location = new Point(59, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(56, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "rooprect";
            // 
            // lblBy
            // 
            lblBy.AutoSize = true;
            lblBy.Dock = DockStyle.Left;
            lblBy.ForeColor = Color.FromArgb(232, 230, 227);
            lblBy.Location = new Point(0, 0);
            lblBy.Name = "lblBy";
            lblBy.Size = new Size(59, 15);
            lblBy.TabIndex = 1;
            lblBy.Text = "posted by";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Dock = DockStyle.Right;
            lblCreatedAt.ForeColor = Color.FromArgb(232, 230, 227);
            lblCreatedAt.Location = new Point(115, 0);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(165, 15);
            lblCreatedAt.TabIndex = 0;
            lblCreatedAt.Text = " on March 30, 2024 at 2:48 AM";
            // 
            // panel4
            // 
            panel4.Controls.Add(rtbContent);
            panel4.Controls.Add(pnToolBar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(802, 144);
            panel4.TabIndex = 1;
            // 
            // rtbContent
            // 
            rtbContent.BackColor = Color.FromArgb(16, 19, 22);
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Location = new Point(0, 0);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(802, 111);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            // 
            // pnToolBar
            // 
            pnToolBar.BackColor = Color.FromArgb(16, 19, 22);
            pnToolBar.BorderStyle = BorderStyle.FixedSingle;
            pnToolBar.Controls.Add(btnReply);
            pnToolBar.Controls.Add(btnDownvote);
            pnToolBar.Controls.Add(btnUpvote);
            pnToolBar.Controls.Add(btnReport);
            pnToolBar.Controls.Add(btnIgnore);
            pnToolBar.Dock = DockStyle.Bottom;
            pnToolBar.Location = new Point(0, 111);
            pnToolBar.Name = "pnToolBar";
            pnToolBar.Size = new Size(802, 33);
            pnToolBar.TabIndex = 0;
            // 
            // btnReply
            // 
            btnReply.AutoSize = true;
            btnReply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReply.FlatAppearance.BorderSize = 0;
            btnReply.FlatStyle = FlatStyle.Flat;
            btnReply.ForeColor = Color.FromArgb(170, 170, 170);
            btnReply.Image = Properties.Resources.quote;
            btnReply.Location = new Point(183, 1);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(65, 25);
            btnReply.TabIndex = 2;
            btnReply.Text = "Reply";
            btnReply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReply.UseVisualStyleBackColor = true;
            btnReply.Click += btnReply_Click;
            btnReply.MouseEnter += btnReply_MouseEnter;
            btnReply.MouseLeave += btnReply_MouseLeave;
            // 
            // btnDownvote
            // 
            btnDownvote.AutoSize = true;
            btnDownvote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDownvote.FlatAppearance.BorderSize = 0;
            btnDownvote.FlatStyle = FlatStyle.Flat;
            btnDownvote.ForeColor = Color.FromArgb(170, 170, 170);
            btnDownvote.Image = Properties.Resources.downvote;
            btnDownvote.Location = new Point(89, 1);
            btnDownvote.Name = "btnDownvote";
            btnDownvote.Size = new Size(87, 25);
            btnDownvote.TabIndex = 1;
            btnDownvote.Text = "Downvote";
            btnDownvote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDownvote.UseVisualStyleBackColor = true;
            btnDownvote.Click += btnDownvote_Click;
            btnDownvote.MouseEnter += btnDownvote_MouseEnter;
            btnDownvote.MouseLeave += btnDownvote_MouseLeave;
            // 
            // btnUpvote
            // 
            btnUpvote.AutoSize = true;
            btnUpvote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpvote.FlatAppearance.BorderSize = 0;
            btnUpvote.FlatStyle = FlatStyle.Flat;
            btnUpvote.ForeColor = Color.FromArgb(170, 170, 170);
            btnUpvote.Image = Properties.Resources.upvote;
            btnUpvote.Location = new Point(10, 1);
            btnUpvote.Name = "btnUpvote";
            btnUpvote.Size = new Size(71, 25);
            btnUpvote.TabIndex = 1;
            btnUpvote.Text = "Upvote";
            btnUpvote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpvote.UseVisualStyleBackColor = true;
            btnUpvote.Click += btnUpvote_Click;
            btnUpvote.MouseEnter += btnUpvote_MouseEnter;
            btnUpvote.MouseLeave += btnUpvote_MouseLeave;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReport.AutoSize = true;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.FromArgb(170, 170, 170);
            btnReport.Location = new Point(683, 1);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(52, 29);
            btnReport.TabIndex = 0;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnIgnore
            // 
            btnIgnore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIgnore.AutoSize = true;
            btnIgnore.FlatAppearance.BorderSize = 0;
            btnIgnore.FlatStyle = FlatStyle.Flat;
            btnIgnore.ForeColor = Color.FromArgb(170, 170, 170);
            btnIgnore.Location = new Point(741, 1);
            btnIgnore.Name = "btnIgnore";
            btnIgnore.Size = new Size(51, 29);
            btnIgnore.TabIndex = 0;
            btnIgnore.Text = "Ignore";
            btnIgnore.UseVisualStyleBackColor = true;
            // 
            // CommentItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(panel4);
            Controls.Add(pnHeader);
            Name = "CommentItem";
            Size = new Size(802, 343);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnPostInfo.ResumeLayout(false);
            pnPostInfo.PerformLayout();
            pnBy.ResumeLayout(false);
            pnBy.PerformLayout();
            panel4.ResumeLayout(false);
            pnToolBar.ResumeLayout(false);
            pnToolBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private PictureBox picUser;
        private Panel pnPostInfo;
        private Label lblTitle;
        private Panel pnBy;
        private Label lblUsername;
        private Label lblBy;
        private Label lblCreatedAt;
        private Panel panel4;
        private Panel pnToolBar;
        private Button btnReport;
        private Button btnIgnore;
        private Button btnReply;
        private Button btnUpvote;
        private RichTextBox rtbContent;
        private Button btnDownvote;
    }
}
