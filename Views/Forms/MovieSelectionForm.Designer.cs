namespace CineVerse.Views.Forms
{
    partial class MovieSelectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFormTitle = new Label();
            lblMovieNameHeading = new Label();
            pnSearchbar = new Panel();
            txtSearchbox = new TextBox();
            btnClose = new Button();
            pnResults = new Panel();
            pnMain = new Panel();
            pnSearchbar.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(178, 172, 162);
            lblFormTitle.Location = new Point(12, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(116, 21);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "PICK A MOVIE";
            // 
            // lblMovieNameHeading
            // 
            lblMovieNameHeading.AutoSize = true;
            lblMovieNameHeading.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieNameHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblMovieNameHeading.Location = new Point(12, 43);
            lblMovieNameHeading.Name = "lblMovieNameHeading";
            lblMovieNameHeading.Size = new Size(101, 17);
            lblMovieNameHeading.TabIndex = 3;
            lblMovieNameHeading.Text = "Name of Movie";
            // 
            // pnSearchbar
            // 
            pnSearchbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnSearchbar.BackColor = Color.FromArgb(24, 26, 27);
            pnSearchbar.Controls.Add(txtSearchbox);
            pnSearchbar.Location = new Point(12, 63);
            pnSearchbar.Name = "pnSearchbar";
            pnSearchbar.Size = new Size(365, 40);
            pnSearchbar.TabIndex = 4;
            // 
            // txtSearchbox
            // 
            txtSearchbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchbox.BackColor = Color.FromArgb(24, 26, 27);
            txtSearchbox.BorderStyle = BorderStyle.None;
            txtSearchbox.Font = new Font("Segoe UI", 10F);
            txtSearchbox.ForeColor = Color.FromArgb(168, 160, 149);
            txtSearchbox.Location = new Point(12, 11);
            txtSearchbox.Name = "txtSearchbox";
            txtSearchbox.Size = new Size(343, 18);
            txtSearchbox.TabIndex = 0;
            txtSearchbox.TextChanged += txtSearchbox_TextChanged;
            txtSearchbox.Enter += txtSearchbox_Enter;
            txtSearchbox.Leave += txtSearchbox_Leave;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(354, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnResults
            // 
            pnResults.AutoSize = true;
            pnResults.Dock = DockStyle.Fill;
            pnResults.Location = new Point(0, 106);
            pnResults.Name = "pnResults";
            pnResults.Size = new Size(391, 5);
            pnResults.TabIndex = 6;
            // 
            // pnMain
            // 
            pnMain.AutoSize = true;
            pnMain.Controls.Add(lblFormTitle);
            pnMain.Controls.Add(lblMovieNameHeading);
            pnMain.Controls.Add(btnClose);
            pnMain.Controls.Add(pnSearchbar);
            pnMain.Dock = DockStyle.Top;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(391, 106);
            pnMain.TabIndex = 7;
            // 
            // MovieSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(54, 68, 82);
            ClientSize = new Size(391, 111);
            Controls.Add(pnResults);
            Controls.Add(pnMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovieSelectionForm";
            Text = "MovieSelectionForm";
            pnSearchbar.ResumeLayout(false);
            pnSearchbar.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblMovieNameHeading;
        private Panel pnSearchbar;
        private TextBox txtSearchbox;
        private Button btnClose;
        private Panel pnResults;
        private Panel pnMain;
    }
}