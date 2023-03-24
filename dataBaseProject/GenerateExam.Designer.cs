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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_course = new System.Windows.Forms.ComboBox();
            this.mcq_cb = new System.Windows.Forms.NumericUpDown();
            this.cb_mark = new System.Windows.Forms.NumericUpDown();
            this.cb_tf = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mcq_cb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_tf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ExamMark";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "#MCQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "#TF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course_Name";
            // 
            // cbx_course
            // 
            this.cbx_course.FormattingEnabled = true;
            this.cbx_course.Location = new System.Drawing.Point(461, 15);
            this.cbx_course.Name = "cbx_course";
            this.cbx_course.Size = new System.Drawing.Size(151, 28);
            this.cbx_course.TabIndex = 7;
            this.cbx_course.SelectedIndexChanged += new System.EventHandler(this.cbx_course_SelectedIndexChanged);
            // 
            // mcq_cb
            // 
            this.mcq_cb.Location = new System.Drawing.Point(110, 62);
            this.mcq_cb.Name = "mcq_cb";
            this.mcq_cb.Size = new System.Drawing.Size(150, 27);
            this.mcq_cb.TabIndex = 8;
            // 
            // cb_mark
            // 
            this.cb_mark.Location = new System.Drawing.Point(110, 15);
            this.cb_mark.Name = "cb_mark";
            this.cb_mark.Size = new System.Drawing.Size(150, 27);
            this.cb_mark.TabIndex = 9;
            // 
            // cb_tf
            // 
            this.cb_tf.Location = new System.Drawing.Point(110, 105);
            this.cb_tf.Name = "cb_tf";
            this.cb_tf.Size = new System.Drawing.Size(150, 27);
            this.cb_tf.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            // 
            // GenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_tf);
            this.Controls.Add(this.cb_mark);
            this.Controls.Add(this.mcq_cb);
            this.Controls.Add(this.cbx_course);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenerateExam";
            this.Text = "GenerateExam";
            this.Load += new System.EventHandler(this.GenerateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mcq_cb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_tf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}