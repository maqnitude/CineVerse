namespace CineVerse.Views.UserControls
{
    partial class PostItem
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
            picUser = new PictureBox();
            lblTitle = new Label();
            lblCreatedAt = new Label();
            pnByUser = new Panel();
            lblUsername = new Label();
            lblBy = new Label();
            btnComment = new Button();
            btnUpvote = new Button();
            btnDownvote = new Button();
            pnButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnByUser.SuspendLayout();
            pnButtons.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Location = new Point(12, 10);
            picUser.Name = "picUser";
            picUser.Size = new Size(42, 42);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitle.Location = new Point(73, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Furiosa - a movie that  never should've been made";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.ForeColor = Color.FromArgb(173, 196, 214);
            lblCreatedAt.Location = new Point(637, 17);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(129, 15);
            lblCreatedAt.TabIndex = 2;
            lblCreatedAt.Text = "Jun 28, 2024 at 2:30 AM";
            // 
            // pnByUser
            // 
            pnByUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnByUser.AutoSize = true;
            pnByUser.Controls.Add(lblUsername);
            pnByUser.Controls.Add(lblBy);
            pnByUser.Location = new Point(697, 35);
            pnByUser.Name = "pnByUser";
            pnByUser.Size = new Size(69, 21);
            pnByUser.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.ForeColor = Color.FromArgb(1, 180, 228);
            lblUsername.Location = new Point(20, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(49, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Markoff";
            // 
            // lblBy
            // 
            lblBy.AutoSize = true;
            lblBy.Dock = DockStyle.Left;
            lblBy.ForeColor = Color.FromArgb(173, 196, 214);
            lblBy.Location = new Point(0, 0);
            lblBy.Name = "lblBy";
            lblBy.Size = new Size(20, 15);
            lblBy.TabIndex = 0;
            lblBy.Text = "by";
            // 
            // btnComment
            // 
            btnComment.AutoSize = true;
            btnComment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComment.Dock = DockStyle.Right;
            btnComment.FlatAppearance.BorderSize = 0;
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.ForeColor = Color.FromArgb(173, 196, 214);
            btnComment.Image = Properties.Resources.reply;
            btnComment.Location = new Point(90, 0);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(45, 31);
            btnComment.TabIndex = 6;
            btnComment.Text = "12";
            btnComment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComment.UseVisualStyleBackColor = true;
            // 
            // btnUpvote
            // 
            btnUpvote.AutoSize = true;
            btnUpvote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpvote.Dock = DockStyle.Left;
            btnUpvote.FlatAppearance.BorderSize = 0;
            btnUpvote.FlatStyle = FlatStyle.Flat;
            btnUpvote.ForeColor = Color.FromArgb(173, 196, 214);
            btnUpvote.Image = Properties.Resources.upvote;
            btnUpvote.Location = new Point(0, 0);
            btnUpvote.Name = "btnUpvote";
            btnUpvote.Size = new Size(45, 31);
            btnUpvote.TabIndex = 7;
            btnUpvote.Text = "12";
            btnUpvote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpvote.UseVisualStyleBackColor = true;
            // 
            // btnDownvote
            // 
            btnDownvote.AutoSize = true;
            btnDownvote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDownvote.Dock = DockStyle.Fill;
            btnDownvote.FlatAppearance.BorderSize = 0;
            btnDownvote.FlatStyle = FlatStyle.Flat;
            btnDownvote.ForeColor = Color.FromArgb(173, 196, 214);
            btnDownvote.Image = Properties.Resources.downvote;
            btnDownvote.Location = new Point(45, 0);
            btnDownvote.Name = "btnDownvote";
            btnDownvote.Size = new Size(45, 31);
            btnDownvote.TabIndex = 6;
            btnDownvote.Text = "12";
            btnDownvote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDownvote.UseVisualStyleBackColor = true;
            // 
            // pnButtons
            // 
            pnButtons.AutoSize = true;
            pnButtons.Controls.Add(btnDownvote);
            pnButtons.Controls.Add(btnUpvote);
            pnButtons.Controls.Add(btnComment);
            pnButtons.Location = new Point(73, 42);
            pnButtons.Name = "pnButtons";
            pnButtons.Size = new Size(135, 31);
            pnButtons.TabIndex = 8;
            // 
            // PostItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 68, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnButtons);
            Controls.Add(pnByUser);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblTitle);
            Controls.Add(picUser);
            Name = "PostItem";
            Size = new Size(778, 72);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnByUser.ResumeLayout(false);
            pnByUser.PerformLayout();
            pnButtons.ResumeLayout(false);
            pnButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Label lblTitle;
        private Label lblCreatedAt;
        private Panel pnByUser;
        private Label lblUsername;
        private Label lblBy;
        private Button btnComment;
        private Button btnUpvote;
        private Button btnDownvote;
        private Panel pnButtons;
    }
}
