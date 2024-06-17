namespace CineVerse.Views.UserControls
{
    partial class InputGroup
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
            txtInput = new TextBox();
            lblField = new Label();
            pnTextInput = new Panel();
            pnTextInput.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtInput.BackColor = Color.FromArgb(43, 47, 49);
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 10F);
            txtInput.ForeColor = Color.FromArgb(168, 160, 149);
            txtInput.Location = new Point(6, 11);
            txtInput.Margin = new Padding(6, 7, 6, 7);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Some text here";
            txtInput.Size = new Size(383, 27);
            txtInput.TabIndex = 0;
            // 
            // lblField
            // 
            lblField.Dock = DockStyle.Top;
            lblField.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblField.ForeColor = Color.FromArgb(232, 230, 227);
            lblField.Location = new Point(0, 0);
            lblField.Margin = new Padding(6, 7, 6, 0);
            lblField.Name = "lblField";
            lblField.Size = new Size(395, 28);
            lblField.TabIndex = 1;
            lblField.Text = "Label";
            // 
            // pnTextInput
            // 
            pnTextInput.BackColor = Color.FromArgb(43, 47, 49);
            pnTextInput.Controls.Add(txtInput);
            pnTextInput.Dock = DockStyle.Fill;
            pnTextInput.Location = new Point(0, 28);
            pnTextInput.Name = "pnTextInput";
            pnTextInput.Size = new Size(395, 56);
            pnTextInput.TabIndex = 2;
            // 
            // InputGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnTextInput);
            Controls.Add(lblField);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InputGroup";
            Size = new Size(395, 84);
            pnTextInput.ResumeLayout(false);
            pnTextInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtInput;
        private Label lblField;
        private Panel pnTextInput;
    }
}
