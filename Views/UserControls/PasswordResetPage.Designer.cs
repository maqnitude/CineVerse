namespace CineVerse.Views.UserControls
{
    partial class PasswordResetPage
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
            lblPage = new Label();
            inputGroup1 = new InputGroup();
            inputGroup2 = new InputGroup();
            btnResetPassword = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPage.ForeColor = Color.FromArgb(178, 172, 162);
            lblPage.Location = new Point(1, 4);
            lblPage.Margin = new Padding(4, 4, 4, 4);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(420, 29);
            lblPage.TabIndex = 3;
            lblPage.Text = "Reset Password";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputGroup1
            // 
            inputGroup1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup1.BackColor = Color.Transparent;
            inputGroup1.Label = "Label";
            inputGroup1.Location = new Point(32, 77);
            inputGroup1.Margin = new Padding(32, 4, 32, 4);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.PasswordChar = '\0';
            inputGroup1.PlaceholderText = "";
            inputGroup1.Size = new Size(356, 50);
            inputGroup1.TabIndex = 4;
            // 
            // inputGroup2
            // 
            inputGroup2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup2.BackColor = Color.Transparent;
            inputGroup2.Label = "Label";
            inputGroup2.Location = new Point(32, 140);
            inputGroup2.Margin = new Padding(32, 4, 32, 4);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.PasswordChar = '\0';
            inputGroup2.PlaceholderText = "";
            inputGroup2.Size = new Size(356, 50);
            inputGroup2.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom;
            btnResetPassword.BackColor = Color.FromArgb(0, 157, 26);
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(222, 221);
            btnResetPassword.Margin = new Padding(64, 32, 64, 4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(121, 27);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.FromArgb(150, 150, 150);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(64, 221);
            btnCancel.Margin = new Padding(64, 32, 64, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 27);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(398, 28);
            label1.TabIndex = 10;
            label1.Text = "Enter a new password for your account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordResetPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnResetPassword);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Controls.Add(lblPage);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PasswordResetPage";
            Size = new Size(420, 276);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private InputGroup inputGroup1;
        private InputGroup inputGroup2;
        private Button btnResetPassword;
        private Button btnCancel;
        private Label label1;
    }
}
