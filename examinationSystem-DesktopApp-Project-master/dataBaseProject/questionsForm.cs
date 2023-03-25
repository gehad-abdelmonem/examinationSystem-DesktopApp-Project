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
    public partial class questionsForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public static int question_id;
        public static string question_type;
        public static string question_name;
        public questionsForm()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            tbx_mark.Clear();
            txb_body.Clear();

        }
        private void questionsForm_Load(object sender, EventArgs e)
        {
            var cours = db.Courses.ToList();
            List<string> types = new List<string>() { "TF", "MCQ" };
            List<string> modelAnswer = new List<string>() { "T", "F", "A", "B", "C", "D" };
            cbx_courses.DisplayMember = "CrsName";
            cbx_courses.ValueMember = "CrsId";
            cbx_courses.DataSource = cours;
            cbx_type.DataSource = types;
            comboBox1.DataSource = modelAnswer;
        }

        private void cbx_courses_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cbx_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var questions = db.Questions.Where(q => q.CrsId == (int)cbx_courses.SelectedValue)
                                        .Select(q => new { q.QuesId, q.CrsId, q.Body, q.ModelAnswer, q.Mark, q.Type })
                                        .ToList();
            dgv_question.DataSource = questions;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int last_id = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            var last_element = db.Questions.ToList().LastOrDefault();
            last_id = last_element.QuesId;
            last_id++;
            var body = txb_body.Text;
            var mark = int.Parse(tbx_mark.Text);
            var modelAnswer = comboBox1.Text;
            var type = cbx_type.Text;
            var courseId = (int)cbx_courses.SelectedValue;
            Question newQuestion = new Question()
            { QuesId = last_id, Body = body, Mark = mark, Type = type, ModelAnswer = modelAnswer, CrsId = courseId };
            db.Questions.Add(newQuestion);
            db.SaveChanges();
            var questions = db.Questions.Where(q => q.CrsId == courseId).Select(q => new { q.QuesId, q.CrsId, q.Body, q.ModelAnswer, q.Mark, q.Type }).ToList();
            dgv_question.DataSource = questions;
            clearData();

        }

        private void questionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            instractor ins = new instractor();
            ins.Show();
        }

        private void dgv_question_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            question_id = (int)dgv_question.SelectedRows[0].Cells[0].Value;
            question_type = dgv_question.SelectedRows[0].Cells[5].Value.ToString();
            question_name = dgv_question.SelectedRows[0].Cells[2].Value.ToString();
            Question_choices choices_form = new Question_choices();
            choices_form.Show();
            this.Hide();
        }
    }
}
