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
    public partial class cources : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public cources()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var crs_name = tbx_crsName.Text;
            var crs_duration=int.Parse(tbx_crsDuration.Text);
            id++;
            Course newCourse = new Course() {CrsId=id,CrsName=crs_name,CrsDuration=crs_duration};
            db.Courses.Add(newCourse);
            db.SaveChanges();
            dgv_courses.DataSource = db.Courses.Select(c => new {c.CrsId,c.CrsName,c.CrsDuration}).ToList();
        }

        int id = 0;
        private void cources_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.Select(c => new { c.CrsId,c.CrsName,c.CrsDuration}).ToList();
            dgv_courses.DataSource = courses;
            var last_element = courses.LastOrDefault();
            id = last_element.CrsId;
        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbx_crsName.Text = dgv_courses.SelectedRows[0].Cells[1].Value.ToString();
            tbx_crsDuration.Text = dgv_courses.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectd_id =(int)dgv_courses.SelectedRows[0].Cells[0].Value;
            Course selected_course = db.Courses.FirstOrDefault(c => c.CrsId == selectd_id);
            db.Courses.Remove(selected_course);
            db.SaveChanges();
            id--;
            dgv_courses.DataSource = db.Courses.Select(c => new { c.CrsId, c.CrsName, c.CrsDuration }).ToList();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectd_id = (int)dgv_courses.SelectedRows[0].Cells[0].Value;
            Course updated_data = db.Courses.FirstOrDefault(c=>c.CrsId==selectd_id);
            updated_data.CrsName=tbx_crsName.Text;
            updated_data.CrsDuration = int.Parse( tbx_crsDuration.Text);
            db.Courses.Update(updated_data);
            db.SaveChanges();
            dgv_courses.DataSource = db.Courses.Select(c => new { c.CrsId, c.CrsName, c.CrsDuration }).ToList();

        }

        private void cources_FormClosed(object sender, FormClosedEventArgs e)
        {
            instractor ins_form= new instractor();
            ins_form.Show();
            this.Hide();   
        }
    }
}
