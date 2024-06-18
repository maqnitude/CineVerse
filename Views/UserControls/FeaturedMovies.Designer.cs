namespace CineVerse.Views.UserControls
{
    partial class FeaturedMovies
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            movieCard1 = new MovieCard();
            movieCard2 = new MovieCard();
            movieCard3 = new MovieCard();
            movieCard4 = new MovieCard();
            movieCard5 = new MovieCard();
            movieCard6 = new MovieCard();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 32);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(movieCard1);
            flowLayoutPanel1.Controls.Add(movieCard2);
            flowLayoutPanel1.Controls.Add(movieCard3);
            flowLayoutPanel1.Controls.Add(movieCard4);
            flowLayoutPanel1.Controls.Add(movieCard5);
            flowLayoutPanel1.Controls.Add(movieCard6);
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1074, 283);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // movieCard1
            // 
            movieCard1.BackColor = Color.FromArgb(19, 20, 26);
            movieCard1.Location = new Point(2, 2);
            movieCard1.Margin = new Padding(2, 2, 2, 2);
            movieCard1.Name = "movieCard1";
            movieCard1.Size = new Size(172, 279);
            movieCard1.TabIndex = 0;
            // 
            // movieCard2
            // 
            movieCard2.BackColor = Color.FromArgb(19, 20, 26);
            movieCard2.Location = new Point(178, 2);
            movieCard2.Margin = new Padding(2, 2, 2, 2);
            movieCard2.Name = "movieCard2";
            movieCard2.Size = new Size(172, 279);
            movieCard2.TabIndex = 0;
            // 
            // movieCard3
            // 
            movieCard3.BackColor = Color.FromArgb(19, 20, 26);
            movieCard3.Location = new Point(354, 2);
            movieCard3.Margin = new Padding(2, 2, 2, 2);
            movieCard3.Name = "movieCard3";
            movieCard3.Size = new Size(172, 279);
            movieCard3.TabIndex = 0;
            // 
            // movieCard4
            // 
            movieCard4.BackColor = Color.FromArgb(19, 20, 26);
            movieCard4.Location = new Point(530, 2);
            movieCard4.Margin = new Padding(2, 2, 2, 2);
            movieCard4.Name = "movieCard4";
            movieCard4.Size = new Size(172, 279);
            movieCard4.TabIndex = 0;
            // 
            // movieCard5
            // 
            movieCard5.BackColor = Color.FromArgb(19, 20, 26);
            movieCard5.Location = new Point(706, 2);
            movieCard5.Margin = new Padding(2, 2, 2, 2);
            movieCard5.Name = "movieCard5";
            movieCard5.Size = new Size(172, 279);
            movieCard5.TabIndex = 0;
            // 
            // movieCard6
            // 
            movieCard6.BackColor = Color.FromArgb(19, 20, 26);
            movieCard6.Location = new Point(882, 2);
            movieCard6.Margin = new Padding(2, 2, 2, 2);
            movieCard6.Name = "movieCard6";
            movieCard6.Size = new Size(172, 279);
            movieCard6.TabIndex = 0;
            // 
            // FeaturedMovies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FeaturedMovies";
            Size = new Size(1074, 315);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MovieCard movieCard1;
        private MovieCard movieCard2;
        private MovieCard movieCard3;
        private MovieCard movieCard4;
        private MovieCard movieCard5;
        private MovieCard movieCard6;
    }
}
