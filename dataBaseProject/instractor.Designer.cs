namespace dataBaseProject
{
    partial class instractor
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
            this.btn_courses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_courses
            // 
            this.btn_courses.Location = new System.Drawing.Point(380, 115);
            this.btn_courses.Name = "btn_courses";
            this.btn_courses.Size = new System.Drawing.Size(94, 29);
            this.btn_courses.TabIndex = 0;
            this.btn_courses.Text = "Courses";
            this.btn_courses.UseVisualStyleBackColor = true;
            this.btn_courses.Click += new System.EventHandler(this.btn_courses_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "GnerateQueations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "GenerateExam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // instractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_courses);
            this.Name = "instractor";
            this.Text = "instractor";
            this.Load += new System.EventHandler(this.instractor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_courses;
        private Button button1;
        private Button button2;
    }
}