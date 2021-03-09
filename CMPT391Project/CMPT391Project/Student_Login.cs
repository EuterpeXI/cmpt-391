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
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int student_id = 0;
            try
            {
                student_id = Int32.Parse(login_input.Text);
            }
            catch (InvalidCastException ie)
            {
                Console.WriteLine("Value is not an int", ie.Source);
            }

            this.Hide();
            Student_Homepage StudentHomepageForm = new Student_Homepage(student_id);
            StudentHomepageForm.ShowDialog();
            this.Close();
        }

        private void Student_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
