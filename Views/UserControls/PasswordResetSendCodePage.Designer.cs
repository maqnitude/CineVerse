namespace CineVerse.Views.UserControls
{
    partial class PasswordResetSendCodePage
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
            btnSendRequest = new Button();
            inpGrpEmail = new InputGroup();
            label1 = new Label();
            btnCancel = new Button();
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
            lblPage.Size = new Size(600, 49);
            lblPage.TabIndex = 3;
            lblPage.Text = "Reset Password";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Anchor = AnchorStyles.Bottom;
            btnSendRequest.BackColor = Color.FromArgb(0, 157, 26);
            btnSendRequest.FlatAppearance.BorderSize = 0;
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendRequest.ForeColor = Color.White;
            btnSendRequest.Location = new Point(336, 368);
            btnSendRequest.Margin = new Padding(91, 53, 91, 7);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(173, 45);
            btnSendRequest.TabIndex = 10;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = false;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // inpGrpEmail
            // 
            inpGrpEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpEmail.BackColor = Color.Transparent;
            inpGrpEmail.InputText = "";
            inpGrpEmail.Label = "Label";
            inpGrpEmail.Location = new Point(49, 184);
            inpGrpEmail.Margin = new Padding(46, 7, 46, 7);
            inpGrpEmail.Name = "inpGrpEmail";
            inpGrpEmail.PasswordChar = '\0';
            inpGrpEmail.PlaceholderText = "";
            inpGrpEmail.Size = new Size(509, 80);
            inpGrpEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 48);
            label1.Name = "label1";
            label1.Size = new Size(568, 93);
            label1.TabIndex = 8;
            label1.Text = "Enter your email below, and we’ll send you a message with your username and a verification code to reset your password.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PasswordResetSendCodePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(btnCancel);
            Controls.Add(btnSendRequest);
            Controls.Add(inpGrpEmail);
            Controls.Add(label1);
            Controls.Add(lblPage);
            Name = "PasswordResetSendCodePage";
            Size = new Size(600, 460);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private Button btnSendRequest;
        private InputGroup inpGrpEmail;
        private Label label1;
        private Button btnCancel;
    }
}
