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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputGroup1
            // 
            inputGroup1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup1.Location = new Point(32, 76);
            inputGroup1.Margin = new Padding(32, 4, 32, 4);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.Size = new Size(474, 69);
            inputGroup1.TabIndex = 0;
            // 
            // inputGroup2
            // 
            inputGroup2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup2.Location = new Point(32, 153);
            inputGroup2.Margin = new Padding(32, 4, 32, 4);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.Size = new Size(474, 69);
            inputGroup2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 4);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(502, 64);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 157, 26);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 258);
            button1.Margin = new Padding(64, 32, 64, 4);
            button1.Name = "button1";
            button1.Size = new Size(410, 34);
            button1.TabIndex = 2;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // SignInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Name = "SignInPage";
            Size = new Size(538, 380);
            ResumeLayout(false);
        }

        #endregion

        private InputGroup inputGroup1;
        private InputGroup inputGroup2;
        private Label label1;
        private Button button1;
    }
}
