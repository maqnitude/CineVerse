namespace CineVerse.Views.UserControls
{
    partial class MovieCard
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
            lblMovieTitle = new Label();
            pnMoviePoster = new Panel();
            pnActions = new Panel();
            btnLike = new Button();
            btnMore = new Button();
            btnWatch = new Button();
            pnMoviePoster.SuspendLayout();
            pnActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.Dock = DockStyle.Bottom;
            lblMovieTitle.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblMovieTitle.ForeColor = Color.White;
            lblMovieTitle.Location = new Point(0, 197);
            lblMovieTitle.Margin = new Padding(2, 0, 2, 0);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(150, 28);
            lblMovieTitle.TabIndex = 1;
            lblMovieTitle.Text = "Furiosa";
            lblMovieTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnMoviePoster
            // 
            pnMoviePoster.BackColor = Color.FromArgb(13, 15, 16);
            pnMoviePoster.Controls.Add(pnActions);
            pnMoviePoster.Dock = DockStyle.Fill;
            pnMoviePoster.Location = new Point(0, 0);
            pnMoviePoster.Margin = new Padding(2);
            pnMoviePoster.Name = "pnMoviePoster";
            pnMoviePoster.Size = new Size(150, 197);
            pnMoviePoster.TabIndex = 2;
            // 
            // pnActions
            // 
            pnActions.Anchor = AnchorStyles.Bottom;
            pnActions.BackColor = Color.Transparent;
            pnActions.Controls.Add(btnLike);
            pnActions.Controls.Add(btnMore);
            pnActions.Controls.Add(btnWatch);
            pnActions.Location = new Point(39, 174);
            pnActions.Margin = new Padding(2);
            pnActions.Name = "pnActions";
            pnActions.Size = new Size(70, 20);
            pnActions.TabIndex = 0;
            pnActions.Visible = false;
            // 
            // btnLike
            // 
            btnLike.BackColor = Color.Transparent;
            btnLike.Dock = DockStyle.Fill;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Image = Properties.Resources.like;
            btnLike.Location = new Point(27, 0);
            btnLike.Margin = new Padding(2);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(16, 20);
            btnLike.TabIndex = 3;
            btnLike.UseVisualStyleBackColor = false;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.Transparent;
            btnMore.Dock = DockStyle.Right;
            btnMore.FlatAppearance.BorderSize = 0;
            btnMore.FlatStyle = FlatStyle.Flat;
            btnMore.Image = Properties.Resources.menu;
            btnMore.Location = new Point(43, 0);
            btnMore.Margin = new Padding(2);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(27, 20);
            btnMore.TabIndex = 2;
            btnMore.UseVisualStyleBackColor = false;
            // 
            // btnWatch
            // 
            btnWatch.BackColor = Color.Transparent;
            btnWatch.Dock = DockStyle.Left;
            btnWatch.FlatAppearance.BorderSize = 0;
            btnWatch.FlatStyle = FlatStyle.Flat;
            btnWatch.Image = Properties.Resources.eye_fill;
            btnWatch.Location = new Point(0, 0);
            btnWatch.Margin = new Padding(2);
            btnWatch.Name = "btnWatch";
            btnWatch.Size = new Size(27, 20);
            btnWatch.TabIndex = 0;
            btnWatch.UseVisualStyleBackColor = false;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 20, 26);
            Controls.Add(pnMoviePoster);
            Controls.Add(lblMovieTitle);
            Margin = new Padding(2);
            Name = "MovieCard";
            Size = new Size(150, 225);
            pnMoviePoster.ResumeLayout(false);
            pnActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblMovieTitle;
        private Panel pnMoviePoster;
        private Panel pnActions;
        private Button btnLike;
        private Button btnMore;
        private Button btnWatch;
    }
}
