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
            inpGrpUsername = new InputGroup();
            inpGrpPassword = new InputGroup();
            lblPage = new Label();
            btnSignIn = new Button();
            lnkForgotPassword = new LinkLabel();
            SuspendLayout();
            // 
            // inpGrpUsername
            // 
            inpGrpUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpUsername.BackColor = Color.Transparent;
            inpGrpUsername.InputText = "";
            inpGrpUsername.Label = "Label";
            inpGrpUsername.Location = new Point(33, 60);
            inpGrpUsername.Margin = new Padding(32, 4, 32, 4);
            inpGrpUsername.Name = "inpGrpUsername";
            inpGrpUsername.PasswordChar = '\0';
            inpGrpUsername.PlaceholderText = "";
            inpGrpUsername.Size = new Size(356, 50);
            inpGrpUsername.TabIndex = 0;
            // 
            // inpGrpPassword
            // 
            inpGrpPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpPassword.BackColor = Color.Transparent;
            inpGrpPassword.InputText = "";
            inpGrpPassword.Label = "Label";
            inpGrpPassword.Location = new Point(33, 132);
            inpGrpPassword.Margin = new Padding(32, 4, 32, 4);
            inpGrpPassword.Name = "inpGrpPassword";
            inpGrpPassword.PasswordChar = '\0';
            inpGrpPassword.PlaceholderText = "";
            inpGrpPassword.Size = new Size(356, 50);
            inpGrpPassword.TabIndex = 0;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPage.ForeColor = Color.FromArgb(178, 172, 162);
            lblPage.Location = new Point(0, 4);
            lblPage.Margin = new Padding(4, 4, 4, 4);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(420, 35);
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
            btnSignIn.Location = new Point(150, 230);
            btnSignIn.Margin = new Padding(64, 32, 64, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(121, 27);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.Anchor = AnchorStyles.Right;
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.LinkColor = Color.FromArgb(47, 255, 125);
            lnkForgotPassword.Location = new Point(251, 187);
            lnkForgotPassword.Margin = new Padding(2, 0, 2, 0);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(127, 15);
            lnkForgotPassword.TabIndex = 3;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot your password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // SignInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(lnkForgotPassword);
            Controls.Add(btnSignIn);
            Controls.Add(lblPage);
            Controls.Add(inpGrpPassword);
            Controls.Add(inpGrpUsername);
            Name = "SignInPage";
            Size = new Size(420, 276);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InputGroup inpGrpUsername;
        private InputGroup inpGrpPassword;
        private Label lblPage;
        private Button btnSignIn;
        private LinkLabel lnkForgotPassword;
    }
}
