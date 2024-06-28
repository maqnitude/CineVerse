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
            SuspendLayout();
            // 
            // pnlResults
            // 
            pnlResults.AutoScroll = true;
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 0);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(318, 437);
            pnlResults.TabIndex = 0;
            // 
            // SearchResultsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlResults);
            Name = "SearchResultsList";
            Size = new Size(318, 437);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlResults;
    }
}
