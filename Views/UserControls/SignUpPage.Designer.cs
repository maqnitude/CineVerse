namespace CineVerse.Views.UserControls
{
    partial class SignUpPage
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
            inpGrpEmail = new InputGroup();
            inpGrpUsername = new InputGroup();
            btnSignUp = new Button();
            inpGrpPassword = new InputGroup();
            SuspendLayout();
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPage.ForeColor = Color.FromArgb(178, 172, 162);
            lblPage.Location = new Point(0, 7);
            lblPage.Margin = new Padding(6, 7, 6, 7);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(600, 49);
            lblPage.TabIndex = 2;
            lblPage.Text = "Sign Up";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inpGrpEmail
            // 
            inpGrpEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpEmail.BackColor = Color.Transparent;
            inpGrpEmail.Label = "Label";
            inpGrpEmail.Location = new Point(45, 64);
            inpGrpEmail.Margin = new Padding(46, 7, 46, 7);
            inpGrpEmail.Name = "inpGrpEmail";
            inpGrpEmail.PasswordChar = '\0';
            inpGrpEmail.PlaceholderText = "";
            inpGrpEmail.Size = new Size(509, 80);
            inpGrpEmail.TabIndex = 3;
            // 
            // inpGrpUsername
            // 
            inpGrpUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpUsername.BackColor = Color.Transparent;
            inpGrpUsername.Label = "Label";
            inpGrpUsername.Location = new Point(45, 163);
            inpGrpUsername.Margin = new Padding(46, 7, 46, 7);
            inpGrpUsername.Name = "inpGrpUsername";
            inpGrpUsername.PasswordChar = '\0';
            inpGrpUsername.PlaceholderText = "";
            inpGrpUsername.Size = new Size(509, 80);
            inpGrpUsername.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Bottom;
            btnSignUp.BackColor = Color.FromArgb(0, 157, 26);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(214, 383);
            btnSignUp.Margin = new Padding(91, 53, 91, 7);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(173, 45);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // inpGrpPassword
            // 
            inpGrpPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpPassword.BackColor = Color.Transparent;
            inpGrpPassword.Label = "Label";
            inpGrpPassword.Location = new Point(45, 262);
            inpGrpPassword.Margin = new Padding(46, 7, 0, 7);
            inpGrpPassword.Name = "inpGrpPassword";
            inpGrpPassword.PasswordChar = '\0';
            inpGrpPassword.PlaceholderText = "";
            inpGrpPassword.Size = new Size(509, 80);
            inpGrpPassword.TabIndex = 3;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(inpGrpPassword);
            Controls.Add(btnSignUp);
            Controls.Add(inpGrpUsername);
            Controls.Add(inpGrpEmail);
            Controls.Add(lblPage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignUpPage";
            Size = new Size(600, 460);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private InputGroup inpGrpEmail;
        private InputGroup inpGrpUsername;
        private Button btnSignUp;
        private InputGroup inpGrpPassword;
    }
}
