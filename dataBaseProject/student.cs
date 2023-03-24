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
    public partial class student : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
      public static string student_id="";
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            tbx_ssn.Text = Form1.SetValueForText1;
            student_id = Form1.SetValueForText1;
            dgv_studentInfo.Visible=false;
            label_name.Visible = false;
            label_dept.Visible = false;
            label5.Visible= false;
            label6.Visible = false;
            tbx_ssn.Visible=false;
        }

        private void tbx_ssn_TextChanged(object sender, EventArgs e)
        {

        }
        //Select(s=>new {s.Ssn,s.Fname,s.Lname,s.Dept.DeptName,s.Crs.})
        private void btn_showData_Click(object sender, EventArgs e)
        {
            var student = db.Users.Include(s => s.CrsNavigation).FirstOrDefault(s => s.Ssn == tbx_ssn.Text);

            User studnt_dept = db.Users.Include(s=>s.Dept).FirstOrDefault(s => s.Ssn == tbx_ssn.Text);                  
            dgv_studentInfo.DataSource = student.CrsNavigation.Select(c => new {c.CrsName,c.CrsDuration}).ToList();
            label_name.Text = studnt_dept.Fname + " " + studnt_dept.Lname;
            label_dept.Text = studnt_dept.Dept.DeptName;
            dgv_studentInfo.Visible = true;
            label_name.Visible = true;
            label_dept.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeginExam begin = new BeginExam();
            this.Hide();
            begin.Show();
            
        }
    }
}
