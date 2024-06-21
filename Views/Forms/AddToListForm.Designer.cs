namespace CineVerse.Views.Forms
{
    partial class AddToListForm
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
            pnHeader = new Panel();
            btnClose = new Button();
            lblFormTitle = new Label();
            pnFormBody = new Panel();
            pnNewList = new Panel();
            picAdd = new PictureBox();
            lblNewList = new Label();
            btnAdd = new Button();
            pnHeader.SuspendLayout();
            pnFormBody.SuspendLayout();
            pnNewList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.FromArgb(54, 68, 82);
            pnHeader.BorderStyle = BorderStyle.FixedSingle;
            pnHeader.Controls.Add(btnClose);
            pnHeader.Controls.Add(lblFormTitle);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(560, 70);
            pnHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(522, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(232, 230, 227);
            lblFormTitle.Location = new Point(11, 19);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(207, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add 'Hitman' to lists";
            // 
            // pnFormBody
            // 
            pnFormBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnFormBody.Controls.Add(pnNewList);
            pnFormBody.Location = new Point(0, 75);
            pnFormBody.Name = "pnFormBody";
            pnFormBody.Size = new Size(560, 165);
            pnFormBody.TabIndex = 1;
            // 
            // pnNewList
            // 
            pnNewList.Controls.Add(picAdd);
            pnNewList.Controls.Add(lblNewList);
            pnNewList.Dock = DockStyle.Top;
            pnNewList.Location = new Point(0, 0);
            pnNewList.Name = "pnNewList";
            pnNewList.Size = new Size(560, 39);
            pnNewList.TabIndex = 0;
            pnNewList.Click += pnNewList_Click;
            // 
            // picAdd
            // 
            picAdd.Image = Properties.Resources.add;
            picAdd.Location = new Point(25, 12);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(16, 16);
            picAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdd.TabIndex = 1;
            picAdd.TabStop = false;
            // 
            // lblNewList
            // 
            lblNewList.AutoSize = true;
            lblNewList.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblNewList.ForeColor = Color.FromArgb(173, 196, 214);
            lblNewList.Location = new Point(45, 9);
            lblNewList.Name = "lblNewList";
            lblNewList.Size = new Size(79, 20);
            lblNewList.TabIndex = 0;
            lblNewList.Text = "New list ...";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 138, 22);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(216, 244, 202);
            btnAdd.Location = new Point(478, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // AddToListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 54, 68);
            ClientSize = new Size(560, 290);
            Controls.Add(btnAdd);
            Controls.Add(pnFormBody);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddToListForm";
            Text = "AddToListForm";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnFormBody.ResumeLayout(false);
            pnNewList.ResumeLayout(false);
            pnNewList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblFormTitle;
        private Panel pnFormBody;
        private Button btnAdd;
        private Panel pnNewList;
        private Label lblNewList;
        private PictureBox picAdd;
        private Button btnClose;
    }
}