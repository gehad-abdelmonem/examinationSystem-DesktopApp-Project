namespace dataBaseProject
{
    partial class admin
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
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_dept = new System.Windows.Forms.ComboBox();
            this.btn_inset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_depatmentDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(12, 290);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 29;
            this.dgv_user.Size = new System.Drawing.Size(873, 214);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_user_RowHeaderMouseDoubleClick);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(107, 56);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 23);
            this.txt_fname.TabIndex = 1;
            // 
            // txt_ssn
            // 
            this.txt_ssn.Location = new System.Drawing.Point(107, 18);
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.Size = new System.Drawing.Size(100, 23);
            this.txt_ssn.TabIndex = 2;
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(107, 197);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(100, 23);
            this.txt_role.TabIndex = 3;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(107, 160);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 23);
            this.txt_age.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(107, 126);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 23);
            this.txt_pass.TabIndex = 5;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(107, 90);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 23);
            this.txt_lname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ssn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department";
            // 
            // cbx_dept
            // 
            this.cbx_dept.FormattingEnabled = true;
            this.cbx_dept.Location = new System.Drawing.Point(107, 230);
            this.cbx_dept.Name = "cbx_dept";
            this.cbx_dept.Size = new System.Drawing.Size(121, 23);
            this.cbx_dept.TabIndex = 14;
            // 
            // btn_inset
            // 
            this.btn_inset.Location = new System.Drawing.Point(263, 79);
            this.btn_inset.Name = "btn_inset";
            this.btn_inset.Size = new System.Drawing.Size(75, 23);
            this.btn_inset.TabIndex = 15;
            this.btn_inset.Text = "Insert";
            this.btn_inset.UseVisualStyleBackColor = true;
            this.btn_inset.Click += new System.EventHandler(this.btn_inset_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(263, 123);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(263, 167);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_depatmentDetails
            // 
            this.btn_depatmentDetails.Location = new System.Drawing.Point(263, 225);
            this.btn_depatmentDetails.Name = "btn_depatmentDetails";
            this.btn_depatmentDetails.Size = new System.Drawing.Size(138, 23);
            this.btn_depatmentDetails.TabIndex = 18;
            this.btn_depatmentDetails.Text = "DepaetmentDetails";
            this.btn_depatmentDetails.UseVisualStyleBackColor = true;
            this.btn_depatmentDetails.Click += new System.EventHandler(this.btn_depatmentDetails_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 501);
            this.Controls.Add(this.btn_depatmentDetails);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_inset);
            this.Controls.Add(this.cbx_dept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_ssn);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.dgv_user);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_user;
        private TextBox txt_fname;
        private TextBox txt_ssn;
        private TextBox txt_role;
        private TextBox txt_age;
        private TextBox txt_pass;
        private TextBox txt_lname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbx_dept;
        private Button btn_inset;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_depatmentDetails;
    }
}