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
    public partial class EnrolledCourses : Form
    {
        int studentID;

        public EnrolledCourses(int student_id)
        {
            InitializeComponent();
            this.studentID = student_id;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Homepage SHForm = new Student_Homepage(this.studentID);
            SHForm.ShowDialog();
            this.Close();
        }

        private void EnrolledCourses_Load(object sender, EventArgs e)
        {
            fillToolStripButton_Click(sender, e);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkEnrolledTableAdapter.Fill(this.enrolledCoursesDataSetFINAL.checkEnrolled, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.studentID, typeof(int))))));
                studentIDToolStripTextBox.Text = this.studentID.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.checkEnrolledTableAdapter.Fill(this.enrolledCoursesDataSet.checkEnrolled, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.studentID, typeof(int))))));
        //        studentIDToolStripTextBox.Text = this.studentID.ToString();
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
