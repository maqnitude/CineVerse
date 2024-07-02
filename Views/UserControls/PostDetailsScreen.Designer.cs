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
            panel2 = new Panel();
            btnBack = new Button();
            commentItemRoot = new CommentItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(16, 19, 22);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(commentItemRoot);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 737);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(16, 19, 22);
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 32);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 32);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // commentItemRoot
            // 
            commentItemRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            commentItemRoot.AutoSize = true;
            commentItemRoot.BackColor = Color.Transparent;
            commentItemRoot.Location = new Point(0, 32);
            commentItemRoot.Margin = new Padding(0);
            commentItemRoot.Name = "commentItemRoot";
            commentItemRoot.Size = new Size(986, 214);
            commentItemRoot.TabIndex = 0;
            // 
            // PostDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PostDetailsScreen";
            Size = new Size(986, 737);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CommentItem commentItemRoot;
        private Panel panel2;
        private Button btnBack;
    }
}
