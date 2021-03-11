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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
            login_input.MaxLength = 10;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int student_id;
            if (Int32.TryParse(login_input.Text, out student_id))
            {
                student_id = Int32.Parse(login_input.Text);
                this.Hide();
                Student_Homepage StudentHomepageForm = new Student_Homepage(student_id);
                StudentHomepageForm.ShowDialog();
                this.Close();
            }
        }

        private void Login_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
