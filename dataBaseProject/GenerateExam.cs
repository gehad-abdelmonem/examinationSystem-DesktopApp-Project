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
    public partial class GenerateExam : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public GenerateExam()
        {
            InitializeComponent();
        }

        private void cbx_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void GenerateExam_Load(object sender, EventArgs e)
        {
            List<Course> cources = db.Courses.ToList();
            cbx_course.DataSource= cources;
            cbx_course.DisplayMember = "CrsName";
            cbx_course.ValueMember = "CrsId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark =(int)cb_mark.Value;
            int tf=(int)cb_tf.Value;
            int mcq =(int) mcq_cb.Value;
            var course_id =(int)cbx_course.SelectedValue;
            db.Database.ExecuteSql($"GenerateExam { mark},{course_id},{mcq},{tf}");
            db.SaveChanges();

        }
    }
}
