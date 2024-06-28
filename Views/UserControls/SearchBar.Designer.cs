namespace CineVerse.Views.UserControls
{
    partial class SearchBar
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
            pictureBox1 = new PictureBox();
            txtSearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchBox.BackColor = Color.FromArgb(35, 42, 51);
            txtSearchBox.BorderStyle = BorderStyle.None;
            txtSearchBox.Font = new Font("Segoe UI", 10F);
            txtSearchBox.ForeColor = Color.FromArgb(168, 160, 149);
            txtSearchBox.Location = new Point(34, 4);
            txtSearchBox.Margin = new Padding(2);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(240, 18);
            txtSearchBox.TabIndex = 1;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // SearchBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 42, 51);
            Controls.Add(txtSearchBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "SearchBar";
            Size = new Size(279, 26);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtSearchBox;
    }
}
