namespace dataBaseProject
{
    partial class department
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
            this.dgv_dept = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_inset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dept
            // 
            this.dgv_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dept.Location = new System.Drawing.Point(141, 337);
            this.dgv_dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_dept.Name = "dgv_dept";
            this.dgv_dept.RowHeadersWidth = 51;
            this.dgv_dept.RowTemplate.Height = 25;
            this.dgv_dept.Size = new System.Drawing.Size(387, 259);
            this.dgv_dept.TabIndex = 0;
            this.dgv_dept.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dept_RowHeaderMouseClick);
            this.dgv_dept.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dept_RowHeaderMouseDoubleClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(414, 68);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(114, 27);
            this.txt_name.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(168, 68);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(114, 27);
            this.txt_id.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(122, 75);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 20);
            this.id.TabIndex = 3;
            this.id.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_inset
            // 
            this.btn_inset.Location = new System.Drawing.Point(271, 137);
            this.btn_inset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_inset.Name = "btn_inset";
            this.btn_inset.Size = new System.Drawing.Size(86, 31);
            this.btn_inset.TabIndex = 5;
            this.btn_inset.Text = "Insert";
            this.btn_inset.UseVisualStyleBackColor = true;
            this.btn_inset.Click += new System.EventHandler(this.btn_inset_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(271, 200);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 31);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(271, 256);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 31);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 600);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_inset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_dept);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "department";
            this.Text = "department";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.department_FormClosed);
            this.Load += new System.EventHandler(this.department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_dept;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label id;
        private Label label2;
        private Button btn_inset;
        private Button btn_delete;
        private Button btn_update;
    }
}