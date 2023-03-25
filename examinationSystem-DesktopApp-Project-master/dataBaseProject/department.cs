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
    public partial class department : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public department()
        {
            InitializeComponent();
        }
        public void clear_data()
        {
            txt_id.Clear();
            txt_name.Clear();
        }
        private void department_Load(object sender, EventArgs e)
        {
            dgv_dept.DataSource = db.Departments.Select(d => new { d.DeptId, d.DeptName }).ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btn_inset_Click(object sender, EventArgs e)
        {
            Department dept = new Department() { DeptId = int.Parse(txt_id.Text), DeptName = txt_name.Text };
            db.Departments.Add(dept);
            db.SaveChanges();
            dgv_dept.DataSource = db.Departments.FromSqlInterpolated($"SelectDepartment").ToList();
            clear_data();
        }

        private void dgv_dept_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id = (int)dgv_dept.SelectedRows[0].Cells[0].Value;
            var selected_department = db.Departments.Where(d => d.DeptId == id).FirstOrDefault();
            db.Departments.Remove(selected_department);
            db.SaveChanges();
            dgv_dept.DataSource = db.Departments.Select(d => new { d.DeptId, d.DeptName }).ToList();
            clear_data();

        }

        private void dgv_dept_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_name.Text = dgv_dept.SelectedRows[0].Cells[1].Value.ToString();


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var id = (int)dgv_dept.SelectedRows[0].Cells[0].Value;
            Department dept = db.Departments.Where(d => d.DeptId == id).FirstOrDefault();
            dept.DeptName = txt_name.Text;
            db.Departments.Update(dept);
            db.SaveChanges();
            dgv_dept.DataSource = db.Departments.Select(d => new { d.DeptId, d.DeptName }).ToList();
            clear_data();
        }

        private void department_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin admin_form = new admin();
            admin_form.Show();
        }

        private void dgv_dept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
