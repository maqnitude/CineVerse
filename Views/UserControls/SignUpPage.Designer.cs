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
            inputGroup1 = new InputGroup();
            inputGroup2 = new InputGroup();
            btnSignUp = new Button();
            inputGroup3 = new InputGroup();
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
            // inputGroup1
            // 
            inputGroup1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup1.BackColor = Color.Transparent;
            inputGroup1.Label = "Label";
            inputGroup1.Location = new Point(45, 64);
            inputGroup1.Margin = new Padding(46, 7, 46, 7);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.PlaceholderText = "";
            inputGroup1.Size = new Size(509, 80);
            inputGroup1.TabIndex = 3;
            // 
            // inputGroup2
            // 
            inputGroup2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup2.BackColor = Color.Transparent;
            inputGroup2.Label = "Label";
            inputGroup2.Location = new Point(45, 160);
            inputGroup2.Margin = new Padding(46, 7, 46, 7);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.PlaceholderText = "";
            inputGroup2.Size = new Size(509, 80);
            inputGroup2.TabIndex = 3;
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
            // 
            // inputGroup3
            // 
            inputGroup3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputGroup3.BackColor = Color.Transparent;
            inputGroup3.Label = "Label";
            inputGroup3.Location = new Point(45, 262);
            inputGroup3.Margin = new Padding(46, 7, 0, 7);
            inputGroup3.Name = "inputGroup3";
            inputGroup3.PlaceholderText = "";
            inputGroup3.Size = new Size(509, 80);
            inputGroup3.TabIndex = 3;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(inputGroup3);
            Controls.Add(btnSignUp);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Controls.Add(lblPage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignUpPage";
            Size = new Size(600, 460);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private InputGroup inputGroup1;
        private InputGroup inputGroup2;
        private Button btnSignUp;
        private InputGroup inputGroup3;
    }
}
