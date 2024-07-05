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
            lblTitleHeading = new Label();
            pnTextBox = new Panel();
            txtTitle = new TextBox();
            lblContentHeading = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            pnContentSection = new Panel();
            pnlContent = new Panel();
            txtContent = new RichTextBox();
            pnlToobar = new Panel();
            btnFormattingHelp = new Button();
            btnPreview = new Button();
            btnQuote = new Button();
            btnCode = new Button();
            btnOrderedList = new Button();
            btnUnorderedList = new Button();
            btnLink = new Button();
            btnItalic = new Button();
            btnBold = new Button();
            pnTitleSection = new Panel();
            lblFormTitle = new Label();
            pnTextBox.SuspendLayout();
            pnContentSection.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlToobar.SuspendLayout();
            pnTitleSection.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleHeading
            // 
            lblTitleHeading.AutoSize = true;
            lblTitleHeading.Dock = DockStyle.Top;
            lblTitleHeading.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lblTitleHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitleHeading.Location = new Point(0, 0);
            lblTitleHeading.Margin = new Padding(4);
            lblTitleHeading.Name = "lblTitleHeading";
            lblTitleHeading.Size = new Size(42, 23);
            lblTitleHeading.TabIndex = 0;
            lblTitleHeading.Text = "Title";
            // 
            // pnTextBox
            // 
            pnTextBox.BackColor = Color.FromArgb(35, 42, 51);
            pnTextBox.Controls.Add(txtTitle);
            pnTextBox.Dock = DockStyle.Bottom;
            pnTextBox.Location = new Point(0, 24);
            pnTextBox.Margin = new Padding(4);
            pnTextBox.Name = "pnTextBox";
            pnTextBox.Size = new Size(812, 42);
            pnTextBox.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.BackColor = Color.FromArgb(35, 42, 51);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(168, 160, 149);
            txtTitle.Location = new Point(4, 10);
            txtTitle.Margin = new Padding(4, 10, 4, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(804, 22);
            txtTitle.TabIndex = 0;
            // 
            // lblContentHeading
            // 
            lblContentHeading.AutoSize = true;
            lblContentHeading.Dock = DockStyle.Top;
            lblContentHeading.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lblContentHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblContentHeading.Location = new Point(0, 0);
            lblContentHeading.Margin = new Padding(4);
            lblContentHeading.Name = "lblContentHeading";
            lblContentHeading.Size = new Size(72, 23);
            lblContentHeading.TabIndex = 0;
            lblContentHeading.Text = "Content";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.FromArgb(0, 138, 22);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(216, 244, 202);
            btnSubmit.Location = new Point(759, 408);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(84, 30);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(82, 95, 109);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(184, 201, 215);
            btnCancel.Location = new Point(669, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnContentSection
            // 
            pnContentSection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnContentSection.Controls.Add(pnlContent);
            pnContentSection.Controls.Add(pnlToobar);
            pnContentSection.Controls.Add(lblContentHeading);
            pnContentSection.Location = new Point(31, 140);
            pnContentSection.Margin = new Padding(4);
            pnContentSection.Name = "pnContentSection";
            pnContentSection.Size = new Size(812, 251);
            pnContentSection.TabIndex = 4;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(txtContent);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 59);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(812, 192);
            pnlContent.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.FromArgb(35, 42, 51);
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Dock = DockStyle.Fill;
            txtContent.Font = new Font("Segoe UI", 10F);
            txtContent.ForeColor = Color.FromArgb(168, 160, 149);
            txtContent.Location = new Point(0, 0);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(812, 192);
            txtContent.TabIndex = 1;
            txtContent.Text = "";
            // 
            // pnlToobar
            // 
            pnlToobar.BorderStyle = BorderStyle.FixedSingle;
            pnlToobar.Controls.Add(btnFormattingHelp);
            pnlToobar.Controls.Add(btnPreview);
            pnlToobar.Controls.Add(btnQuote);
            pnlToobar.Controls.Add(btnCode);
            pnlToobar.Controls.Add(btnOrderedList);
            pnlToobar.Controls.Add(btnUnorderedList);
            pnlToobar.Controls.Add(btnLink);
            pnlToobar.Controls.Add(btnItalic);
            pnlToobar.Controls.Add(btnBold);
            pnlToobar.Dock = DockStyle.Top;
            pnlToobar.ForeColor = Color.FromArgb(232, 230, 227);
            pnlToobar.Location = new Point(0, 23);
            pnlToobar.Name = "pnlToobar";
            pnlToobar.Padding = new Padding(2);
            pnlToobar.Size = new Size(812, 36);
            pnlToobar.TabIndex = 1;
            // 
            // btnFormattingHelp
            // 
            btnFormattingHelp.Dock = DockStyle.Left;
            btnFormattingHelp.FlatStyle = FlatStyle.Flat;
            btnFormattingHelp.Font = new Font("Segoe UI", 9F);
            btnFormattingHelp.ForeColor = Color.FromArgb(232, 230, 227);
            btnFormattingHelp.Image = Properties.Resources.question;
            btnFormattingHelp.Location = new Point(366, 2);
            btnFormattingHelp.Margin = new Padding(4);
            btnFormattingHelp.Name = "btnFormattingHelp";
            btnFormattingHelp.Size = new Size(40, 30);
            btnFormattingHelp.TabIndex = 0;
            btnFormattingHelp.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.Dock = DockStyle.Left;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9F);
            btnPreview.ForeColor = Color.FromArgb(232, 230, 227);
            btnPreview.Image = Properties.Resources.tmdb_eye;
            btnPreview.Location = new Point(282, 2);
            btnPreview.Margin = new Padding(4);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(84, 30);
            btnPreview.TabIndex = 0;
            btnPreview.Text = "Preview";
            btnPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnQuote
            // 
            btnQuote.Dock = DockStyle.Left;
            btnQuote.FlatStyle = FlatStyle.Flat;
            btnQuote.Font = new Font("Segoe UI", 9F);
            btnQuote.ForeColor = Color.FromArgb(232, 230, 227);
            btnQuote.Image = Properties.Resources.message;
            btnQuote.Location = new Point(242, 2);
            btnQuote.Margin = new Padding(0, 4, 4, 4);
            btnQuote.Name = "btnQuote";
            btnQuote.Size = new Size(40, 30);
            btnQuote.TabIndex = 0;
            btnQuote.UseVisualStyleBackColor = true;
            // 
            // btnCode
            // 
            btnCode.Dock = DockStyle.Left;
            btnCode.FlatStyle = FlatStyle.Flat;
            btnCode.Font = new Font("Segoe UI", 9F);
            btnCode.ForeColor = Color.FromArgb(232, 230, 227);
            btnCode.Image = Properties.Resources.code;
            btnCode.Location = new Point(202, 2);
            btnCode.Margin = new Padding(0, 4, 0, 4);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(40, 30);
            btnCode.TabIndex = 0;
            btnCode.UseVisualStyleBackColor = true;
            // 
            // btnOrderedList
            // 
            btnOrderedList.Dock = DockStyle.Left;
            btnOrderedList.FlatStyle = FlatStyle.Flat;
            btnOrderedList.Font = new Font("Segoe UI", 9F);
            btnOrderedList.ForeColor = Color.FromArgb(232, 230, 227);
            btnOrderedList.Image = Properties.Resources.list_numbers;
            btnOrderedList.Location = new Point(162, 2);
            btnOrderedList.Margin = new Padding(0, 4, 0, 4);
            btnOrderedList.Name = "btnOrderedList";
            btnOrderedList.Size = new Size(40, 30);
            btnOrderedList.TabIndex = 0;
            btnOrderedList.UseVisualStyleBackColor = true;
            // 
            // btnUnorderedList
            // 
            btnUnorderedList.Dock = DockStyle.Left;
            btnUnorderedList.FlatStyle = FlatStyle.Flat;
            btnUnorderedList.Font = new Font("Segoe UI", 9F);
            btnUnorderedList.ForeColor = Color.FromArgb(232, 230, 227);
            btnUnorderedList.Image = Properties.Resources.list;
            btnUnorderedList.Location = new Point(122, 2);
            btnUnorderedList.Margin = new Padding(4, 4, 0, 4);
            btnUnorderedList.Name = "btnUnorderedList";
            btnUnorderedList.Size = new Size(40, 30);
            btnUnorderedList.TabIndex = 0;
            btnUnorderedList.UseVisualStyleBackColor = true;
            // 
            // btnLink
            // 
            btnLink.Dock = DockStyle.Left;
            btnLink.FlatStyle = FlatStyle.Flat;
            btnLink.Font = new Font("Segoe UI", 9F);
            btnLink.ForeColor = Color.FromArgb(232, 230, 227);
            btnLink.Image = Properties.Resources.link;
            btnLink.Location = new Point(82, 2);
            btnLink.Margin = new Padding(4);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(40, 30);
            btnLink.TabIndex = 0;
            btnLink.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            btnItalic.Dock = DockStyle.Left;
            btnItalic.FlatStyle = FlatStyle.Flat;
            btnItalic.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.ForeColor = Color.FromArgb(232, 230, 227);
            btnItalic.Location = new Point(42, 2);
            btnItalic.Margin = new Padding(0, 4, 4, 4);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(40, 30);
            btnItalic.TabIndex = 0;
            btnItalic.Text = "I";
            btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnBold
            // 
            btnBold.Dock = DockStyle.Left;
            btnBold.FlatStyle = FlatStyle.Flat;
            btnBold.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.ForeColor = Color.FromArgb(232, 230, 227);
            btnBold.Location = new Point(2, 2);
            btnBold.Margin = new Padding(4, 4, 0, 4);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(40, 30);
            btnBold.TabIndex = 0;
            btnBold.Text = "B";
            btnBold.UseVisualStyleBackColor = true;
            // 
            // pnTitleSection
            // 
            pnTitleSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnTitleSection.Controls.Add(lblTitleHeading);
            pnTitleSection.Controls.Add(pnTextBox);
            pnTitleSection.Location = new Point(31, 57);
            pnTitleSection.Name = "pnTitleSection";
            pnTitleSection.Size = new Size(812, 66);
            pnTitleSection.TabIndex = 5;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Top;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(866, 35);
            lblFormTitle.TabIndex = 6;
            lblFormTitle.Text = "New Post";
            // 
            // NewPostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 54, 68);
            ClientSize = new Size(866, 450);
            Controls.Add(lblFormTitle);
            Controls.Add(pnTitleSection);
            Controls.Add(pnContentSection);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewPostForm";
            Text = "NewPostForm";
            pnTextBox.ResumeLayout(false);
            pnTextBox.PerformLayout();
            pnContentSection.ResumeLayout(false);
            pnContentSection.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlToobar.ResumeLayout(false);
            pnTitleSection.ResumeLayout(false);
            pnTitleSection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleHeading;
        private Panel pnTextBox;
        private TextBox txtTitle;
        private Label lblContentHeading;
        private Button btnSubmit;
        private Button btnCancel;
        private Panel pnContentSection;
        private Panel pnlToobar;
        private Button btnQuote;
        private Button btnCode;
        private Button btnOrderedList;
        private Button btnUnorderedList;
        private Button btnPreview;
        private Button btnFormattingHelp;
        private Button btnLink;
        private Button btnItalic;
        private Button btnBold;
        private Panel pnlContent;
        private RichTextBox txtContent;
        private Panel pnTitleSection;
        private Label lblFormTitle;
    }
}