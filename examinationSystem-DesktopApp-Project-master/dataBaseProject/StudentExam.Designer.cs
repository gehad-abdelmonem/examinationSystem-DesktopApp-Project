namespace dataBaseProject
{
    partial class StudentExam
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
            questionLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btn_next = new Button();
            btn_finish = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.BackColor = Color.FromArgb(224, 224, 224);
            questionLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            questionLabel.ForeColor = Color.FromArgb(144, 27, 32);
            questionLabel.Location = new Point(86, 34);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(79, 31);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(144, 27, 32);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(334, 207);
            button1.Name = "button1";
            button1.Size = new Size(280, 90);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(144, 27, 32);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(944, 207);
            button2.Name = "button2";
            button2.Size = new Size(280, 90);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(144, 27, 32);
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(334, 350);
            button3.Name = "button3";
            button3.Size = new Size(280, 90);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(144, 27, 32);
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(944, 350);
            button4.Name = "button4";
            button4.Size = new Size(280, 90);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Green;
            btn_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = SystemColors.ButtonHighlight;
            btn_next.Location = new Point(788, 516);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(100, 50);
            btn_next.TabIndex = 5;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // btn_finish
            // 
            btn_finish.BackColor = Color.Red;
            btn_finish.ForeColor = SystemColors.ButtonHighlight;
            btn_finish.Location = new Point(672, 516);
            btn_finish.Name = "btn_finish";
            btn_finish.Size = new Size(100, 50);
            btn_finish.TabIndex = 6;
            btn_finish.Text = "Finish";
            btn_finish.UseVisualStyleBackColor = false;
            btn_finish.Click += btn_finish_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(questionLabel);
            panel1.Location = new Point(334, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 103);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iti_logo;
            pictureBox1.Location = new Point(1388, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // StudentExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1512, 607);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btn_finish);
            Controls.Add(btn_next);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "StudentExam";
            Text = "StudentExam";
            Load += StudentExam_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label questionLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn_next;
        private Button btn_finish;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}