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
    public partial class Course_Registration : Form
    {
        int student_id;
        public Course_Registration(int student_id)
        {
            InitializeComponent();
            this.student_id = student_id;
        }

        private void Go_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Homepage SHForm = new Student_Homepage(this.student_id);
            SHForm.ShowDialog();
            this.Close();
        }

        private void Cart_Button_Click(object sender, EventArgs e)
        {
            Cart CartForm = new Cart();
            CartForm.Show();
        }
    }
}
