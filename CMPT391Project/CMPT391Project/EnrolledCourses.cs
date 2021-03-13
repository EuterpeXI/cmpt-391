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
        private SQLController collegeDB = new SQLController();
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
            enrolledCoursesDataGridView1.DataSource = collegeDB.executeFetchCommand("EXEC checkEnrolled @studentID = '" + this.studentID + "';").Tables[0];
        }
    }
}
