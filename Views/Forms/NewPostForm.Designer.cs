namespace CineVerse.Views.Forms
{
    partial class NewPostForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            txtTitle = new TextBox();
            label2 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            pnlToobar = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button3 = new Button();
            btnItalic = new Button();
            btnBold = new Button();
            pnlContent = new Panel();
            txtContent = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlToobar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 13);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtTitle);
            panel1.Location = new Point(13, 42);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 48);
            panel1.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(4, 10);
            txtTitle.Margin = new Padding(4, 10, 4, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(993, 29);
            txtTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 98);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 0;
            label2.Text = "Content";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.AutoSize = true;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.Location = new Point(940, 385);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 31);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(859, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pnlContent);
            panel2.Controls.Add(pnlToobar);
            panel2.Location = new Point(13, 127);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 251);
            panel2.TabIndex = 4;
            // 
            // pnlToobar
            // 
            pnlToobar.Controls.Add(button7);
            pnlToobar.Controls.Add(button6);
            pnlToobar.Controls.Add(button5);
            pnlToobar.Controls.Add(button4);
            pnlToobar.Controls.Add(button8);
            pnlToobar.Controls.Add(button9);
            pnlToobar.Controls.Add(button3);
            pnlToobar.Controls.Add(btnItalic);
            pnlToobar.Controls.Add(btnBold);
            pnlToobar.Dock = DockStyle.Top;
            pnlToobar.Location = new Point(0, 0);
            pnlToobar.Name = "pnlToobar";
            pnlToobar.Size = new Size(1001, 48);
            pnlToobar.TabIndex = 1;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F);
            button7.Location = new Point(260, 4);
            button7.Margin = new Padding(0, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 0;
            button7.Text = "quote";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F);
            button6.Location = new Point(220, 4);
            button6.Margin = new Padding(0, 4, 0, 4);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 0;
            button6.Text = "Code";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(180, 4);
            button5.Margin = new Padding(0, 4, 0, 4);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 0;
            button5.Text = "Bullet";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(140, 4);
            button4.Margin = new Padding(4, 4, 0, 4);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 0;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F);
            button8.Location = new Point(308, 4);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(80, 40);
            button8.TabIndex = 0;
            button8.Text = "preview";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F);
            button9.Location = new Point(396, 4);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 0;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(92, 4);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 0;
            button3.Text = "Link";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            btnItalic.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnItalic.Location = new Point(44, 4);
            btnItalic.Margin = new Padding(0, 4, 4, 4);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(40, 40);
            btnItalic.TabIndex = 0;
            btnItalic.Text = "I";
            btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnBold
            // 
            btnBold.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBold.Location = new Point(4, 4);
            btnBold.Margin = new Padding(4, 4, 0, 4);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(40, 40);
            btnBold.TabIndex = 0;
            btnBold.Text = "B";
            btnBold.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(txtContent);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 48);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1001, 203);
            pnlContent.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Dock = DockStyle.Fill;
            txtContent.Font = new Font("Segoe UI", 12F);
            txtContent.Location = new Point(0, 0);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(1001, 203);
            txtContent.TabIndex = 1;
            txtContent.Text = "";
            // 
            // NewPostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 428);
            Controls.Add(panel2);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewPostForm";
            Text = "NewPostForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlToobar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtTitle;
        private Label label2;
        private Button btnSubmit;
        private Button btnCancel;
        private Panel panel2;
        private Panel pnlToobar;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button3;
        private Button btnItalic;
        private Button btnBold;
        private Panel pnlContent;
        private RichTextBox txtContent;
    }
}