namespace dataBaseProject
{
    partial class BeginExam
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
            label1 = new Label();
            txb_exam_id = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(144, 27, 32);
            label1.Location = new Point(45, 27);
            label1.Name = "label1";
            label1.Size = new Size(295, 58);
            label1.TabIndex = 0;
            label1.Text = "EnterExamId";
            // 
            // txb_exam_id
            // 
            txb_exam_id.Location = new Point(144, 188);
            txb_exam_id.Name = "txb_exam_id";
            txb_exam_id.Size = new Size(100, 27);
            txb_exam_id.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 27, 32);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(698, 220);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 2;
            button1.Text = "Begin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1062, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 27, 32);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 529);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 55);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txb_exam_id);
            panel2.Location = new Point(148, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 328);
            panel2.TabIndex = 5;
            // 
            // BeginExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1188, 584);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "BeginExam";
            Text = "BeginExam";
            Load += BeginExam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txb_exam_id;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}