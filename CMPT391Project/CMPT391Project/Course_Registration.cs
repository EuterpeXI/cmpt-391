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
                }
                
                // pass them to the cart along with student id
                Cart CartForm = new Cart();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // grab year term and department from the drop downs
            String year = yearComboBox.Text;
            String term = termComboBox.Text;
            String dept = departmentComboBox.Text;
            System.Windows.Forms.MessageBox.Show(year + " " + term + " " + dept);
            if (year == null || term == null || dept == null)
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
    }
}
