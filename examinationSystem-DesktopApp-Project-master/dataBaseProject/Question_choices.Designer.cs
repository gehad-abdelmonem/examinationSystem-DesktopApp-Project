namespace dataBaseProject
{
    partial class Question_choices
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
            label_body = new Label();
            label_id = new Label();
            label_type = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbx_choices = new TextBox();
            btn_insert = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label_body
            // 
            label_body.AutoSize = true;
            label_body.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_body.Location = new Point(227, 105);
            label_body.Name = "label_body";
            label_body.Size = new Size(70, 28);
            label_body.TabIndex = 0;
            label_body.Text = "label1";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_id.Location = new Point(49, 105);
            label_id.Name = "label_id";
            label_id.Size = new Size(70, 28);
            label_id.TabIndex = 1;
            label_id.Text = "label2";
            label_id.Click += label_id_Click;
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_type.Location = new Point(767, 93);
            label_type.Name = "label_type";
            label_type.Size = new Size(70, 28);
            label_type.TabIndex = 2;
            label_type.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(767, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 29);
            label1.TabIndex = 3;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(144, 27, 32);
            label2.Location = new Point(211, 14);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 4;
            label2.Text = "QuestionBody";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(144, 27, 32);
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 5;
            label3.Text = "QuestionId";
            // 
            // tbx_choices
            // 
            tbx_choices.Location = new Point(109, 45);
            tbx_choices.Name = "tbx_choices";
            tbx_choices.Size = new Size(125, 27);
            tbx_choices.TabIndex = 6;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(144, 27, 32);
            btn_insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.ForeColor = SystemColors.ButtonHighlight;
            btn_insert.Location = new Point(24, 137);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(210, 70);
            btn_insert.TabIndex = 7;
            btn_insert.Text = "Add";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(144, 27, 32);
            label4.Location = new Point(15, 41);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 8;
            label4.Text = "Choices";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1063, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 27, 32);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 543);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 41);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label_id);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label_body);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label_type);
            panel2.Location = new Point(154, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 157);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(tbx_choices);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btn_insert);
            panel3.Location = new Point(466, 327);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 210);
            panel3.TabIndex = 12;
            // 
            // Question_choices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1188, 584);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Question_choices";
            Text = "Question_choices";
            FormClosing += Question_choices_FormClosing;
            FormClosed += Question_choices_FormClosed;
            Load += Question_choices_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_body;
        private Label label_id;
        private Label label_type;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbx_choices;
        private Button btn_insert;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}