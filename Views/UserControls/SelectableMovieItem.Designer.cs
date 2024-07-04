namespace CineVerse.Views.UserControls
{
    partial class SelectableMovieItem
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
            pnMovieInfo = new Panel();
            lblDirector = new Label();
            lblMovieTitle = new Label();
            picMoviePoster = new PictureBox();
            pnMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).BeginInit();
            SuspendLayout();
            // 
            // pnMovieInfo
            // 
            pnMovieInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnMovieInfo.AutoSize = true;
            pnMovieInfo.Controls.Add(lblDirector);
            pnMovieInfo.Controls.Add(lblMovieTitle);
            pnMovieInfo.Location = new Point(39, 11);
            pnMovieInfo.Name = "pnMovieInfo";
            pnMovieInfo.Size = new Size(234, 22);
            pnMovieInfo.TabIndex = 0;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Dock = DockStyle.Fill;
            lblDirector.ForeColor = Color.FromArgb(196, 209, 220);
            lblDirector.Location = new Point(159, 0);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(69, 15);
            lblDirector.TabIndex = 1;
            lblDirector.Text = "Ridley Scott";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Dock = DockStyle.Left;
            lblMovieTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieTitle.Location = new Point(0, 0);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(159, 17);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "Blade Runner 2049 (1982)";
            // 
            // picMoviePoster
            // 
            picMoviePoster.Anchor = AnchorStyles.Left;
            picMoviePoster.Location = new Point(3, 5);
            picMoviePoster.Name = "picMoviePoster";
            picMoviePoster.Size = new Size(22, 33);
            picMoviePoster.TabIndex = 1;
            picMoviePoster.TabStop = false;
            // 
            // SelectableMovieItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picMoviePoster);
            Controls.Add(pnMovieInfo);
            Name = "SelectableMovieItem";
            Size = new Size(276, 43);
            pnMovieInfo.ResumeLayout(false);
            pnMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnMovieInfo;
        private Label lblDirector;
        private Label lblMovieTitle;
        private PictureBox picMoviePoster;
    }
}
