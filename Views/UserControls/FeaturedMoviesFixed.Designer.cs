namespace CineVerse.Views.UserControls
{
    partial class FeaturedMoviesFixed
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
            tableLayoutPanel1 = new TableLayoutPanel();
            movieCard1 = new MovieCard();
            movieCard2 = new MovieCard();
            movieCard3 = new MovieCard();
            movieCard4 = new MovieCard();
            movieCard5 = new MovieCard();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(movieCard1, 0, 0);
            tableLayoutPanel1.Controls.Add(movieCard2, 1, 0);
            tableLayoutPanel1.Controls.Add(movieCard3, 2, 0);
            tableLayoutPanel1.Controls.Add(movieCard4, 3, 0);
            tableLayoutPanel1.Controls.Add(movieCard5, 4, 0);
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(972, 263);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // movieCard1
            // 
            movieCard1.BackColor = Color.FromArgb(19, 20, 26);
            movieCard1.Dock = DockStyle.Fill;
            movieCard1.Location = new Point(2, 2);
            movieCard1.Margin = new Padding(2, 2, 2, 2);
            movieCard1.Name = "movieCard1";
            movieCard1.Size = new Size(190, 259);
            movieCard1.TabIndex = 0;
            // 
            // movieCard2
            // 
            movieCard2.BackColor = Color.FromArgb(19, 20, 26);
            movieCard2.Dock = DockStyle.Fill;
            movieCard2.Location = new Point(196, 2);
            movieCard2.Margin = new Padding(2, 2, 2, 2);
            movieCard2.Name = "movieCard2";
            movieCard2.Size = new Size(190, 259);
            movieCard2.TabIndex = 1;
            // 
            // movieCard3
            // 
            movieCard3.BackColor = Color.FromArgb(19, 20, 26);
            movieCard3.Dock = DockStyle.Fill;
            movieCard3.Location = new Point(390, 2);
            movieCard3.Margin = new Padding(2, 2, 2, 2);
            movieCard3.Name = "movieCard3";
            movieCard3.Size = new Size(190, 259);
            movieCard3.TabIndex = 2;
            // 
            // movieCard4
            // 
            movieCard4.BackColor = Color.FromArgb(19, 20, 26);
            movieCard4.Dock = DockStyle.Fill;
            movieCard4.Location = new Point(584, 2);
            movieCard4.Margin = new Padding(2, 2, 2, 2);
            movieCard4.Name = "movieCard4";
            movieCard4.Size = new Size(190, 259);
            movieCard4.TabIndex = 3;
            // 
            // movieCard5
            // 
            movieCard5.BackColor = Color.FromArgb(19, 20, 26);
            movieCard5.Dock = DockStyle.Fill;
            movieCard5.Location = new Point(778, 2);
            movieCard5.Margin = new Padding(2, 2, 2, 2);
            movieCard5.Name = "movieCard5";
            movieCard5.Size = new Size(192, 259);
            movieCard5.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 32);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(447, 32);
            label1.TabIndex = 2;
            label1.Text = "Featured movies";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DisplaySection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "DisplaySection";
            Size = new Size(972, 295);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MovieCard movieCard1;
        private MovieCard movieCard2;
        private MovieCard movieCard3;
        private MovieCard movieCard4;
        private MovieCard movieCard5;
        private Panel panel1;
        private Label label1;
    }
}
