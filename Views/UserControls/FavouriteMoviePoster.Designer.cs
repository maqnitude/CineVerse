namespace CineVerse.Views.UserControls
{
    partial class FavouriteMoviePoster
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
            picPoster = new PictureBox();
            btnRemove = new CustomControls.CircularButton();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            SuspendLayout();
            // 
            // picPoster
            // 
            picPoster.Dock = DockStyle.Fill;
            picPoster.Image = Properties.Resources.poster_add_placeholder;
            picPoster.Location = new Point(0, 0);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(110, 165);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picPoster.TabIndex = 0;
            picPoster.TabStop = false;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = Properties.Resources.poster_remove;
            btnRemove.Location = new Point(99, 1);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(19, 19);
            btnRemove.TabIndex = 2;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Visible = false;
            // 
            // FavouriteMoviePoster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnRemove);
            Controls.Add(picPoster);
            Name = "FavouriteMoviePoster";
            Padding = new Padding(0, 0, 10, 0);
            Size = new Size(120, 165);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPoster;
        private CustomControls.CircularButton btnRemove;
    }
}
