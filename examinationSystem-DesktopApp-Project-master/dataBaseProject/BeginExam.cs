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
    public partial class BeginExam : Form
    {
        public static int exam_id;
        public BeginExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exam_id = int.Parse(txb_exam_id.Text);
            StudentExam exam = new StudentExam();
            this.Hide();
            exam.Show();

        }

        private void BeginExam_Load(object sender, EventArgs e)
        {

        }
    }
}
