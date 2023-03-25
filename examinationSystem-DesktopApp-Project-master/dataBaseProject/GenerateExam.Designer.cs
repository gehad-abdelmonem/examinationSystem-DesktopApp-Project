namespace dataBaseProject
{
    partial class GenerateExam
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbx_course = new ComboBox();
            mcq_cb = new NumericUpDown();
            cb_mark = new NumericUpDown();
            cb_tf = new NumericUpDown();
            button1 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)mcq_cb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_mark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_tf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "ExamMark";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(55, 155);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 4;
            label2.Text = "#MCQ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(55, 232);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 5;
            label3.Text = "#TF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(144, 27, 32);
            label4.Location = new Point(32, 293);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 6;
            label4.Text = "Course_Name";
            // 
            // cbx_course
            // 
            cbx_course.FormattingEnabled = true;
            cbx_course.Location = new Point(221, 293);
            cbx_course.Name = "cbx_course";
            cbx_course.Size = new Size(151, 28);
            cbx_course.TabIndex = 7;
            cbx_course.SelectedIndexChanged += cbx_course_SelectedIndexChanged;
            // 
            // mcq_cb
            // 
            mcq_cb.Location = new Point(221, 155);
            mcq_cb.Name = "mcq_cb";
            mcq_cb.Size = new Size(150, 27);
            mcq_cb.TabIndex = 8;
            // 
            // cb_mark
            // 
            cb_mark.Location = new Point(224, 24);
            cb_mark.Name = "cb_mark";
            cb_mark.Size = new Size(150, 27);
            cb_mark.TabIndex = 9;
            // 
            // cb_tf
            // 
            cb_tf.Location = new Point(222, 225);
            cb_tf.Name = "cb_tf";
            cb_tf.Size = new Size(150, 27);
            cb_tf.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 27, 32);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(105, 414);
            button1.Name = "button1";
            button1.Size = new Size(210, 80);
            button1.TabIndex = 11;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 88);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 27, 32);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 530);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 54);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1063, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cb_mark);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(mcq_cb);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbx_course);
            panel2.Controls.Add(cb_tf);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(373, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 512);
            panel2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(144, 27, 32);
            label6.Location = new Point(32, 24);
            label6.Name = "label6";
            label6.Size = new Size(349, 58);
            label6.TabIndex = 16;
            label6.Text = "Generate Exam";
            // 
            // GenerateExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 584);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "GenerateExam";
            Text = "GenerateExam";
            Load += GenerateExam_Load;
            ((System.ComponentModel.ISupportInitialize)mcq_cb).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_mark).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_tf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbx_course;
        private NumericUpDown mcq_cb;
        private NumericUpDown cb_mark;
        private NumericUpDown cb_tf;
        private Button button1;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
    }
}