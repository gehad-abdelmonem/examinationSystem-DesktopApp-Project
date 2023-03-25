namespace dataBaseProject
{
    partial class student
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
            btn_showData = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label4 = new Label();
            sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dgv_studentInfo = new DataGridView();
            label_name = new Label();
            label_dept = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            tbx_ssn = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_studentInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_showData
            // 
            btn_showData.BackColor = Color.FromArgb(144, 27, 32);
            btn_showData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_showData.ForeColor = SystemColors.ButtonHighlight;
            btn_showData.Location = new Point(830, 357);
            btn_showData.Name = "btn_showData";
            btn_showData.Size = new Size(220, 80);
            btn_showData.TabIndex = 0;
            btn_showData.Text = "ShowData";
            btn_showData.UseVisualStyleBackColor = false;
            btn_showData.Click += btn_showData_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 289);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // dgv_studentInfo
            // 
            dgv_studentInfo.BackgroundColor = Color.FromArgb(134, 159, 177);
            dgv_studentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentInfo.Location = new Point(1101, 329);
            dgv_studentInfo.Name = "dgv_studentInfo";
            dgv_studentInfo.RowHeadersWidth = 51;
            dgv_studentInfo.RowTemplate.Height = 29;
            dgv_studentInfo.Size = new Size(352, 169);
            dgv_studentInfo.TabIndex = 6;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_name.Location = new Point(288, 203);
            label_name.Name = "label_name";
            label_name.Size = new Size(70, 28);
            label_name.TabIndex = 7;
            label_name.Text = "label5";
            // 
            // label_dept
            // 
            label_dept.AutoSize = true;
            label_dept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_dept.Location = new Point(288, 280);
            label_dept.Name = "label_dept";
            label_dept.Size = new Size(70, 28);
            label_dept.TabIndex = 8;
            label_dept.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(144, 27, 32);
            label5.Location = new Point(95, 280);
            label5.Name = "label5";
            label5.Size = new Size(150, 31);
            label5.TabIndex = 9;
            label5.Text = "Department:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(144, 27, 32);
            label6.Location = new Point(132, 201);
            label6.Name = "label6";
            label6.Size = new Size(83, 31);
            label6.TabIndex = 10;
            label6.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 66);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 27, 32);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(830, 184);
            button1.Name = "button1";
            button1.Size = new Size(220, 80);
            button1.TabIndex = 13;
            button1.Text = "BeginExam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbx_ssn
            // 
            tbx_ssn.Location = new Point(839, 76);
            tbx_ssn.Name = "tbx_ssn";
            tbx_ssn.Size = new Size(125, 27);
            tbx_ssn.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1388, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(144, 27, 32);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.FromArgb(144, 27, 32);
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(1512, 52);
            panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(220, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label_name);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label_dept);
            panel3.Location = new Point(46, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 492);
            panel3.TabIndex = 18;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 113, 137);
            ClientSize = new Size(1512, 607);
            Controls.Add(tbx_ssn);
            Controls.Add(dgv_studentInfo);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(btn_showData);
            Name = "student";
            Text = "student";
            Load += student_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_studentInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_showData;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private DataGridView dgv_studentInfo;
        private Label label_name;
        private Label label_dept;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox tbx_ssn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
    }
}