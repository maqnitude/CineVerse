namespace CineVerse.Views.Forms
{
    partial class NewListForm
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
            lblTitle = new Label();
            btnClose = new Button();
            lblName = new Label();
            txtName = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            comboListType = new ComboBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            txtDescription = new RichTextBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 13);
            lblTitle.Margin = new Padding(4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New List";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(697, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(13, 53);
            lblName.Margin = new Padding(4, 4, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 24);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(13, 81);
            txtName.Margin = new Padding(4, 4, 32, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(355, 29);
            txtName.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(13, 146);
            textBox2.Margin = new Padding(4, 4, 32, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 29);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 118);
            label3.Margin = new Padding(4, 4, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 4;
            label3.Text = "Tags";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboListType
            // 
            comboListType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboListType.Font = new Font("Segoe UI", 12F);
            comboListType.FormattingEnabled = true;
            comboListType.Location = new Point(13, 211);
            comboListType.Margin = new Padding(4, 4, 32, 4);
            comboListType.Name = "comboListType";
            comboListType.Size = new Size(355, 29);
            comboListType.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 183);
            label4.Margin = new Padding(4, 4, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 24);
            label4.TabIndex = 4;
            label4.Text = "Who can view?";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(13, 252);
            checkBox1.Margin = new Padding(4, 8, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Ranked list";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(432, 81);
            txtDescription.Margin = new Padding(32, 4, 4, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(340, 196);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(432, 53);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 2;
            label5.Text = "Description";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(697, 326);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(616, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 40, 47);
            ClientSize = new Size(784, 361);
            Controls.Add(txtDescription);
            Controls.Add(checkBox1);
            Controls.Add(comboListType);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewListForm";
            Text = "NewListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnClose;
        private Label lblName;
        private TextBox txtName;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboListType;
        private Label label4;
        private CheckBox checkBox1;
        private RichTextBox txtDescription;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
    }
}