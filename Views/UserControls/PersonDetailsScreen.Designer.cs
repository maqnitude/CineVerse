namespace CineVerse.Views.UserControls
{
    partial class PersonDetailsScreen
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
            picProfile = new PictureBox();
            lblName = new Label();
            lblBiographyHeading = new Label();
            txtBiography = new TextBox();
            pnKnownForSection = new Panel();
            pnMovieCards = new Panel();
            lblKnownForHeading = new Label();
            pnColumn1 = new Panel();
            btnBack = new Button();
            pnPersonalInfo = new Panel();
            pnBirthdaySection = new Panel();
            lblBirthday = new Label();
            lblBirthdayHeading = new Label();
            pnPlaceOfBirthSection = new Panel();
            lblPlaceOfBirth = new Label();
            lblPlaceOfBirthHeading = new Label();
            pnGenderSection = new Panel();
            lblGender = new Label();
            lblGenderHeading = new Label();
            pnKnownForRoleSection = new Panel();
            lblExperise = new Label();
            lblKnownForRole = new Label();
            lblPersonalInfoHeading = new Label();
            pnColumn2 = new Panel();
            pnCreditsListSection = new Panel();
            pnCreditsListContainer = new Panel();
            lblCreditsHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            pnKnownForSection.SuspendLayout();
            pnColumn1.SuspendLayout();
            pnPersonalInfo.SuspendLayout();
            pnBirthdaySection.SuspendLayout();
            pnPlaceOfBirthSection.SuspendLayout();
            pnGenderSection.SuspendLayout();
            pnKnownForRoleSection.SuspendLayout();
            pnColumn2.SuspendLayout();
            pnCreditsListSection.SuspendLayout();
            SuspendLayout();
            // 
            // picProfile
            // 
            picProfile.Location = new Point(18, 44);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(250, 375);
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(232, 230, 227);
            lblName.Location = new Point(24, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(236, 37);
            lblName.TabIndex = 1;
            lblName.Text = "Anya Taylor-Joy";
            // 
            // lblBiographyHeading
            // 
            lblBiographyHeading.AutoSize = true;
            lblBiographyHeading.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblBiographyHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblBiographyHeading.Location = new Point(24, 97);
            lblBiographyHeading.Name = "lblBiographyHeading";
            lblBiographyHeading.Size = new Size(100, 25);
            lblBiographyHeading.TabIndex = 2;
            lblBiographyHeading.Text = "Biography";
            // 
            // txtBiography
            // 
            txtBiography.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBiography.BackColor = Color.FromArgb(16, 19, 22);
            txtBiography.BorderStyle = BorderStyle.None;
            txtBiography.Font = new Font("Segoe UI", 10F);
            txtBiography.ForeColor = Color.FromArgb(232, 230, 227);
            txtBiography.Location = new Point(24, 125);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.ReadOnly = true;
            txtBiography.ScrollBars = ScrollBars.Vertical;
            txtBiography.Size = new Size(740, 224);
            txtBiography.TabIndex = 4;
            // 
            // pnKnownForSection
            // 
            pnKnownForSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnKnownForSection.Controls.Add(pnMovieCards);
            pnKnownForSection.Controls.Add(lblKnownForHeading);
            pnKnownForSection.Location = new Point(24, 403);
            pnKnownForSection.Name = "pnKnownForSection";
            pnKnownForSection.Size = new Size(740, 275);
            pnKnownForSection.TabIndex = 5;
            // 
            // pnMovieCards
            // 
            pnMovieCards.AutoScroll = true;
            pnMovieCards.Dock = DockStyle.Fill;
            pnMovieCards.Location = new Point(0, 22);
            pnMovieCards.Name = "pnMovieCards";
            pnMovieCards.Size = new Size(740, 253);
            pnMovieCards.TabIndex = 1;
            // 
            // lblKnownForHeading
            // 
            lblKnownForHeading.Dock = DockStyle.Top;
            lblKnownForHeading.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKnownForHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblKnownForHeading.Location = new Point(0, 0);
            lblKnownForHeading.Name = "lblKnownForHeading";
            lblKnownForHeading.Size = new Size(740, 22);
            lblKnownForHeading.TabIndex = 0;
            lblKnownForHeading.Text = "Known for";
            // 
            // pnColumn1
            // 
            pnColumn1.Controls.Add(btnBack);
            pnColumn1.Controls.Add(pnPersonalInfo);
            pnColumn1.Controls.Add(picProfile);
            pnColumn1.Dock = DockStyle.Left;
            pnColumn1.Location = new Point(0, 0);
            pnColumn1.Name = "pnColumn1";
            pnColumn1.Size = new Size(281, 1060);
            pnColumn1.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnPersonalInfo
            // 
            pnPersonalInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnPersonalInfo.Controls.Add(pnBirthdaySection);
            pnPersonalInfo.Controls.Add(pnPlaceOfBirthSection);
            pnPersonalInfo.Controls.Add(pnGenderSection);
            pnPersonalInfo.Controls.Add(pnKnownForRoleSection);
            pnPersonalInfo.Controls.Add(lblPersonalInfoHeading);
            pnPersonalInfo.Location = new Point(10, 435);
            pnPersonalInfo.Name = "pnPersonalInfo";
            pnPersonalInfo.Size = new Size(261, 612);
            pnPersonalInfo.TabIndex = 1;
            // 
            // pnBirthdaySection
            // 
            pnBirthdaySection.Controls.Add(lblBirthday);
            pnBirthdaySection.Controls.Add(lblBirthdayHeading);
            pnBirthdaySection.Dock = DockStyle.Top;
            pnBirthdaySection.Location = new Point(0, 205);
            pnBirthdaySection.Name = "pnBirthdaySection";
            pnBirthdaySection.Size = new Size(261, 77);
            pnBirthdaySection.TabIndex = 4;
            // 
            // lblBirthday
            // 
            lblBirthday.Dock = DockStyle.Fill;
            lblBirthday.Font = new Font("Segoe UI", 10F);
            lblBirthday.ForeColor = Color.FromArgb(232, 230, 227);
            lblBirthday.Location = new Point(0, 25);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(261, 52);
            lblBirthday.TabIndex = 1;
            lblBirthday.Text = "April 16, 1996 (28 years old) ";
            // 
            // lblBirthdayHeading
            // 
            lblBirthdayHeading.Dock = DockStyle.Top;
            lblBirthdayHeading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthdayHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblBirthdayHeading.Location = new Point(0, 0);
            lblBirthdayHeading.Name = "lblBirthdayHeading";
            lblBirthdayHeading.Size = new Size(261, 25);
            lblBirthdayHeading.TabIndex = 0;
            lblBirthdayHeading.Text = "Birthday";
            // 
            // pnPlaceOfBirthSection
            // 
            pnPlaceOfBirthSection.Controls.Add(lblPlaceOfBirth);
            pnPlaceOfBirthSection.Controls.Add(lblPlaceOfBirthHeading);
            pnPlaceOfBirthSection.Dock = DockStyle.Top;
            pnPlaceOfBirthSection.Location = new Point(0, 143);
            pnPlaceOfBirthSection.Name = "pnPlaceOfBirthSection";
            pnPlaceOfBirthSection.Size = new Size(261, 62);
            pnPlaceOfBirthSection.TabIndex = 3;
            // 
            // lblPlaceOfBirth
            // 
            lblPlaceOfBirth.Dock = DockStyle.Fill;
            lblPlaceOfBirth.Font = new Font("Segoe UI", 10F);
            lblPlaceOfBirth.ForeColor = Color.FromArgb(232, 230, 227);
            lblPlaceOfBirth.Location = new Point(0, 23);
            lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            lblPlaceOfBirth.Size = new Size(261, 39);
            lblPlaceOfBirth.TabIndex = 1;
            lblPlaceOfBirth.Text = "Miami, Florida, USA";
            // 
            // lblPlaceOfBirthHeading
            // 
            lblPlaceOfBirthHeading.Dock = DockStyle.Top;
            lblPlaceOfBirthHeading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaceOfBirthHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblPlaceOfBirthHeading.Location = new Point(0, 0);
            lblPlaceOfBirthHeading.Name = "lblPlaceOfBirthHeading";
            lblPlaceOfBirthHeading.Size = new Size(261, 23);
            lblPlaceOfBirthHeading.TabIndex = 0;
            lblPlaceOfBirthHeading.Text = "Place of birth";
            // 
            // pnGenderSection
            // 
            pnGenderSection.Controls.Add(lblGender);
            pnGenderSection.Controls.Add(lblGenderHeading);
            pnGenderSection.Dock = DockStyle.Top;
            pnGenderSection.Location = new Point(0, 88);
            pnGenderSection.Name = "pnGenderSection";
            pnGenderSection.Size = new Size(261, 55);
            pnGenderSection.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.Dock = DockStyle.Fill;
            lblGender.Font = new Font("Segoe UI", 10F);
            lblGender.ForeColor = Color.FromArgb(232, 230, 227);
            lblGender.Location = new Point(0, 22);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(261, 33);
            lblGender.TabIndex = 1;
            lblGender.Text = "Female";
            // 
            // lblGenderHeading
            // 
            lblGenderHeading.Dock = DockStyle.Top;
            lblGenderHeading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenderHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblGenderHeading.Location = new Point(0, 0);
            lblGenderHeading.Name = "lblGenderHeading";
            lblGenderHeading.Size = new Size(261, 22);
            lblGenderHeading.TabIndex = 0;
            lblGenderHeading.Text = "Gender";
            // 
            // pnKnownForRoleSection
            // 
            pnKnownForRoleSection.Controls.Add(lblExperise);
            pnKnownForRoleSection.Controls.Add(lblKnownForRole);
            pnKnownForRoleSection.Dock = DockStyle.Top;
            pnKnownForRoleSection.Location = new Point(0, 25);
            pnKnownForRoleSection.Name = "pnKnownForRoleSection";
            pnKnownForRoleSection.Size = new Size(261, 63);
            pnKnownForRoleSection.TabIndex = 1;
            // 
            // lblExperise
            // 
            lblExperise.Dock = DockStyle.Fill;
            lblExperise.Font = new Font("Segoe UI", 10F);
            lblExperise.ForeColor = Color.FromArgb(232, 230, 227);
            lblExperise.Location = new Point(0, 24);
            lblExperise.Name = "lblExperise";
            lblExperise.Size = new Size(261, 39);
            lblExperise.TabIndex = 1;
            lblExperise.Text = "Acting";
            // 
            // lblKnownForRole
            // 
            lblKnownForRole.Dock = DockStyle.Top;
            lblKnownForRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKnownForRole.ForeColor = Color.FromArgb(232, 230, 227);
            lblKnownForRole.Location = new Point(0, 0);
            lblKnownForRole.Name = "lblKnownForRole";
            lblKnownForRole.Size = new Size(261, 24);
            lblKnownForRole.TabIndex = 0;
            lblKnownForRole.Text = "Known for";
            // 
            // lblPersonalInfoHeading
            // 
            lblPersonalInfoHeading.AutoSize = true;
            lblPersonalInfoHeading.Dock = DockStyle.Top;
            lblPersonalInfoHeading.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            lblPersonalInfoHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblPersonalInfoHeading.Location = new Point(0, 0);
            lblPersonalInfoHeading.Name = "lblPersonalInfoHeading";
            lblPersonalInfoHeading.Size = new Size(130, 25);
            lblPersonalInfoHeading.TabIndex = 0;
            lblPersonalInfoHeading.Text = "Personal Info";
            // 
            // pnColumn2
            // 
            pnColumn2.Controls.Add(pnCreditsListSection);
            pnColumn2.Controls.Add(lblBiographyHeading);
            pnColumn2.Controls.Add(lblName);
            pnColumn2.Controls.Add(pnKnownForSection);
            pnColumn2.Controls.Add(txtBiography);
            pnColumn2.Dock = DockStyle.Fill;
            pnColumn2.Location = new Point(281, 0);
            pnColumn2.Name = "pnColumn2";
            pnColumn2.Size = new Size(821, 1060);
            pnColumn2.TabIndex = 7;
            // 
            // pnCreditsListSection
            // 
            pnCreditsListSection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnCreditsListSection.AutoSize = true;
            pnCreditsListSection.Controls.Add(pnCreditsListContainer);
            pnCreditsListSection.Controls.Add(lblCreditsHeading);
            pnCreditsListSection.Location = new Point(24, 712);
            pnCreditsListSection.Name = "pnCreditsListSection";
            pnCreditsListSection.Size = new Size(740, 335);
            pnCreditsListSection.TabIndex = 6;
            // 
            // pnCreditsListContainer
            // 
            pnCreditsListContainer.AutoSize = true;
            pnCreditsListContainer.Dock = DockStyle.Fill;
            pnCreditsListContainer.Location = new Point(0, 23);
            pnCreditsListContainer.Name = "pnCreditsListContainer";
            pnCreditsListContainer.Size = new Size(740, 312);
            pnCreditsListContainer.TabIndex = 1;
            // 
            // lblCreditsHeading
            // 
            lblCreditsHeading.Dock = DockStyle.Top;
            lblCreditsHeading.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCreditsHeading.ForeColor = Color.FromArgb(232, 230, 227);
            lblCreditsHeading.Location = new Point(0, 0);
            lblCreditsHeading.Name = "lblCreditsHeading";
            lblCreditsHeading.Size = new Size(740, 23);
            lblCreditsHeading.TabIndex = 0;
            lblCreditsHeading.Text = "Credits";
            // 
            // PersonDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 19, 22);
            Controls.Add(pnColumn2);
            Controls.Add(pnColumn1);
            Name = "PersonDetailsScreen";
            Size = new Size(1102, 1060);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            pnKnownForSection.ResumeLayout(false);
            pnColumn1.ResumeLayout(false);
            pnPersonalInfo.ResumeLayout(false);
            pnPersonalInfo.PerformLayout();
            pnBirthdaySection.ResumeLayout(false);
            pnPlaceOfBirthSection.ResumeLayout(false);
            pnGenderSection.ResumeLayout(false);
            pnKnownForRoleSection.ResumeLayout(false);
            pnColumn2.ResumeLayout(false);
            pnColumn2.PerformLayout();
            pnCreditsListSection.ResumeLayout(false);
            pnCreditsListSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picProfile;
        private Label lblName;
        private Label lblBiographyHeading;
        private TextBox txtBiography;
        private Panel pnKnownForSection;
        private Label lblKnownForHeading;
        private Panel pnMovieCards;
        private Panel pnColumn1;
        private Panel pnColumn2;
        private Panel pnPersonalInfo;
        private Label lblPersonalInfoHeading;
        private Panel pnBirthdaySection;
        private Label lblBirthdayHeading;
        private Panel pnPlaceOfBirthSection;
        private Label lblPlaceOfBirthHeading;
        private Panel pnGenderSection;
        private Label lblGenderHeading;
        private Panel pnKnownForRoleSection;
        private Label lblKnownForRole;
        private Label lblBirthday;
        private Label lblPlaceOfBirth;
        private Label lblGender;
        private Label lblExperise;
        private Panel pnCreditsListSection;
        private Label lblCreditsHeading;
        private Panel pnCreditsListContainer;
        private Button btnBack;
    }
}
