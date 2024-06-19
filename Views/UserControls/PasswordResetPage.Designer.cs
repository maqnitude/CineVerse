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
            inpGrpNewPassword = new InputGroup();
            inpGrpConfirmNewPassword = new InputGroup();
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
            lblPage.Location = new Point(1, 7);
            lblPage.Margin = new Padding(6, 7, 6, 7);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(600, 48);
            lblPage.TabIndex = 3;
            lblPage.Text = "Reset Password";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inpGrpNewPassword
            // 
            inpGrpNewPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpNewPassword.BackColor = Color.Transparent;
            inpGrpNewPassword.InputText = "";
            inpGrpNewPassword.Label = "Label";
            inpGrpNewPassword.Location = new Point(46, 128);
            inpGrpNewPassword.Margin = new Padding(46, 7, 46, 7);
            inpGrpNewPassword.Name = "inpGrpNewPassword";
            inpGrpNewPassword.PasswordChar = '\0';
            inpGrpNewPassword.PlaceholderText = "";
            inpGrpNewPassword.Size = new Size(509, 83);
            inpGrpNewPassword.TabIndex = 4;
            // 
            // inpGrpConfirmNewPassword
            // 
            inpGrpConfirmNewPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpConfirmNewPassword.BackColor = Color.Transparent;
            inpGrpConfirmNewPassword.InputText = "";
            inpGrpConfirmNewPassword.Label = "Label";
            inpGrpConfirmNewPassword.Location = new Point(46, 233);
            inpGrpConfirmNewPassword.Margin = new Padding(46, 7, 46, 7);
            inpGrpConfirmNewPassword.Name = "inpGrpConfirmNewPassword";
            inpGrpConfirmNewPassword.PasswordChar = '\0';
            inpGrpConfirmNewPassword.PlaceholderText = "";
            inpGrpConfirmNewPassword.Size = new Size(509, 83);
            inpGrpConfirmNewPassword.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom;
            btnResetPassword.BackColor = Color.FromArgb(0, 157, 26);
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(317, 368);
            btnResetPassword.Margin = new Padding(91, 53, 91, 7);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(173, 45);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.FromArgb(150, 150, 150);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(91, 368);
            btnCancel.Margin = new Padding(91, 53, 91, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 45);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(569, 47);
            label1.TabIndex = 10;
            label1.Text = "Enter a new password for your account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordResetPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnResetPassword);
            Controls.Add(inpGrpConfirmNewPassword);
            Controls.Add(inpGrpNewPassword);
            Controls.Add(lblPage);
            Name = "PasswordResetPage";
            Size = new Size(600, 460);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private InputGroup inpGrpNewPassword;
        private InputGroup inpGrpConfirmNewPassword;
        private Button btnResetPassword;
        private Button btnCancel;
        private Label label1;
    }
}
