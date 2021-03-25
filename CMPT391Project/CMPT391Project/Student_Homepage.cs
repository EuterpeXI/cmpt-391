using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT391Project
{
    public partial class Student_Homepage : Form
    {
        int student_id;
        private SQLController collegeDB = new SQLController();

        public Student_Homepage(int student_id)
        {
            InitializeComponent();
            StudentIDLabel.Text = student_id.ToString();
            this.student_id = student_id;
            StudentInfoManager.Instance.setStudentID(student_id);
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
            this.Hide();
            EnrolledCourses ECForm = new EnrolledCourses(this.student_id);
            ECForm.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course_Registration CRForm = new Course_Registration(this.student_id);
            CRForm.ShowDialog();
            this.Close();
        }

        private void Student_Homepage_Load(object sender, EventArgs e)
        {
            String query = "SELECT first_name, last_name FROM student WHERE s_id = '" + this.student_id + "';";
            DataSet queryResult = collegeDB.executeFetchCommand(query);
            if (queryResult.Tables[0].Rows.Count > 0)
            {
                StudentNameLabel.Text = queryResult.Tables[0].Rows[0][0].ToString() + " " + queryResult.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                StudentNameLabel.Text = "Name not found";
            }
        }

        private void ClassSearch_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Course_Search CSForm = new Course_Search();
            CSForm.ShowDialog();
            //this.Close();
        }
    }
}
