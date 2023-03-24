using dataBaseProject.Models;

namespace dataBaseProject
{
    public partial class Form1 : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var name = txb_name.Text.ToLower();
            var ssn = txb_id.Text;
            if (name == "ali" && ssn == "29705720312423")
            {
                admin admin = new admin();
                admin.Show();
                this.Hide();
                return;
            }
            User user = db.Users.FirstOrDefault(i => i.Ssn == ssn);
            if (user == null)
            {
                MessageBox.Show("Wrong Wrong", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.Role == "I")
                {
                    instractor ins_form = new instractor();
                    ins_form.Show();
                    this.Hide();
                }
                else
                {
                    student std_form = new student();
                    SetValueForText1 = txb_id.Text;
                    std_form.Show();
                    this.Hide();
                }
            }
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}