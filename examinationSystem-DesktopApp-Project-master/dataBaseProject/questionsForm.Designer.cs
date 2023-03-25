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
            cbx_courses = new ComboBox();
            dgv_question = new DataGridView();
            tbx_mark = new TextBox();
            txb_body = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbx_type = new ComboBox();
            label7 = new Label();
            btn_add = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_question).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbx_courses
            // 
            cbx_courses.FormattingEnabled = true;
            cbx_courses.Location = new Point(610, 246);
            cbx_courses.Name = "cbx_courses";
            cbx_courses.Size = new Size(151, 28);
            cbx_courses.TabIndex = 0;
            cbx_courses.SelectedIndexChanged += cbx_courses_SelectedIndexChanged;
            cbx_courses.SelectedValueChanged += cbx_courses_SelectedValueChanged;
            // 
            // dgv_question
            // 
            dgv_question.BackgroundColor = Color.FromArgb(134, 159, 177);
            dgv_question.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_question.Location = new Point(863, 26);
            dgv_question.Name = "dgv_question";
            dgv_question.RowHeadersWidth = 51;
            dgv_question.RowTemplate.Height = 29;
            dgv_question.Size = new Size(648, 526);
            dgv_question.TabIndex = 1;
            dgv_question.MouseDoubleClick += dgv_question_MouseDoubleClick;
            // 
            // tbx_mark
            // 
            tbx_mark.Location = new Point(256, 245);
            tbx_mark.Name = "tbx_mark";
            tbx_mark.Size = new Size(125, 27);
            tbx_mark.TabIndex = 5;
            // 
            // txb_body
            // 
            txb_body.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txb_body.Location = new Point(256, 179);
            txb_body.Name = "txb_body";
            txb_body.Size = new Size(125, 34);
            txb_body.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(449, 248);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 7;
            label1.Text = "CourseName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(94, 246);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 9;
            label3.Text = "Mark";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(144, 27, 32);
            label4.Location = new Point(85, 331);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 10;
            label4.Text = "ModelAnswer";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(144, 27, 32);
            label5.Location = new Point(95, 182);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 11;
            label5.Text = "Body";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 466);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 13;
            // 
            // cbx_type
            // 
            cbx_type.FormattingEnabled = true;
            cbx_type.Location = new Point(610, 342);
            cbx_type.Name = "cbx_type";
            cbx_type.Size = new Size(151, 28);
            cbx_type.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(144, 27, 32);
            label7.Location = new Point(449, 338);
            label7.Name = "label7";
            label7.Size = new Size(142, 28);
            label7.TabIndex = 15;
            label7.Text = "QuestionType";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(144, 27, 32);
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ButtonFace;
            btn_add.Location = new Point(306, 422);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(210, 80);
            btn_add.TabIndex = 16;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(cbx_courses);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(tbx_mark);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txb_body);
            panel1.Controls.Add(cbx_type);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 526);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(345, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // questionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 113, 137);
            ClientSize = new Size(1512, 607);
            Controls.Add(panel1);
            Controls.Add(dgv_question);
            Name = "questionsForm";
            Text = "questionsForm";
            FormClosed += questionsForm_FormClosed;
            Load += questionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_question).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}