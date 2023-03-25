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
            dgv_dept = new DataGridView();
            txt_name = new TextBox();
            txt_id = new TextBox();
            id = new Label();
            label2 = new Label();
            btn_inset = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_dept).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_dept
            // 
            dgv_dept.BackgroundColor = Color.FromArgb(134, 159, 177);
            dgv_dept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dept.Location = new Point(779, 1);
            dgv_dept.Margin = new Padding(3, 4, 3, 4);
            dgv_dept.Name = "dgv_dept";
            dgv_dept.RowHeadersWidth = 51;
            dgv_dept.RowTemplate.Height = 25;
            dgv_dept.Size = new Size(733, 526);
            dgv_dept.TabIndex = 0;
            dgv_dept.CellContentClick += dgv_dept_CellContentClick;
            dgv_dept.RowHeaderMouseClick += dgv_dept_RowHeaderMouseClick;
            dgv_dept.RowHeaderMouseDoubleClick += dgv_dept_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(376, 234);
            txt_name.Margin = new Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(114, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(376, 158);
            txt_id.Margin = new Padding(3, 4, 3, 4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(114, 27);
            txt_id.TabIndex = 2;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            id.ForeColor = Color.FromArgb(144, 27, 32);
            id.Location = new Point(250, 161);
            id.Name = "id";
            id.Size = new Size(38, 31);
            id.TabIndex = 3;
            id.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(240, 234);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 4;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // btn_inset
            // 
            btn_inset.BackColor = Color.FromArgb(144, 27, 32);
            btn_inset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inset.ForeColor = SystemColors.Control;
            btn_inset.Location = new Point(133, 380);
            btn_inset.Margin = new Padding(3, 4, 3, 4);
            btn_inset.Name = "btn_inset";
            btn_inset.Size = new Size(150, 70);
            btn_inset.TabIndex = 5;
            btn_inset.Text = "Insert";
            btn_inset.UseVisualStyleBackColor = false;
            btn_inset.Click += btn_inset_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(144, 27, 32);
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(325, 380);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 70);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(144, 27, 32);
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = SystemColors.ControlLight;
            btn_update.Location = new Point(512, 380);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 70);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(id);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_inset);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 526);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(286, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(144, 27, 32);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 526);
            panel2.Name = "panel2";
            panel2.Size = new Size(1512, 81);
            panel2.TabIndex = 9;
            // 
            // department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 607);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgv_dept);
            Margin = new Padding(3, 4, 3, 4);
            Name = "department";
            Text = "department";
            FormClosed += department_FormClosed;
            Load += department_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_dept).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}