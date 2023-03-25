using dataBaseProject.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class StudentExam : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();

        List<Question> questionList = new List<Question>();
        int count = 0;
        public StudentExam()
        {
            InitializeComponent();
        }

        List<Button> buttons;

        public void GetQuestions()
        {
            int inc = 0;
            if (count < questionList.Count)
            {
                questionLabel.Text = questionList[count].Body;
                if (questionList[count].QuesChoices.Count == 2)
                {

                    button3.Visible = false;
                    button4.Visible = false;
                    foreach (var item in questionList[count].QuesChoices)
                    {
                        buttons[inc].Text = item.QuesChoice1;
                        inc++;
                    }
                }
                else
                {
                    button3.Visible = true;
                    button4.Visible = true;
                    foreach (var item in questionList[count].QuesChoices)
                    {
                        buttons[inc].Text = item.QuesChoice1;
                        inc++;
                    }
                }
                count++;
            }
            else
            {
                btn_next.Visible = false;
            }
        }
        int exam_grade;
        private void StudentExam_Load(object sender, EventArgs e)
        {
            int examid = BeginExam.exam_id;

            var exam = db.Exams
                                   .Include(e => e.Ques).ThenInclude(q => q.QuesChoices)
                                   .FirstOrDefault(e => e.ExamId == examid);
            exam_grade = exam.Grade;

            questionList = exam.Ques.ToList();
            buttons = new List<Button>() { button1, button2, button3, button4 };
            GetQuestions();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            GetQuestions();
        }

        int markk = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (questionList[count - 1].ModelAnswer.ToLower() == button1.Text)
            {
                markk = markk + questionList[count - 1].Mark;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (questionList[count - 1].ModelAnswer.ToLower() == button2.Text)
            {
                markk = markk + questionList[count - 1].Mark;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (questionList[count - 1].ModelAnswer.ToLower() == button3.Text)
            {
                markk = markk + questionList[count - 1].Mark;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (questionList[count - 1].ModelAnswer.ToLower() == button4.Text)
            {
                markk = markk + questionList[count - 1].Mark;
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            StdExam std;
            if (markk >= exam_grade / 2)
            {
                std = new StdExam()
                { StdId = student.student_id, ExamId = BeginExam.exam_id, FinalMark = markk, Passed = true };
                MessageBox.Show($"Congratulation you passed in exam \n your mark ={markk.ToString()}");
                this.Close();

            }
            else
            {
                std = new StdExam()
                { StdId = student.student_id, ExamId = BeginExam.exam_id, FinalMark = markk, Passed = false };
                MessageBox.Show($"Sorry you failed in exam \n your mark ={markk.ToString()}");
                this.Close();
            }
            db.StdExams.Add(std);
            db.SaveChanges();

        }
    }
}
