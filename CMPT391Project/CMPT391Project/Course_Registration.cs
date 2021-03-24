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
        private SQLController collegeDB = new SQLController();

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
            // chooseCarView.Rows[chooseCarView.SelectedRows[0].Index].Cells[3].Value.ToString(); this will get a specific value
            // grab the selected items
            List<Dictionary<string, string>> chosenClasses = new List<Dictionary<string, string>>();
            Dictionary<string, string> temp = new Dictionary<string, string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // create a new list dictionary
                DataGridViewSelectedRowCollection DGV = dataGridView1.SelectedRows;
                for(int i = 0; i < DGV.Count; i++)
                {
                    DataGridViewCellCollection DGS = DGV[i].Cells;
                    for (int ii = 0; ii < DGS.Count; ii++) {
                        // populate the keys with their corresponding value
                        temp.Add(dataGridView1.Columns[ii].HeaderText, DGS[ii].Value.ToString());
                    }
                    chosenClasses.Add(temp);
                    temp = new Dictionary<string, string>();
                }
                
                // pass them to the cart along with student id
                Cart CartForm = new Cart(chosenClasses, student_id);
                CartForm.Show();
            }
            else
            {
                // shame them for selecting nothing
                searchResultLabel.Text = "Select a class or else";
                searchResultLabel.ForeColor = Color.FromName("Red");
            }

            // translate them into a dictionary list

            
        }

        private void Course_Registration_Load(object sender, EventArgs e)
        {

            // should check that they are not empty first
            // get distinct years
            yearComboBox.DataSource = collegeDB.executeFetchCommand("select distinct s.[year] from section s;").Tables[0];
            // get every department
            departmentComboBox.DataSource = collegeDB.executeFetchCommand("select d.name from department d;").Tables[0];
            // get distinct terms
            termComboBox.DataSource = collegeDB.executeFetchCommand("select distinct s.[term] from section s;").Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // grab year term and department from the drop downs
            String year = yearComboBox.Text;
            String term = termComboBox.Text;
            String dept = departmentComboBox.Text;
            //System.Windows.Forms.MessageBox.Show(year + " " + term + " " + dept);
            if (year == "" || term == "" || dept == "")
            {
                // change a label to warn that it is null
                searchResultLabel.Text = "Please choose options for all fields";
                searchResultLabel.ForeColor = Color.FromName("Red");

            }
            else
            {
                searchResultLabel.Text = "";
                // query for available courses
                String query = "EXEC dbo.availClasses @term = '" + term + "', @year = " + year + ", @dept = '" + dept + "';";

                DataSet queryResult = collegeDB.executeFetchCommand(query);
                // pass that data set over
                if (queryResult.Tables.Count > 0)
                {
                    dataGridView1.DataSource = queryResult.Tables[0];
                }
                else
                {
                    searchResultLabel.Text = "No Results";
                    searchResultLabel.ForeColor = Color.FromName("Green");
                }
                

            }

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void termComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SectionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
