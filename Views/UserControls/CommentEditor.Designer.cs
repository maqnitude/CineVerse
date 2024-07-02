namespace CineVerse.Views.UserControls
{
    partial class CommentEditor
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
            btnCancel = new Button();
            btnComment = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(30, 38, 46);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(541, 132);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnComment
            // 
            btnComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComment.BackColor = Color.FromArgb(59, 78, 88);
            btnComment.FlatAppearance.BorderSize = 0;
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.ForeColor = Color.White;
            btnComment.Location = new Point(622, 132);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(75, 23);
            btnComment.TabIndex = 0;
            btnComment.Text = "Comment";
            btnComment.UseVisualStyleBackColor = false;
            // 
            // rtbContent
            // 
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.BackColor = Color.FromArgb(24, 28, 31);
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.ForeColor = Color.White;
            rtbContent.Location = new Point(3, 3);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(707, 115);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            // 
            // CommentEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(rtbContent);
            Controls.Add(btnComment);
            Controls.Add(btnCancel);
            Name = "CommentEditor";
            Size = new Size(713, 166);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnComment;
        private RichTextBox rtbContent;
    }
}
