namespace CineVerse.Views.UserControls
{
    partial class PostDetailsScreen
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
            panel1 = new Panel();
            rootCommentItem = new CommentItem();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(rootCommentItem);
            panel1.Location = new Point(157, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 15, 0, 0);
            panel1.Size = new Size(950, 737);
            panel1.TabIndex = 0;
            // 
            // rootCommentItem
            // 
            rootCommentItem.AutoSize = true;
            rootCommentItem.BackColor = Color.Transparent;
            rootCommentItem.Dock = DockStyle.Top;
            rootCommentItem.Location = new Point(0, 15);
            rootCommentItem.Margin = new Padding(0);
            rootCommentItem.Name = "rootCommentItem";
            rootCommentItem.Size = new Size(950, 169);
            rootCommentItem.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(15, 10);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 32);
            btnBack.TabIndex = 9;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // PostDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Name = "PostDetailsScreen";
            Size = new Size(1263, 737);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CommentItem rootCommentItem;
        private Button btnBack;
    }
}
