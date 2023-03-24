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
    
    public partial class admin : Form
    {
        private ExaminationSystemContext db = new ExaminationSystemContext();
        public admin()
        {
            InitializeComponent();
        }
        public void clear_input()
        {
            txt_ssn.Clear();
            txt_age.Clear();
            txt_fname.Clear();
            txt_lname.Clear();  
            txt_pass.Clear();
            txt_role.Clear();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            var user = db.Users.Select(u => new { u.Ssn, u.Fname, u.Lname, u.Password, u.Age, u.Role, u.DeptId });
            dgv_user.DataSource = user.ToList();
            cbx_dept.DataSource = db.Departments.ToList();
            cbx_dept.DisplayMember= "DeptName"; 
            cbx_dept.ValueMember= "DeptId";
        }

        private void btn_inset_Click(object sender, EventArgs e)
        {
            var ssn = txt_ssn.Text;
            var fname = txt_fname.Text;
            var lname = txt_lname.Text;
            var passwod = txt_pass.Text;
            var age = int.Parse(txt_age.Text);  
            var role = txt_role.Text;
            var dept_id =(int) cbx_dept.SelectedValue;
            User user = new User()
            {
                Ssn=ssn,Fname=fname,Lname=lname,Password=passwod,
                Age=age,Role=role,DeptId=dept_id
            };
            db.Users.Add(user);
            db.SaveChanges();
            var user2 = db.Users.Select(u => new { u.Ssn, u.Fname, u.Lname, u.Password, u.Age, u.Role, u.DeptId });
            dgv_user.DataSource = user2.ToList();
            clear_input();

        }
        
        private void dgv_user_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_fname.Text = dgv_user.SelectedRows[0].Cells[1].Value.ToString();
            txt_lname.Text = dgv_user.SelectedRows[0].Cells[2].Value.ToString();
            txt_pass.Text = dgv_user.SelectedRows[0].Cells[3].Value.ToString();
            txt_age.Text = dgv_user.SelectedRows[0].Cells[4].Value.ToString();
            txt_role.Text = dgv_user.SelectedRows[0].Cells[5].Value.ToString();
            label1.Hide();
            txt_ssn.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selected_ssn = dgv_user.SelectedRows[0].Cells[0].Value;
            var selected_user = db.Users.Where(u => u.Ssn == selected_ssn).FirstOrDefault();
            db.Users.Remove(selected_user);
            db.SaveChanges();
            var user2 = db.Users.Select(u => new { u.Ssn, u.Fname, u.Lname, u.Password, u.Age, u.Role, u.DeptId });
            dgv_user.DataSource = user2.ToList();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selected_ssn = dgv_user.SelectedRows[0].Cells[0].Value.ToString();
            User selected_user = db.Users.Where(u => u.Ssn == selected_ssn).FirstOrDefault();
            selected_user.Fname=txt_fname.Text;
            selected_user.Lname=txt_lname.Text;
            selected_user.Password =txt_pass.Text;
            selected_user.Age=int.Parse(txt_age.Text);
            selected_user.Role=txt_role.Text;
            selected_user.DeptId =(int) cbx_dept.SelectedValue;
            db.Users.Update(selected_user);
            db.SaveChanges();
            var user2 = db.Users.Select(u => new { u.Ssn, u.Fname, u.Lname, u.Password, u.Age, u.Role, u.DeptId });
            dgv_user.DataSource = user2.ToList();
            clear_input();
            label1.Show();
            txt_ssn.Show();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_depatmentDetails_Click(object sender, EventArgs e)
        {
            department dept = new department();
            dept.Show();
            this.Hide();
        }

        private void btn_stord_Click(object sender, EventArgs e)
        {
            
        }
    }
}
