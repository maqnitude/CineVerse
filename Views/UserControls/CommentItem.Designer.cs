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
            pnPostInfo = new Panel();
            picUser = new PictureBox();
            pnHeader = new Panel();
            pnTitle = new Label();
            pnBy = new Panel();
            lblUsername = new Label();
            lblBy = new Label();
            lblDateTime = new Label();
            panel4 = new Panel();
            rtbContent = new RichTextBox();
            pnToolBar = new Panel();
            btnReply = new Button();
            btnLike = new Button();
            btnReport = new Button();
            btnIgnore = new Button();
            pnPostInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnHeader.SuspendLayout();
            pnBy.SuspendLayout();
            panel4.SuspendLayout();
            pnToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnPostInfo
            // 
            pnPostInfo.BackColor = Color.FromArgb(38, 48, 58);
            pnPostInfo.Controls.Add(picUser);
            pnPostInfo.Controls.Add(pnHeader);
            pnPostInfo.Dock = DockStyle.Top;
            pnPostInfo.Location = new Point(0, 0);
            pnPostInfo.Name = "pnPostInfo";
            pnPostInfo.Size = new Size(802, 70);
            pnPostInfo.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Location = new Point(13, 7);
            picUser.Name = "picUser";
            picUser.Size = new Size(43, 43);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // pnHeader
            // 
            pnHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnHeader.AutoSize = true;
            pnHeader.Controls.Add(pnTitle);
            pnHeader.Controls.Add(pnBy);
            pnHeader.Location = new Point(75, 6);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(718, 56);
            pnHeader.TabIndex = 1;
            // 
            // pnTitle
            // 
            pnTitle.AutoSize = true;
            pnTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnTitle.ForeColor = Color.FromArgb(232, 230, 227);
            pnTitle.Location = new Point(0, 1);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(474, 21);
            pnTitle.TabIndex = 1;
            pnTitle.Text = "Oppenheimer released in Japan - whose dumb idea was that?";
            // 
            // pnBy
            // 
            pnBy.AutoSize = true;
            pnBy.Controls.Add(lblUsername);
            pnBy.Controls.Add(lblBy);
            pnBy.Controls.Add(lblDateTime);
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
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Dock = DockStyle.Right;
            lblDateTime.ForeColor = Color.FromArgb(232, 230, 227);
            lblDateTime.Location = new Point(115, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(165, 15);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = " on March 30, 2024 at 2:48 AM";
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
            pnToolBar.Controls.Add(btnLike);
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
            btnReply.FlatAppearance.BorderSize = 0;
            btnReply.FlatStyle = FlatStyle.Flat;
            btnReply.ForeColor = Color.FromArgb(170, 170, 170);
            btnReply.Image = Properties.Resources.quote;
            btnReply.Location = new Point(71, 1);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(69, 29);
            btnReply.TabIndex = 2;
            btnReply.Text = "Reply";
            btnReply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReply.UseVisualStyleBackColor = true;
            btnReply.Click += btnReply_Click;
            btnReply.MouseEnter += btnReply_MouseEnter;
            btnReply.MouseLeave += btnReply_MouseLeave;
            // 
            // btnLike
            // 
            btnLike.AutoSize = true;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.ForeColor = Color.FromArgb(170, 170, 170);
            btnLike.Image = Properties.Resources.comment_like;
            btnLike.Location = new Point(10, 1);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(57, 29);
            btnLike.TabIndex = 1;
            btnLike.Text = "Like";
            btnLike.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            btnLike.MouseEnter += btnLike_MouseEnter;
            btnLike.MouseLeave += btnLike_MouseLeave;
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
            Controls.Add(pnPostInfo);
            Name = "CommentItem";
            Size = new Size(802, 343);
            pnPostInfo.ResumeLayout(false);
            pnPostInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnBy.ResumeLayout(false);
            pnBy.PerformLayout();
            panel4.ResumeLayout(false);
            pnToolBar.ResumeLayout(false);
            pnToolBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnPostInfo;
        private PictureBox picUser;
        private Panel pnHeader;
        private Label pnTitle;
        private Panel pnBy;
        private Label lblUsername;
        private Label lblBy;
        private Label lblDateTime;
        private Panel panel4;
        private Panel pnToolBar;
        private Button btnReport;
        private Button btnIgnore;
        private Button btnReply;
        private Button btnLike;
        private RichTextBox rtbContent;
    }
}
