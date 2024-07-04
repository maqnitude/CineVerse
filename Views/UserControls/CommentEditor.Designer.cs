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
            btnSubmit = new Button();
            pnFooter = new Panel();
            pnContent = new Panel();
            txtContent = new TextBox();
            pnFooter.SuspendLayout();
            pnContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(30, 38, 46);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(507, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(59, 78, 88);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(588, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnFooter
            // 
            pnFooter.BackColor = Color.FromArgb(24, 28, 31);
            pnFooter.BorderStyle = BorderStyle.FixedSingle;
            pnFooter.Controls.Add(btnSubmit);
            pnFooter.Controls.Add(btnCancel);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 69);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(670, 34);
            pnFooter.TabIndex = 2;
            // 
            // pnContent
            // 
            pnContent.BackColor = Color.FromArgb(24, 28, 31);
            pnContent.BorderStyle = BorderStyle.FixedSingle;
            pnContent.Controls.Add(txtContent);
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(0, 0);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(670, 69);
            pnContent.TabIndex = 3;
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContent.BackColor = Color.FromArgb(24, 28, 31);
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Segoe UI", 10F);
            txtContent.ForeColor = Color.White;
            txtContent.Location = new Point(15, 11);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PlaceholderText = "Add a comment here";
            txtContent.Size = new Size(639, 44);
            txtContent.TabIndex = 0;
            // 
            // CommentEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnContent);
            Controls.Add(pnFooter);
            Name = "CommentEditor";
            Size = new Size(670, 103);
            pnFooter.ResumeLayout(false);
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSubmit;
        private Panel pnFooter;
        private Panel pnContent;
        private TextBox txtContent;
    }
}
