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
            dgv_courses = new DataGridView();
            tbx_crsName = new TextBox();
            tbx_crsDuration = new TextBox();
            btn_insert = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.BackgroundColor = Color.FromArgb(134, 159, 177);
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(775, 20);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.RowTemplate.Height = 29;
            dgv_courses.Size = new Size(733, 526);
            dgv_courses.TabIndex = 0;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // tbx_crsName
            // 
            tbx_crsName.Location = new Point(404, 163);
            tbx_crsName.Name = "tbx_crsName";
            tbx_crsName.Size = new Size(150, 27);
            tbx_crsName.TabIndex = 2;
            // 
            // tbx_crsDuration
            // 
            tbx_crsDuration.Location = new Point(404, 238);
            tbx_crsDuration.Name = "tbx_crsDuration";
            tbx_crsDuration.Size = new Size(150, 27);
            tbx_crsDuration.TabIndex = 3;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(144, 27, 32);
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.ForeColor = SystemColors.ButtonHighlight;
            btn_insert.Location = new Point(140, 401);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(150, 70);
            btn_insert.TabIndex = 4;
            btn_insert.Text = "insert";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(211, 159);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 5;
            label1.Text = "Crs_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(211, 237);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 6;
            label2.Text = "Crs_Duration";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(144, 27, 32);
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(339, 401);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 70);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(144, 27, 32);
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(533, 401);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 70);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(tbx_crsName);
            panel1.Controls.Add(btn_insert);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbx_crsDuration);
            panel1.Location = new Point(0, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 526);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(294, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(144, 27, 32);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 544);
            panel2.Name = "panel2";
            panel2.Size = new Size(1512, 63);
            panel2.TabIndex = 10;
            // 
            // cources
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 113, 137);
            ClientSize = new Size(1512, 607);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgv_courses);
            Name = "cources";
            Text = "cources";
            FormClosed += cources_FormClosed;
            Load += cources_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}