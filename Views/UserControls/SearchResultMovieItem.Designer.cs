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
            lblDirectors = new Label();
            pnMovieInfo = new Panel();
            lblReleaseYear = new Label();
            pnWrapper = new Panel();
            pnMovieInfo.SuspendLayout();
            pnWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4);
            lblTitle.MaximumSize = new Size(245, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Movie Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDirectors
            // 
            lblDirectors.Dock = DockStyle.Bottom;
            lblDirectors.Font = new Font("Segoe UI", 8F);
            lblDirectors.ForeColor = Color.FromArgb(196, 209, 220);
            lblDirectors.Location = new Point(0, 19);
            lblDirectors.Margin = new Padding(4);
            lblDirectors.MaximumSize = new Size(245, 0);
            lblDirectors.Name = "lblDirectors";
            lblDirectors.Size = new Size(137, 13);
            lblDirectors.TabIndex = 0;
            lblDirectors.Text = "Directors";
            lblDirectors.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnMovieInfo
            // 
            pnMovieInfo.AutoSize = true;
            pnMovieInfo.Controls.Add(lblTitle);
            pnMovieInfo.Controls.Add(lblReleaseYear);
            pnMovieInfo.Dock = DockStyle.Fill;
            pnMovieInfo.Location = new Point(0, 0);
            pnMovieInfo.MaximumSize = new Size(205, 0);
            pnMovieInfo.Name = "pnMovieInfo";
            pnMovieInfo.Size = new Size(137, 19);
            pnMovieInfo.TabIndex = 1;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.Dock = DockStyle.Right;
            lblReleaseYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReleaseYear.ForeColor = Color.FromArgb(232, 230, 227);
            lblReleaseYear.Location = new Point(84, 0);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(53, 19);
            lblReleaseYear.TabIndex = 1;
            lblReleaseYear.Text = "(2024)";
            // 
            // pnWrapper
            // 
            pnWrapper.AutoSize = true;
            pnWrapper.Controls.Add(pnMovieInfo);
            pnWrapper.Controls.Add(lblDirectors);
            pnWrapper.Location = new Point(3, 5);
            pnWrapper.Name = "pnWrapper";
            pnWrapper.Size = new Size(137, 32);
            pnWrapper.TabIndex = 2;
            // 
            // SearchResultMovieItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnWrapper);
            MaximumSize = new Size(250, 0);
            Name = "SearchResultMovieItem";
            Size = new Size(248, 44);
            pnMovieInfo.ResumeLayout(false);
            pnMovieInfo.PerformLayout();
            pnWrapper.ResumeLayout(false);
            pnWrapper.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDirectors;
        private Panel pnMovieInfo;
        private Label lblReleaseYear;
        private Panel pnWrapper;
    }
}
