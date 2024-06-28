﻿namespace CineVerse.Views.UserControls
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Location = new Point(2, 2);
            picUser.Margin = new Padding(2);
            picUser.Name = "picUser";
            picUser.Size = new Size(35, 35);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblReviewBy
            // 
            lblReviewBy.AutoSize = true;
            lblReviewBy.Location = new Point(41, 2);
            lblReviewBy.Margin = new Padding(2, 0, 2, 0);
            lblReviewBy.Name = "lblReviewBy";
            lblReviewBy.Size = new Size(60, 15);
            lblReviewBy.TabIndex = 1;
            lblReviewBy.Text = "Review by";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(164, 184, 200);
            lblUsername.Location = new Point(100, 2);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(41, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Lukas";
            // 
            // lblContent
            // 
            lblContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContent.BackColor = Color.Transparent;
            lblContent.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent.Location = new Point(41, 22);
            lblContent.Margin = new Padding(2, 0, 2, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(409, 50);
            lblContent.TabIndex = 3;
            lblContent.Text = "Where's horny???";
            // 
            // btnLike
            // 
            btnLike.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.ForeColor = Color.FromArgb(157, 148, 136);
            btnLike.Image = Properties.Resources.like_small;
            btnLike.Location = new Point(41, 74);
            btnLike.Margin = new Padding(2);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(90, 25);
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
            btnReply.Location = new Point(123, 75);
            btnReply.Margin = new Padding(2);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(55, 25);
            btnReply.TabIndex = 5;
            btnReply.Text = "176";
            btnReply.TextAlign = ContentAlignment.MiddleRight;
            btnReply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReply.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.star;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Dock = DockStyle.Fill;
            lblRating.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ScrollBar;
            lblRating.Location = new Point(20, 0);
            lblRating.Margin = new Padding(0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(18, 20);
            lblRating.TabIndex = 7;
            lblRating.Text = "4";
            lblRating.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMaxRating
            // 
            lblMaxRating.Dock = DockStyle.Right;
            lblMaxRating.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaxRating.ForeColor = SystemColors.ScrollBar;
            lblMaxRating.Location = new Point(38, 0);
            lblMaxRating.Margin = new Padding(0);
            lblMaxRating.Name = "lblMaxRating";
            lblMaxRating.Size = new Size(24, 20);
            lblMaxRating.TabIndex = 8;
            lblMaxRating.Text = "/5";
            lblMaxRating.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblMaxRating);
            panel1.Location = new Point(388, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 20);
            panel1.TabIndex = 9;
            // 
            // ReviewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 27);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(btnReply);
            Controls.Add(btnLike);
            Controls.Add(lblContent);
            Controls.Add(lblUsername);
            Controls.Add(lblReviewBy);
            Controls.Add(picUser);
            ForeColor = Color.FromArgb(178, 172, 162);
            Margin = new Padding(2);
            Name = "ReviewItem";
            Size = new Size(461, 101);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}
