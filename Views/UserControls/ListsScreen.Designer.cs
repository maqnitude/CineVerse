namespace CineVerse.Views.UserControls
{
    partial class ListsScreen
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
            pnlListsContainer = new Panel();
            btnAddList = new Button();
            SuspendLayout();
            // 
            // pnlListsContainer
            // 
            pnlListsContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListsContainer.Location = new Point(128, 64);
            pnlListsContainer.Margin = new Padding(128, 64, 128, 64);
            pnlListsContainer.Name = "pnlListsContainer";
            pnlListsContainer.Size = new Size(810, 582);
            pnlListsContainer.TabIndex = 0;
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(128, 37);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(75, 23);
            btnAddList.TabIndex = 1;
            btnAddList.Text = "Add list";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += btnAddList_Click;
            // 
            // ListsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 40, 47);
            Controls.Add(btnAddList);
            Controls.Add(pnlListsContainer);
            Name = "ListsScreen";
            Size = new Size(1066, 710);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlListsContainer;
        private Button btnAddList;
    }
}
