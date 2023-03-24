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
            this.label_body = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_choices = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_body
            // 
            this.label_body.AutoSize = true;
            this.label_body.Location = new System.Drawing.Point(193, 87);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(50, 20);
            this.label_body.TabIndex = 0;
            this.label_body.Text = "label1";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(102, 87);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(50, 20);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "label2";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(572, 87);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(50, 20);
            this.label_type.TabIndex = 2;
            this.label_type.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "QuestionBody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "QuestionId";
            // 
            // tbx_choices
            // 
            this.tbx_choices.Location = new System.Drawing.Point(301, 204);
            this.tbx_choices.Name = "tbx_choices";
            this.tbx_choices.Size = new System.Drawing.Size(125, 27);
            this.tbx_choices.TabIndex = 6;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(319, 255);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(94, 29);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Add";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choices";
            // 
            // Question_choices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tbx_choices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_body);
            this.Name = "Question_choices";
            this.Text = "Question_choices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Question_choices_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Question_choices_FormClosed);
            this.Load += new System.EventHandler(this.Question_choices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}