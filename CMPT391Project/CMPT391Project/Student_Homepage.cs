using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT391Project
{
    public partial class Student_Homepage : Form
    {
        int student_id;
        public Student_Homepage(int student_id)
        {
            InitializeComponent();
            StudentLabel.Text = student_id.ToString();
            this.student_id = student_id;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login LoginForm = new Student_Login();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course_Registration CRForm = new Course_Registration(this.student_id);
            CRForm.ShowDialog();
            this.Close();
        }
    }
}
