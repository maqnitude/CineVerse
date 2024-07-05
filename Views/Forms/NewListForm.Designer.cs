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
            lblTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitle.Location = new Point(13, 7);
            lblTitle.Margin = new Padding(4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New List";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(232, 230, 227);
            lblName.Location = new Point(13, 55);
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
            txtName.BackColor = Color.FromArgb(35, 42, 51);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(168, 160, 149);
            txtName.Location = new Point(13, 81);
            txtName.Margin = new Padding(4, 4, 32, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 22);
            txtName.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(35, 42, 51);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.FromArgb(168, 160, 149);
            textBox2.Location = new Point(13, 145);
            textBox2.Margin = new Padding(4, 4, 32, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 22);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(232, 230, 227);
            label3.Location = new Point(13, 119);
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
            comboListType.BackColor = Color.FromArgb(35, 42, 51);
            comboListType.FlatStyle = FlatStyle.Flat;
            comboListType.Font = new Font("Segoe UI", 12F);
            comboListType.ForeColor = Color.FromArgb(168, 160, 149);
            comboListType.FormattingEnabled = true;
            comboListType.Location = new Point(13, 211);
            comboListType.Margin = new Padding(4, 4, 32, 4);
            comboListType.Name = "comboListType";
            comboListType.Size = new Size(365, 29);
            comboListType.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(232, 230, 227);
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
            checkBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            checkBox1.ForeColor = Color.FromArgb(232, 230, 227);
            checkBox1.Location = new Point(13, 252);
            checkBox1.Margin = new Padding(4, 8, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Ranked list";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.BackColor = Color.FromArgb(35, 42, 51);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.FromArgb(168, 160, 149);
            txtDescription.Location = new Point(400, 81);
            txtDescription.Margin = new Padding(32, 4, 4, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(372, 196);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(232, 230, 227);
            label5.Location = new Point(400, 52);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(100, 27);
            label5.TabIndex = 2;
            label5.Text = "Description";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 138, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(216, 244, 202);
            btnSave.Location = new Point(688, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(82, 95, 109);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(184, 201, 215);
            btnCancel.Location = new Point(598, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // NewListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
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
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewListForm";
            Text = "NewListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
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