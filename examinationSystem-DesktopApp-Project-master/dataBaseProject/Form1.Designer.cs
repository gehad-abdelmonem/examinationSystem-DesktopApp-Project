namespace dataBaseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txb_id = new TextBox();
            txb_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txb_id
            // 
            txb_id.Location = new Point(697, 329);
            txb_id.Name = "txb_id";
            txb_id.Size = new Size(272, 27);
            txb_id.TabIndex = 0;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(697, 206);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(272, 27);
            txb_name.TabIndex = 1;
            txb_name.TextChanged += txb_name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(697, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(697, 298);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(144, 27, 32);
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(747, 431);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 70);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 584);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 584);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iti_logo;
            pictureBox2.Location = new Point(1063, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 113, 137);
            ClientSize = new Size(1188, 584);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_name);
            Controls.Add(txb_id);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 631);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_id;
        private TextBox txb_name;
        private Label label2;
        private Label label3;
        private Button btn_login;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}