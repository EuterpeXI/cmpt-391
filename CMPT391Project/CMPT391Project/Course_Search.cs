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
    public partial class Course_Search : Form
    {
        private String selectionQuery;
        private SQLWarehouseController wareHouseDB = new SQLWarehouseController();
        public Course_Search()
        {
            InitializeComponent();
            selectionQuery = "EXEC usp_get_sum_course_count";//initialize the query string

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Homepage SHForm = new Student_Homepage(StudentInfoManager.Instance.getStudentID());
            SHForm.ShowDialog();
            this.Close();
        }

        private void UniversityLabel_Click(object sender, EventArgs e)
        {

        }

        private void UniversityDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InstructorDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String temp = selectionQuery;
            String comboBoxText = "";
            String university = universityDD.Text;
            comboBoxText += (university.Length != 0) ? " @uni = '"+university+"', " : "";
            String term = termDD.Text;
            comboBoxText += (term.Length != 0) ? " @sem = '" + term + "', " : "";
            String department = departmentDD.Text;
            comboBoxText += (department.Length != 0) ? " @dep = '" + department + "', " : "";
            int year = Int32.Parse(yearDD.Text);
            comboBoxText += (year != 0) ? " @yr = '" + year + "', " : "";
            String faculty = facultyDD.Text;
            comboBoxText += (faculty.Length != 0) ? " @fac = '" + faculty + "', " : "";

            comboBoxText = comboBoxText.Remove(comboBoxText.Length - 2);
            selectionQuery += comboBoxText;
            //call SQL and get result
            DataSet queryResult = wareHouseDB.executeFetchCommand(selectionQuery);
            if(queryResult == null || queryResult.Tables.Count == 0)
            {
                //DataSet queryResult = wareHouseDB.executeFetchCommand(selectionQuery);
                resultText.Text = "No result found UwU";
            }
            else
            {
                resultText.Text = "The number of course(s): " + queryResult.Tables[0].Rows[0][0].ToString();
            }
            selectionQuery = temp;
            //resultText.Text = "The number is: "+queryResult.Tables[0];
            //.Rows[0][0]
        }

        private void Course_Search_Load(object sender, EventArgs e)
        {
            DataRow row;
            // TODO: This line of code loads data into the 'collegeWarehouseCourseDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.collegeWarehouseCourseDataSet.course);
            // TODO: This line of code loads data into the 'collegeWarehouseDateDataSet3.date' table. You can move, or remove it, as needed.
            this.dateTableAdapter.Fill(this.collegeWarehouseDateDataSet3.date);

            DataTable data = addEmpty(wareHouseDB.executeFetchCommand("SELECT DISTINCT date.year FROM date;").Tables[0], "year", true);
            yearDD.DataSource = data;

            data = addEmpty(wareHouseDB.executeFetchCommand("SELECT DISTINCT TOP(50) date.semester FROM date;").Tables[0], "semester", false);
            termDD.DataSource = data;

            data = addEmpty(wareHouseDB.executeFetchCommand("SELECT DISTINCT course.department FROM course;").Tables[0], "department", false);
            departmentDD.DataSource = data;

            data = addEmpty(wareHouseDB.executeFetchCommand("SELECT DISTINCT course.university FROM course;").Tables[0], "university", false);
            universityDD.DataSource = data;

            data = addEmpty(wareHouseDB.executeFetchCommand("SELECT DISTINCT course.faculty FROM course;").Tables[0], "faculty", false);
            facultyDD.DataSource = data;
        }

        private DataTable addEmpty(DataTable data, String column, bool isInt)
        {
            DataRow row = data.NewRow();
            if (isInt)
            {
                row[column] = 0;
            }
            else
            {
                row[column] = "";
            }
            data.Rows.Add(row);
            return data;
        }

        private void YearDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DistinctCourseToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.DistinctCourse(this.collegeWarehouseCourseDataSet.course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ResultText_Click(object sender, EventArgs e)
        {

        }

        private void SumRBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectionQuery = "EXEC dbo.usp_get_sum_course_count ";
        }

        private void AverageRBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectionQuery = "EXEC dbo.usp_get_avg_course_count ";
        }

        private void MinRBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectionQuery = "EXEC dbo.usp_get_min_course_count ";
        }

        private void MaxRBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectionQuery = "EXEC dbo.usp_get_max_course_count ";
        }
    }
}
