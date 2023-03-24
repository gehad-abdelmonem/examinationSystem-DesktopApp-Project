namespace dataBaseProject
{
    partial class cources
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
            this.dgv_courses = new System.Windows.Forms.DataGridView();
            this.tbx_crsName = new System.Windows.Forms.TextBox();
            this.tbx_crsDuration = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_courses
            // 
            this.dgv_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courses.Location = new System.Drawing.Point(12, 268);
            this.dgv_courses.Name = "dgv_courses";
            this.dgv_courses.RowHeadersWidth = 51;
            this.dgv_courses.RowTemplate.Height = 29;
            this.dgv_courses.Size = new System.Drawing.Size(703, 326);
            this.dgv_courses.TabIndex = 0;
            this.dgv_courses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_courses_RowHeaderMouseDoubleClick);
            // 
            // tbx_crsName
            // 
            this.tbx_crsName.Location = new System.Drawing.Point(149, 31);
            this.tbx_crsName.Name = "tbx_crsName";
            this.tbx_crsName.Size = new System.Drawing.Size(125, 27);
            this.tbx_crsName.TabIndex = 2;
            // 
            // tbx_crsDuration
            // 
            this.tbx_crsDuration.Location = new System.Drawing.Point(149, 84);
            this.tbx_crsDuration.Name = "tbx_crsDuration";
            this.tbx_crsDuration.Size = new System.Drawing.Size(125, 27);
            this.tbx_crsDuration.TabIndex = 3;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(322, 31);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(94, 29);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crs_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crs_Duration";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(322, 82);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(322, 133);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 599);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tbx_crsDuration);
            this.Controls.Add(this.tbx_crsName);
            this.Controls.Add(this.dgv_courses);
            this.Name = "cources";
            this.Text = "cources";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cources_FormClosed);
            this.Load += new System.EventHandler(this.cources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_courses;
        private TextBox tbx_crsName;
        private TextBox tbx_crsDuration;
        private Button btn_insert;
        private Label label1;
        private Label label2;
        private Button btn_delete;
        private Button btn_update;
    }
}