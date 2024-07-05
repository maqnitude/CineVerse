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
            pnListInfo = new Panel();
            ((System.ComponentModel.ISupportInitialize)picCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListType).BeginInit();
            pnListInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Dock = DockStyle.Fill;
            lblListTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListTitle.ForeColor = Color.FromArgb(173, 196, 214);
            lblListTitle.Location = new Point(20, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(13, 20);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "I";
            lblListTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picCheck
            // 
            picCheck.Dock = DockStyle.Left;
            picCheck.Location = new Point(0, 0);
            picCheck.Name = "picCheck";
            picCheck.Size = new Size(20, 20);
            picCheck.TabIndex = 1;
            picCheck.TabStop = false;
            // 
            // picListType
            // 
            picListType.Dock = DockStyle.Right;
            picListType.Location = new Point(45, 0);
            picListType.Name = "picListType";
            picListType.Size = new Size(20, 20);
            picListType.SizeMode = PictureBoxSizeMode.Zoom;
            picListType.TabIndex = 1;
            picListType.TabStop = false;
            // 
            // lblNumMovies
            // 
            lblNumMovies.Anchor = AnchorStyles.Right;
            lblNumMovies.AutoSize = true;
            lblNumMovies.Font = new Font("Segoe UI", 10.5F);
            lblNumMovies.ForeColor = Color.FromArgb(178, 172, 162);
            lblNumMovies.Location = new Point(275, 8);
            lblNumMovies.Name = "lblNumMovies";
            lblNumMovies.Size = new Size(49, 19);
            lblNumMovies.TabIndex = 2;
            lblNumMovies.Text = "0 films";
            // 
            // pnListInfo
            // 
            pnListInfo.Anchor = AnchorStyles.Left;
            pnListInfo.AutoSize = true;
            pnListInfo.Controls.Add(lblListTitle);
            pnListInfo.Controls.Add(picListType);
            pnListInfo.Controls.Add(picCheck);
            pnListInfo.Location = new Point(13, 8);
            pnListInfo.Name = "pnListInfo";
            pnListInfo.Size = new Size(65, 20);
            pnListInfo.TabIndex = 3;
            // 
            // ListItemBasic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(54, 68, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnListInfo);
            Controls.Add(lblNumMovies);
            Name = "ListItemBasic";
            Size = new Size(331, 37);
            ((System.ComponentModel.ISupportInitialize)picCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListType).EndInit();
            pnListInfo.ResumeLayout(false);
            pnListInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListTitle;
        private PictureBox picCheck;
        private PictureBox picListType;
        private Label lblNumMovies;
        private Panel pnListInfo;
    }
}
