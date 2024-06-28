namespace CineVerse.Views.UserControls
{
    partial class StarRatingControlOld
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
            picStar1 = new PictureBox();
            picStar2 = new PictureBox();
            picStar3 = new PictureBox();
            picStar4 = new PictureBox();
            picStar5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            SuspendLayout();
            // 
            // picStar1
            // 
            picStar1.Dock = DockStyle.Left;
            picStar1.Image = Properties.Resources.star_fill_dark;
            picStar1.Location = new Point(0, 0);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(32, 32);
            picStar1.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar1.TabIndex = 3;
            picStar1.TabStop = false;
            // 
            // picStar2
            // 
            picStar2.Dock = DockStyle.Left;
            picStar2.Image = Properties.Resources.star_fill_dark;
            picStar2.Location = new Point(32, 0);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(32, 32);
            picStar2.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar2.TabIndex = 4;
            picStar2.TabStop = false;
            // 
            // picStar3
            // 
            picStar3.Dock = DockStyle.Left;
            picStar3.Image = Properties.Resources.star_fill_dark;
            picStar3.Location = new Point(64, 0);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(32, 32);
            picStar3.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar3.TabIndex = 5;
            picStar3.TabStop = false;
            // 
            // picStar4
            // 
            picStar4.Dock = DockStyle.Left;
            picStar4.Image = Properties.Resources.star_fill_dark;
            picStar4.Location = new Point(96, 0);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(32, 32);
            picStar4.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar4.TabIndex = 6;
            picStar4.TabStop = false;
            // 
            // picStar5
            // 
            picStar5.Dock = DockStyle.Left;
            picStar5.Image = Properties.Resources.star_fill_dark;
            picStar5.Location = new Point(128, 0);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(32, 32);
            picStar5.SizeMode = PictureBoxSizeMode.CenterImage;
            picStar5.TabIndex = 7;
            picStar5.TabStop = false;
            // 
            // StarRatingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(picStar5);
            Controls.Add(picStar4);
            Controls.Add(picStar3);
            Controls.Add(picStar2);
            Controls.Add(picStar1);
            Name = "StarRatingControl";
            Size = new Size(160, 32);
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picStar1;
        private PictureBox picStar2;
        private PictureBox picStar3;
        private PictureBox picStar4;
        private PictureBox picStar5;
    }
}
