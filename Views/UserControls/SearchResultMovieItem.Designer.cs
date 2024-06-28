namespace CineVerse.Views.UserControls
{
    partial class SearchResultMovieItem
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
            lblTitle = new Label();
            lblReleaseYear = new Label();
            lblDirectors = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(4, 4);
            lblTitle.Margin = new Padding(4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Movie Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Font = new Font("Segoe UI", 10F);
            lblReleaseYear.Location = new Point(405, 4);
            lblReleaseYear.Margin = new Padding(4);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(41, 19);
            lblReleaseYear.TabIndex = 0;
            lblReleaseYear.Text = "2024";
            lblReleaseYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDirectors
            // 
            lblDirectors.AutoSize = true;
            lblDirectors.Font = new Font("Segoe UI", 8F);
            lblDirectors.Location = new Point(4, 31);
            lblDirectors.Margin = new Padding(4);
            lblDirectors.Name = "lblDirectors";
            lblDirectors.Size = new Size(53, 13);
            lblDirectors.TabIndex = 0;
            lblDirectors.Text = "Directors";
            lblDirectors.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchResultMovieItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblReleaseYear);
            Controls.Add(lblDirectors);
            Controls.Add(lblTitle);
            Name = "SearchResultMovieItem";
            Size = new Size(450, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblReleaseYear;
        private Label lblDirectors;
    }
}
