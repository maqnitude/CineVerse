namespace CineVerse.Views.UserControls
{
    partial class ActivityItemBasic
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
            picUser = new PictureBox();
            pnDescription = new Panel();
            lblQuote = new Label();
            pnSummary = new Panel();
            lblTarget2 = new Label();
            lblTime = new Label();
            lblContext2 = new Label();
            lblTarget1 = new Label();
            lblContext1 = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnDescription.SuspendLayout();
            pnSummary.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.Location = new Point(3, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(24, 24);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // pnDescription
            // 
            pnDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnDescription.AutoSize = true;
            pnDescription.Controls.Add(lblQuote);
            pnDescription.Controls.Add(pnSummary);
            pnDescription.Location = new Point(33, 3);
            pnDescription.Name = "pnDescription";
            pnDescription.Size = new Size(632, 62);
            pnDescription.TabIndex = 1;
            // 
            // lblQuote
            // 
            lblQuote.AutoSize = true;
            lblQuote.Dock = DockStyle.Fill;
            lblQuote.ForeColor = Color.FromArgb(164, 184, 200);
            lblQuote.Location = new Point(0, 15);
            lblQuote.Name = "lblQuote";
            lblQuote.Padding = new Padding(10, 0, 0, 0);
            lblQuote.Size = new Size(375, 15);
            lblQuote.TabIndex = 1;
            lblQuote.Text = "This is the quoted comment text. For example: you gotta be kidding";
            // 
            // pnSummary
            // 
            pnSummary.AutoSize = true;
            pnSummary.Controls.Add(lblTarget2);
            pnSummary.Controls.Add(lblTime);
            pnSummary.Controls.Add(lblContext2);
            pnSummary.Controls.Add(lblTarget1);
            pnSummary.Controls.Add(lblContext1);
            pnSummary.Controls.Add(lblUsername);
            pnSummary.Dock = DockStyle.Top;
            pnSummary.Location = new Point(0, 0);
            pnSummary.Name = "pnSummary";
            pnSummary.Size = new Size(632, 15);
            pnSummary.TabIndex = 0;
            // 
            // lblTarget2
            // 
            lblTarget2.AutoSize = true;
            lblTarget2.Dock = DockStyle.Fill;
            lblTarget2.ForeColor = Color.FromArgb(232, 230, 227);
            lblTarget2.Location = new Point(314, 0);
            lblTarget2.Name = "lblTarget2";
            lblTarget2.Size = new Size(81, 15);
            lblTarget2.TabIndex = 4;
            lblTarget2.Text = "Funny movies";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Right;
            lblTime.ForeColor = Color.FromArgb(232, 230, 227);
            lblTime.Location = new Point(612, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(20, 15);
            lblTime.TabIndex = 5;
            lblTime.Text = "2d";
            // 
            // lblContext2
            // 
            lblContext2.AutoSize = true;
            lblContext2.Dock = DockStyle.Left;
            lblContext2.ForeColor = Color.FromArgb(157, 148, 136);
            lblContext2.Location = new Point(260, 0);
            lblContext2.Name = "lblContext2";
            lblContext2.Size = new Size(54, 15);
            lblContext2.TabIndex = 3;
            lblContext2.Text = "to his list";
            // 
            // lblTarget1
            // 
            lblTarget1.AutoSize = true;
            lblTarget1.Dock = DockStyle.Left;
            lblTarget1.ForeColor = Color.FromArgb(232, 230, 227);
            lblTarget1.Location = new Point(90, 0);
            lblTarget1.Name = "lblTarget1";
            lblTarget1.Size = new Size(170, 15);
            lblTarget1.TabIndex = 2;
            lblTarget1.Text = "Salò, or the 120 Days of Sodom";
            // 
            // lblContext1
            // 
            lblContext1.AutoSize = true;
            lblContext1.Dock = DockStyle.Left;
            lblContext1.ForeColor = Color.FromArgb(157, 148, 136);
            lblContext1.Location = new Point(50, 0);
            lblContext1.Name = "lblContext1";
            lblContext1.Size = new Size(40, 15);
            lblContext1.TabIndex = 1;
            lblContext1.Text = "added";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Left;
            lblUsername.ForeColor = Color.FromArgb(168, 160, 149);
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "ZyklonX";
            // 
            // ActivityItemBasic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(22, 28, 34);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnDescription);
            Controls.Add(picUser);
            Name = "ActivityItemBasic";
            Size = new Size(668, 68);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnDescription.ResumeLayout(false);
            pnDescription.PerformLayout();
            pnSummary.ResumeLayout(false);
            pnSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Panel pnDescription;
        private Panel pnSummary;
        private Label lblUsername;
        private Label lblTarget1;
        private Label lblContext1;
        private Label lblTarget2;
        private Label lblContext2;
        private Label lblQuote;
        private Label lblTime;
    }
}
