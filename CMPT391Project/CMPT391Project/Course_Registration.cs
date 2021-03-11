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

        private void Course_Registration_Load(object sender, EventArgs e)
        {
            this.sectionTableAdapter2.Fill(this.sectionTermDataSet.section);
            // For department dropdownlist
            this.departmentTableAdapter.Fill(this.collegeDataSet1.department);

            // For term dropdown list
            this.sectionTableAdapter1.Fill(this.collegeDataSet1.section);
            try
            {
                this.sectionTableAdapter2.FillBy(this.sectionTermDataSet.section);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // For year dropdown list
            this.sectionTableAdapter.Fill(this.sectionYearDataSet.section);
            try
            {
                this.sectionTableAdapter.FillBy1(this.sectionYearDataSet.section);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
