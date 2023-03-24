using dataBaseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBaseProject
{
    public partial class Question_choices : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public Question_choices()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void Question_choices_Load(object sender, EventArgs e)
        {
            label_body.Text = questionsForm.question_name;
            label_id.Text=questionsForm.question_id.ToString();
            label_type.Text = questionsForm.question_type;
            

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }
        int count = 1;
        private void btn_insert_Click(object sender, EventArgs e)
        {
            var type = label_type.Text;
            try
            {
                if (type == "TF" && count <= 2)
                {
                    var question_id = int.Parse(label_id.Text);
                    var queschoice = tbx_choices.Text;
                    QuesChoice choices = new QuesChoice() { QuesId = question_id, QuesChoice1 = queschoice };
                    db.QuesChoices.Add(choices);
                    db.SaveChanges();
                    tbx_choices.Clear();
                    count++;
                }
                else if (type == "MCQ" && count <= 4)
                {
                    var question_id = int.Parse(label_id.Text);
                    var queschoice = tbx_choices.Text;
                    QuesChoice choices = new QuesChoice() { QuesId = question_id, QuesChoice1 = queschoice };
                    db.QuesChoices.Add(choices);
                    db.SaveChanges();
                    tbx_choices.Clear();
                    count++;

                }
                else
                {
                    this.Close();
                    questionsForm form = new questionsForm();
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("This Question Already Has Anwers", null, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                this.Hide();
                questionsForm form = new questionsForm();
                form.Show();
            }

           if((type=="TF"&&count==3)||(type=="MCQ"&&count==5))
            {
                this.ControlBox = true;
            }


        }

        private void Question_choices_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            questionsForm form = new questionsForm();
            form.Show();

        }

        private void Question_choices_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
