namespace CineVerse.Views.UserControls
{
    partial class PasswordResetConfirmCodePage
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
            inpGrpCode = new InputGroup();
            btnConfirm = new Button();
            label1 = new Label();
            btnCancel = new Button();
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
            lblPage.TabIndex = 4;
            lblPage.Text = "Reset Password";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inpGrpCode
            // 
            inpGrpCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpGrpCode.BackColor = Color.Transparent;
            inpGrpCode.InputText = "";
            inpGrpCode.Label = "Label";
            inpGrpCode.Location = new Point(45, 192);
            inpGrpCode.Margin = new Padding(46, 7, 46, 7);
            inpGrpCode.Name = "inpGrpCode";
            inpGrpCode.PasswordChar = '\0';
            inpGrpCode.PlaceholderText = "";
            inpGrpCode.Size = new Size(509, 80);
            inpGrpCode.TabIndex = 6;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom;
            btnConfirm.BackColor = Color.FromArgb(0, 157, 26);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(325, 382);
            btnConfirm.Margin = new Padding(91, 53, 91, 7);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(173, 45);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(568, 46);
            label1.TabIndex = 9;
            label1.Text = "Enter verification code to continue";
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
            btnCancel.Location = new Point(100, 383);
            btnCancel.Margin = new Padding(91, 53, 91, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 45);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // PasswordResetConfirmCodePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(inpGrpCode);
            Controls.Add(lblPage);
            Name = "PasswordResetConfirmCodePage";
            Size = new Size(600, 460);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPage;
        private InputGroup inpGrpCode;
        private Button btnConfirm;
        private Label label1;
        private Button btnCancel;
    }
}
