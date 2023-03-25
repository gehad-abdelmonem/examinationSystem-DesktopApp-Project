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
            dgv_user = new DataGridView();
            txt_fname = new TextBox();
            txt_ssn = new TextBox();
            txt_role = new TextBox();
            txt_age = new TextBox();
            txt_pass = new TextBox();
            txt_lname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbx_dept = new ComboBox();
            btn_inset = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_depatmentDetails = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_user).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_user
            // 
            dgv_user.BackgroundColor = Color.FromArgb(134, 159, 177);
            dgv_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_user.Location = new Point(860, 27);
            dgv_user.Name = "dgv_user";
            dgv_user.RowHeadersWidth = 51;
            dgv_user.RowTemplate.Height = 29;
            dgv_user.Size = new Size(648, 526);
            dgv_user.TabIndex = 0;
            dgv_user.RowHeaderMouseDoubleClick += dgv_user_RowHeaderMouseDoubleClick;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(147, 211);
            txt_fname.Margin = new Padding(3, 4, 3, 4);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(138, 27);
            txt_fname.TabIndex = 1;
            txt_fname.TextChanged += txt_fname_TextChanged;
            // 
            // txt_ssn
            // 
            txt_ssn.Location = new Point(147, 132);
            txt_ssn.Margin = new Padding(3, 4, 3, 4);
            txt_ssn.Name = "txt_ssn";
            txt_ssn.Size = new Size(138, 27);
            txt_ssn.TabIndex = 2;
            // 
            // txt_role
            // 
            txt_role.Location = new Point(562, 303);
            txt_role.Margin = new Padding(3, 4, 3, 4);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(138, 27);
            txt_role.TabIndex = 3;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(147, 296);
            txt_age.Margin = new Padding(3, 4, 3, 4);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(138, 27);
            txt_age.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(562, 139);
            txt_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(138, 27);
            txt_pass.TabIndex = 5;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(562, 216);
            txt_lname.Margin = new Padding(3, 4, 3, 4);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(138, 27);
            txt_lname.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(30, 135);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 7;
            label1.Text = "Ssn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(25, 207);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 8;
            label2.Text = "Fname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(440, 215);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 9;
            label3.Text = "Lname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(144, 27, 32);
            label4.Location = new Point(440, 139);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(144, 27, 32);
            label5.Location = new Point(25, 299);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 11;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(144, 27, 32);
            label6.Location = new Point(440, 302);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(144, 27, 32);
            label7.Location = new Point(13, 370);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 13;
            label7.Text = "Department";
            // 
            // cbx_dept
            // 
            cbx_dept.FormattingEnabled = true;
            cbx_dept.Location = new Point(147, 374);
            cbx_dept.Margin = new Padding(3, 4, 3, 4);
            cbx_dept.Name = "cbx_dept";
            cbx_dept.Size = new Size(138, 28);
            cbx_dept.TabIndex = 14;
            // 
            // btn_inset
            // 
            btn_inset.BackColor = Color.FromArgb(144, 27, 32);
            btn_inset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inset.ForeColor = Color.Snow;
            btn_inset.Location = new Point(3, 442);
            btn_inset.Margin = new Padding(3, 4, 3, 4);
            btn_inset.Name = "btn_inset";
            btn_inset.Size = new Size(205, 80);
            btn_inset.TabIndex = 15;
            btn_inset.Text = "Insert";
            btn_inset.UseVisualStyleBackColor = false;
            btn_inset.Click += btn_inset_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(144, 27, 32);
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(423, 442);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(205, 80);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(144, 27, 32);
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.Snow;
            btn_update.Location = new Point(212, 442);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(205, 80);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_depatmentDetails
            // 
            btn_depatmentDetails.BackColor = Color.FromArgb(144, 27, 32);
            btn_depatmentDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_depatmentDetails.ForeColor = SystemColors.ButtonHighlight;
            btn_depatmentDetails.Location = new Point(634, 442);
            btn_depatmentDetails.Margin = new Padding(3, 4, 3, 4);
            btn_depatmentDetails.Name = "btn_depatmentDetails";
            btn_depatmentDetails.Size = new Size(205, 80);
            btn_depatmentDetails.TabIndex = 18;
            btn_depatmentDetails.Text = "DepaetmentDetails";
            btn_depatmentDetails.UseVisualStyleBackColor = false;
            btn_depatmentDetails.Click += btn_depatmentDetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_depatmentDetails);
            panel1.Controls.Add(txt_ssn);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(txt_fname);
            panel1.Controls.Add(btn_inset);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbx_dept);
            panel1.Controls.Add(txt_lname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_role);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_age);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 526);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(311, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 113, 137);
            ClientSize = new Size(1512, 607);
            Controls.Add(panel1);
            Controls.Add(dgv_user);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_user).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}