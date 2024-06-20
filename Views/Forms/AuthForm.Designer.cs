namespace CineVerse.Forms
{
    partial class AuthForm
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
            pnTabContainer = new Panel();
            btnSignUp = new Button();
            btnSignIn = new Button();
            pnPageContainer = new Panel();
            pnTabContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnTabContainer
            // 
            pnTabContainer.BackColor = Color.Black;
            pnTabContainer.Controls.Add(btnSignUp);
            pnTabContainer.Controls.Add(btnSignIn);
            pnTabContainer.Dock = DockStyle.Top;
            pnTabContainer.Location = new Point(0, 0);
            pnTabContainer.Margin = new Padding(2, 2, 2, 2);
            pnTabContainer.Name = "pnTabContainer";
            pnTabContainer.Size = new Size(510, 32);
            pnTabContainer.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(150, 150, 150);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(88, 3);
            btnSignUp.Margin = new Padding(2, 2, 2, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(78, 25);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(0, 157, 26);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(5, 3);
            btnSignIn.Margin = new Padding(2, 2, 2, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(78, 25);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pnPageContainer
            // 
            pnPageContainer.Dock = DockStyle.Fill;
            pnPageContainer.Location = new Point(0, 32);
            pnPageContainer.Margin = new Padding(2, 2, 2, 2);
            pnPageContainer.Name = "pnPageContainer";
            pnPageContainer.Size = new Size(510, 264);
            pnPageContainer.TabIndex = 1;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            ClientSize = new Size(510, 296);
            Controls.Add(pnPageContainer);
            Controls.Add(pnTabContainer);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AuthForm";
            Text = "AuthenticationForm";
            pnTabContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTabContainer;
        private Button btnSignIn;
        private Panel pnPageContainer;
        private Button btnSignUp;
    }
}