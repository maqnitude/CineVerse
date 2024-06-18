namespace CineVerse.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 22, 26);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 48);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 40, 47);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 663);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 85, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.FromArgb(170, 187, 204);
            button1.Location = new Point(86, 8);
            button1.Margin = new Padding(8, 8, 4, 8);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += this.button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 157, 26);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1055, 8);
            button5.Margin = new Padding(8);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 0;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = false;
            button5.Click += this.button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(68, 85, 102);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(761, 13);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 25);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(68, 85, 102);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.FromArgb(170, 187, 204);
            button2.Location = new Point(186, 8);
            button2.Margin = new Padding(0, 8, 4, 8);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 0;
            button2.Text = "Movies";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(68, 85, 102);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.FromArgb(170, 187, 204);
            button3.Location = new Point(286, 8);
            button3.Margin = new Padding(0, 8, 4, 8);
            button3.Name = "button3";
            button3.Size = new Size(96, 32);
            button3.TabIndex = 0;
            button3.Text = "Lists";
            button3.UseVisualStyleBackColor = false;
            button3.Click += this.button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(68, 85, 102);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = Color.FromArgb(170, 187, 204);
            button4.Location = new Point(386, 8);
            button4.Margin = new Padding(0, 8, 4, 8);
            button4.Name = "button4";
            button4.Size = new Size(96, 32);
            button4.TabIndex = 0;
            button4.Text = "Members";
            button4.UseVisualStyleBackColor = false;
            button4.Click += this.button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 711);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button5;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}