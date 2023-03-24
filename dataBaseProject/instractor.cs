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
    public partial class instractor : Form
    {
        public instractor()
        {
            InitializeComponent();
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            cources courses_form = new cources();
            courses_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionsForm questions_form = new questionsForm();
            questions_form.Show();
            this.Hide();
        }

        private void instractor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateExam newExam= new GenerateExam();
            newExam.Show();
        }
    }
}
;