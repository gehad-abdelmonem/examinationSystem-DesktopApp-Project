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
            this.btn_showData = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.dgv_studentInfo = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_ssn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showData
            // 
            this.btn_showData.Location = new System.Drawing.Point(302, 114);
            this.btn_showData.Name = "btn_showData";
            this.btn_showData.Size = new System.Drawing.Size(94, 29);
            this.btn_showData.TabIndex = 0;
            this.btn_showData.Text = "ShowData";
            this.btn_showData.UseVisualStyleBackColor = true;
            this.btn_showData.Click += new System.EventHandler(this.btn_showData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // dgv_studentInfo
            // 
            this.dgv_studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentInfo.Location = new System.Drawing.Point(170, 250);
            this.dgv_studentInfo.Name = "dgv_studentInfo";
            this.dgv_studentInfo.RowHeadersWidth = 51;
            this.dgv_studentInfo.RowTemplate.Height = 29;
            this.dgv_studentInfo.Size = new System.Drawing.Size(338, 188);
            this.dgv_studentInfo.TabIndex = 6;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(212, 179);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 20);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "label5";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Location = new System.Drawing.Point(212, 215);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(50, 20);
            this.label_dept.TabIndex = 8;
            this.label_dept.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "BeginExam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_ssn
            // 
            this.tbx_ssn.Location = new System.Drawing.Point(73, 63);
            this.tbx_ssn.Name = "tbx_ssn";
            this.tbx_ssn.Size = new System.Drawing.Size(125, 27);
            this.tbx_ssn.TabIndex = 14;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_ssn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_dept);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dgv_studentInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showData);
            this.Name = "student";
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_showData;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private Label label2;
        private Label label3;
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
    }
}