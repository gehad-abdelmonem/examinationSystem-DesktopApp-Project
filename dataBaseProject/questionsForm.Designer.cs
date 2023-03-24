namespace dataBaseProject
{
    partial class questionsForm
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
            this.cbx_courses = new System.Windows.Forms.ComboBox();
            this.dgv_question = new System.Windows.Forms.DataGridView();
            this.tbx_mark = new System.Windows.Forms.TextBox();
            this.txb_body = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_question)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_courses
            // 
            this.cbx_courses.FormattingEnabled = true;
            this.cbx_courses.Location = new System.Drawing.Point(520, 55);
            this.cbx_courses.Name = "cbx_courses";
            this.cbx_courses.Size = new System.Drawing.Size(151, 28);
            this.cbx_courses.TabIndex = 0;
            this.cbx_courses.SelectedIndexChanged += new System.EventHandler(this.cbx_courses_SelectedIndexChanged);
            this.cbx_courses.SelectedValueChanged += new System.EventHandler(this.cbx_courses_SelectedValueChanged);
            // 
            // dgv_question
            // 
            this.dgv_question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_question.Location = new System.Drawing.Point(86, 264);
            this.dgv_question.Name = "dgv_question";
            this.dgv_question.RowHeadersWidth = 51;
            this.dgv_question.RowTemplate.Height = 29;
            this.dgv_question.Size = new System.Drawing.Size(857, 308);
            this.dgv_question.TabIndex = 1;
            this.dgv_question.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_question_MouseDoubleClick);
            // 
            // tbx_mark
            // 
            this.tbx_mark.Location = new System.Drawing.Point(183, 54);
            this.tbx_mark.Name = "tbx_mark";
            this.tbx_mark.Size = new System.Drawing.Size(125, 27);
            this.tbx_mark.TabIndex = 5;
            // 
            // txb_body
            // 
            this.txb_body.Location = new System.Drawing.Point(183, 16);
            this.txb_body.Name = "txb_body";
            this.txb_body.Size = new System.Drawing.Size(125, 27);
            this.txb_body.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CourseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ModelAnswer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 13;
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(520, 115);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(151, 28);
            this.cbx_type.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "QuestionType";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(568, 170);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // questionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 584);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_body);
            this.Controls.Add(this.tbx_mark);
            this.Controls.Add(this.dgv_question);
            this.Controls.Add(this.cbx_courses);
            this.Name = "questionsForm";
            this.Text = "questionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.questionsForm_FormClosed);
            this.Load += new System.EventHandler(this.questionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbx_courses;
        private DataGridView dgv_question;
        private TextBox tbx_mark;
        private TextBox txb_body;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbx_type;
        private Label label7;
        private Button btn_add;
        private ComboBox comboBox1;
    }
}