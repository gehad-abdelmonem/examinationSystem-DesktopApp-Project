namespace dataBaseProject
{
    partial class instractor
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
            btn_courses = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_courses
            // 
            btn_courses.BackColor = Color.FromArgb(144, 27, 32);
            btn_courses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_courses.ForeColor = Color.FromArgb(224, 224, 224);
            btn_courses.Location = new Point(555, 190);
            btn_courses.Name = "btn_courses";
            btn_courses.Size = new Size(220, 80);
            btn_courses.TabIndex = 0;
            btn_courses.Text = "Courses";
            btn_courses.UseVisualStyleBackColor = false;
            btn_courses.Click += btn_courses_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 27, 32);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(555, 282);
            button1.Name = "button1";
            button1.Size = new Size(220, 80);
            button1.TabIndex = 1;
            button1.Text = "GnerateQueations";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(144, 27, 32);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(555, 383);
            button2.Name = "button2";
            button2.Size = new Size(220, 80);
            button2.TabIndex = 2;
            button2.Text = "GenerateExam";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1063, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 27, 32);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.FromArgb(144, 27, 32);
            panel1.Location = new Point(0, 534);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 50);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(402, 52);
            label1.Name = "label1";
            label1.Size = new Size(373, 58);
            label1.TabIndex = 5;
            label1.Text = "Instructor Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(412, 387);
            label2.Name = "label2";
            label2.Size = new Size(55, 58);
            label2.TabIndex = 6;
            label2.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(423, 190);
            label3.Name = "label3";
            label3.Size = new Size(44, 58);
            label3.TabIndex = 7;
            label3.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(144, 27, 32);
            label4.Location = new Point(412, 286);
            label4.Name = "label4";
            label4.Size = new Size(55, 58);
            label4.TabIndex = 8;
            label4.Text = "2";
            // 
            // instractor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 584);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_courses);
            Name = "instractor";
            Text = "instractor";
            Load += instractor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_courses;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}