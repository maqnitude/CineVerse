namespace CineVerse.Views.UserControls
{
    partial class SearchResultsList
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
            pnlResults = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlResults
            // 
            pnlResults.AutoScroll = true;
            pnlResults.AutoSize = true;
            pnlResults.BackColor = Color.FromArgb(82, 95, 109);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 0);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(250, 0);
            pnlResults.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 68, 82);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 32);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(173, 196, 214);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "Search ended? Film may be unavailable.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchResultsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(pnlResults);
            Controls.Add(panel1);
            MaximumSize = new Size(0, 200);
            Name = "SearchResultsList";
            Size = new Size(250, 32);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlResults;
        private Panel panel1;
        private Label label1;
    }
}
