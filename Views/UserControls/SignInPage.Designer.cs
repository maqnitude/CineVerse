namespace CineVerse.Views.UserControls
{
    partial class SignInPage
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
            inputGroup1 = new InputGroup();
            inputGroup2 = new InputGroup();
            lblPage = new Label();
            btnSignIn = new Button();
            lnkForgotPassword = new LinkLabel();
            SuspendLayout();
            // 
            // inputGroup1
            // 
            inputGroup1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup1.BackColor = Color.Transparent;
            inputGroup1.Label = "Label";
            inputGroup1.Location = new Point(47, 100);
            inputGroup1.Margin = new Padding(46, 7, 46, 7);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.PasswordChar = '\0';
            inputGroup1.PlaceholderText = "";
            inputGroup1.Size = new Size(508, 84);
            inputGroup1.TabIndex = 0;
            // 
            // inputGroup2
            // 
            inputGroup2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup2.BackColor = Color.Transparent;
            inputGroup2.Label = "Label";
            inputGroup2.Location = new Point(47, 220);
            inputGroup2.Margin = new Padding(46, 7, 46, 7);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.PasswordChar = '\0';
            inputGroup2.PlaceholderText = "";
            inputGroup2.Size = new Size(508, 84);
            inputGroup2.TabIndex = 0;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPage.ForeColor = Color.FromArgb(178, 172, 162);
            lblPage.Location = new Point(0, 6);
            lblPage.Margin = new Padding(6, 7, 6, 7);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(600, 59);
            lblPage.TabIndex = 1;
            lblPage.Text = "Sign In to CineVerse";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Bottom;
            btnSignIn.BackColor = Color.FromArgb(0, 157, 26);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(214, 383);
            btnSignIn.Margin = new Padding(91, 53, 91, 7);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(173, 45);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.Anchor = AnchorStyles.Right;
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.LinkColor = Color.FromArgb(47, 255, 125);
            lnkForgotPassword.Location = new Point(358, 311);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(197, 25);
            lnkForgotPassword.TabIndex = 3;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot your password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // SignInPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(lnkForgotPassword);
            Controls.Add(btnSignIn);
            Controls.Add(lblPage);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignInPage";
            Size = new Size(600, 460);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InputGroup inputGroup1;
        private InputGroup inputGroup2;
        private Label lblPage;
        private Button btnSignIn;
        private LinkLabel lnkForgotPassword;
    }
}
