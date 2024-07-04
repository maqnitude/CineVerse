namespace CineVerse.Views.UserControls
{
    partial class PostsScreen
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
            pnlPostsContainer = new Panel();
            btnNewPost = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPostsContainer
            // 
            pnlPostsContainer.AutoScroll = true;
            pnlPostsContainer.Dock = DockStyle.Fill;
            pnlPostsContainer.Location = new Point(0, 40);
            pnlPostsContainer.Name = "pnlPostsContainer";
            pnlPostsContainer.Size = new Size(950, 736);
            pnlPostsContainer.TabIndex = 1;
            // 
            // btnNewPost
            // 
            btnNewPost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewPost.BackColor = Color.FromArgb(68, 82, 95);
            btnNewPost.FlatStyle = FlatStyle.Flat;
            btnNewPost.ForeColor = Color.FromArgb(184, 211, 235);
            btnNewPost.Location = new Point(837, 9);
            btnNewPost.Name = "btnNewPost";
            btnNewPost.Size = new Size(110, 23);
            btnNewPost.TabIndex = 2;
            btnNewPost.Text = "Add new post";
            btnNewPost.UseVisualStyleBackColor = false;
            btnNewPost.Click += btnNewPost_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(pnlPostsContainer);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(134, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 776);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnNewPost);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 40);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(232, 230, 227);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 3;
            label1.Text = "Let's discuss about movies";
            // 
            // PostsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(panel1);
            Name = "PostsScreen";
            Size = new Size(1218, 777);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPostsContainer;
        private Button btnNewPost;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
