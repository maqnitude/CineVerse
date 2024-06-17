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
            label1 = new Label();
            inputGroup1 = new InputGroup();
            inputGroup2 = new InputGroup();
            inputGroup4 = new InputGroup();
            button1 = new Button();
            inputGroup3 = new InputGroup();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 4);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(668, 64);
            label1.TabIndex = 2;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputGroup1
            // 
            inputGroup1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup1.Location = new Point(32, 76);
            inputGroup1.Margin = new Padding(32, 4, 32, 4);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.Size = new Size(604, 69);
            inputGroup1.TabIndex = 3;
            // 
            // inputGroup2
            // 
            inputGroup2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup2.Location = new Point(32, 153);
            inputGroup2.Margin = new Padding(32, 4, 32, 4);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.Size = new Size(604, 69);
            inputGroup2.TabIndex = 3;
            // 
            // inputGroup4
            // 
            inputGroup4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup4.Location = new Point(334, 230);
            inputGroup4.Margin = new Padding(0, 4, 32, 4);
            inputGroup4.Name = "inputGroup4";
            inputGroup4.Size = new Size(302, 69);
            inputGroup4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 157, 26);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 335);
            button1.Margin = new Padding(64, 32, 64, 4);
            button1.Name = "button1";
            button1.Size = new Size(540, 34);
            button1.TabIndex = 4;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // inputGroup3
            // 
            inputGroup3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputGroup3.Location = new Point(32, 230);
            inputGroup3.Margin = new Padding(32, 4, 0, 4);
            inputGroup3.Name = "inputGroup3";
            inputGroup3.Size = new Size(302, 69);
            inputGroup3.TabIndex = 3;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            Controls.Add(inputGroup3);
            Controls.Add(inputGroup4);
            Controls.Add(button1);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Controls.Add(label1);
            Name = "SignUpPage";
            Size = new Size(668, 448);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private InputGroup inputGroup1;
        private InputGroup inputGroup2;
        private InputGroup inputGroup4;
        private Button button1;
        private InputGroup inputGroup3;
    }
}
