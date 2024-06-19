namespace CineVerse.Views.UserControls
{
    partial class ReviewItem
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
            lblReviewBy = new Label();
            lblUsername = new Label();
            lblContent = new Label();
            btnLike = new Button();
            btnReply = new Button();
            pictureBox2 = new PictureBox();
            lblRating = new Label();
            lblMaxRating = new Label();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Location = new Point(3, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(50, 50);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblReviewBy
            // 
            lblReviewBy.AutoSize = true;
            lblReviewBy.Location = new Point(59, 3);
            lblReviewBy.Name = "lblReviewBy";
            lblReviewBy.Size = new Size(91, 25);
            lblReviewBy.TabIndex = 1;
            lblReviewBy.Text = "Review by";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(164, 184, 200);
            lblUsername.Location = new Point(143, 3);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Lukas";
            // 
            // lblContent
            // 
            lblContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContent.BackColor = Color.Transparent;
            lblContent.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent.Location = new Point(59, 33);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(587, 47);
            lblContent.TabIndex = 3;
            lblContent.Text = "Where's horny???";
            // 
            // btnLike
            // 
            btnLike.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.ForeColor = Color.FromArgb(157, 148, 136);
            btnLike.Image = Properties.Resources.like;
            btnLike.Location = new Point(59, 83);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(126, 34);
            btnLike.TabIndex = 4;
            btnLike.Text = "Like review";
            btnLike.TextAlign = ContentAlignment.MiddleRight;
            btnLike.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLike.UseVisualStyleBackColor = true;
            // 
            // btnReply
            // 
            btnReply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReply.FlatAppearance.BorderSize = 0;
            btnReply.FlatStyle = FlatStyle.Flat;
            btnReply.ForeColor = Color.FromArgb(157, 148, 136);
            btnReply.Image = Properties.Resources.reply;
            btnReply.Location = new Point(180, 85);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(87, 30);
            btnReply.TabIndex = 5;
            btnReply.Text = "176";
            btnReply.TextAlign = ContentAlignment.MiddleRight;
            btnReply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReply.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.star;
            pictureBox2.Location = new Point(568, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ScrollBar;
            lblRating.Location = new Point(598, 3);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(25, 30);
            lblRating.TabIndex = 7;
            lblRating.Text = "9";
            // 
            // lblMaxRating
            // 
            lblMaxRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaxRating.AutoSize = true;
            lblMaxRating.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaxRating.ForeColor = SystemColors.ScrollBar;
            lblMaxRating.Location = new Point(615, 7);
            lblMaxRating.Name = "lblMaxRating";
            lblMaxRating.Size = new Size(34, 21);
            lblMaxRating.TabIndex = 8;
            lblMaxRating.Text = "/10";
            // 
            // ReviewItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 27);
            Controls.Add(lblMaxRating);
            Controls.Add(lblRating);
            Controls.Add(pictureBox2);
            Controls.Add(btnReply);
            Controls.Add(btnLike);
            Controls.Add(lblContent);
            Controls.Add(lblUsername);
            Controls.Add(lblReviewBy);
            Controls.Add(picUser);
            ForeColor = Color.FromArgb(178, 172, 162);
            Name = "ReviewItem";
            Size = new Size(661, 127);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Label lblReviewBy;
        private Label lblUsername;
        private Label lblContent;
        private Button btnLike;
        private Button btnReply;
        private PictureBox pictureBox2;
        private Label lblRating;
        private Label lblMaxRating;
    }
}
