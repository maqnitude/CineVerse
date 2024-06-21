namespace CineVerse.Views.UserControls
{
    partial class ListItemBasic
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
            lblListTitle = new Label();
            picCheck = new PictureBox();
            picListType = new PictureBox();
            lblNumMovies = new Label();
            ((System.ComponentModel.ISupportInitialize)picCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListType).BeginInit();
            SuspendLayout();
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListTitle.ForeColor = Color.FromArgb(173, 196, 214);
            lblListTitle.Location = new Point(42, 9);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(139, 20);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Best Revenge Films";
            // 
            // picCheck
            // 
            picCheck.Location = new Point(14, 7);
            picCheck.Name = "picCheck";
            picCheck.Size = new Size(25, 25);
            picCheck.TabIndex = 1;
            picCheck.TabStop = false;
            // 
            // picListType
            // 
            picListType.Anchor = AnchorStyles.Top;
            picListType.Location = new Point(187, 7);
            picListType.Name = "picListType";
            picListType.Size = new Size(26, 26);
            picListType.TabIndex = 1;
            picListType.TabStop = false;
            // 
            // lblNumMovies
            // 
            lblNumMovies.Anchor = AnchorStyles.Right;
            lblNumMovies.AutoSize = true;
            lblNumMovies.Font = new Font("Segoe UI", 10.5F);
            lblNumMovies.ForeColor = Color.FromArgb(178, 172, 162);
            lblNumMovies.Location = new Point(504, 9);
            lblNumMovies.Name = "lblNumMovies";
            lblNumMovies.Size = new Size(49, 19);
            lblNumMovies.TabIndex = 2;
            lblNumMovies.Text = "0 films";
            // 
            // ListItemBasic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 68, 82);
            Controls.Add(lblNumMovies);
            Controls.Add(picListType);
            Controls.Add(picCheck);
            Controls.Add(lblListTitle);
            Name = "ListItemBasic";
            Size = new Size(560, 39);
            Click += ListItemBasic_Click;
            ((System.ComponentModel.ISupportInitialize)picCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListTitle;
        private PictureBox picCheck;
        private PictureBox picListType;
        private Label lblNumMovies;
    }
}
