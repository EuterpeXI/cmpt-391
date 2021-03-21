using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT391Project
{
    public partial class Cart : Form
       
    {
        List<Dictionary<string, string>> courses;
        int studentID ;

        /// <summary>
        /// Initiates cart instance.
        /// </summary>
        /// <param name="courses">List of courses</param>
        /// <param name="studentID">ID of student logged in</param>
        public Cart(List<Dictionary<string, string>> courses, int studentID)
        {
            this.courses = courses;
            this.studentID = studentID;
            foreach (Dictionary<string, string> course in courses)
            {
                course.TryGetValue("Course", out string courseID);
            }
            InitializeComponent();
            Populate_Cart();
        }

        /// <summary>
        /// Adds the courses to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Button_Click(object sender, EventArgs e)
        {
            SQLController SQLhandler = new SQLController();
            
            foreach (Dictionary<string, string> course in courses)
            {
                // Check if prerequisites are met
                if (course.TryGetValue("Course", out string courseID))
                {
                    // query for checking prerequisites
                    String query = "EXEC dbo.checkPreRequsite @studentID = '" + studentID + "', @courseID = '" + courseID + "';";
                    DataSet queryResult = SQLhandler.executeFetchCommand(query);
                   
                    // pass that data set over
                    if (queryResult.Tables.Count > 0)

                    {
                        // If prerequisites are all met
                        if (queryResult.Tables[0].Rows.Count == 0)
                        {
                            // Get section
                            if (course.TryGetValue("Section", out string sectionID))
                            {
                                // query for inserting for section
                                query = "EXEC dbo.insertSection @studentID = '" + studentID + "', @sectionID = '" + sectionID + "';";
                                SQLhandler.executeSetCommand(query);
                                Error_Text.Visible = true;
                                Error_Text.Text = "Yay you registered into your classes... b.b.baka it's not like I wanted you to register or anything o.o";
                                Error_Text.ForeColor = Color.Green;
                            }
                            else {

                                Error_Text.Visible = true;
                                Error_Text.Text = "Error adding the sections (ಠ_ಠ)";
                                return;

                            }
                        }
                        // Prerequisites are not met
                        else
                        {

                            Error_Text.Visible = true;
                            Error_Text.Text = @"You do not have the cowwect prerequisites (ノಠ ∩ಠ)ノ彡( \o°o)\";
                            return;
                        }
                    }
                    // Error getting prerequisites
                    else
                    {
                        Error_Text.Visible = true;
                        Error_Text.Text = "Ewwow checking prerequisites (・`ω´・) ";
                        return;
                    }

                }
            }
            //TODO: call subscribed method 
        }

        /// <summary>
        /// Populate the cart with courses.
        /// </summary>
        private void Populate_Cart()

        {
            // Add the headers
            foreach (var tableHeading in courses[0])
            {
                Cart_View.Columns.Add(tableHeading.Key, tableHeading.Key);
            }

            // Add the rows
            foreach (var course in courses)
            {
                var rowId = Cart_View.Rows.Add();
                var row = Cart_View.Rows[rowId];

                // Add each value to row cells
                foreach(var kvp in course)
                {
                    row.Cells[kvp.Key].Value = kvp.Value;

                }
            }
        }

        /// <summary>
        /// Delete selected courses.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void Delete_Course_Button_Click(object sender, EventArgs e)
        {
            if (Cart_View.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Cart_View.SelectedRows)
                {
                    string sectionID = row.Cells[2].Value.ToString();
                    Cart_View.Rows.Remove(row);

                    // Find the section in the courses list
                    var toDelete = new List<Dictionary<string, string>>();
                    foreach (var course in courses)
                    {
                        course.TryGetValue("Section", out string tSectionID);

                        // Add it to delete if matches
                        if (tSectionID == sectionID)
                        {
                            toDelete.Add(course);
                        }
                    }

                    // Delete all selected courses
                    foreach(var course in toDelete)
                    {
                        courses.Remove(course);
                    }
                }

            }
            else
            {
                Error_Text.Text = "Pwease select courses to delete.";
            }
        }
    }
}
