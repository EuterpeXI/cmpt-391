using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPT391Project
{
    class SQLWarehouseController
    {
        private SqlConnection sqlCon;
        private SqlCommand command;
        // set to local server for whoever is using
        private static String conStr = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT391Project.Properties.Settings.CollegeWarehouseConnectionString"].ConnectionString;

        public SQLWarehouseController()
        {

            // on initialization make and check connection then error if it does not work
            try
            {
                sqlCon = new SqlConnection(conStr);
                command = new SqlCommand();
                sqlCon.Open();
                sqlCon.Close();
            }
            catch (Exception e)
            {
                //error message
                MessageBox.Show(e.ToString(), "Error");

            }
        }

        public DataSet executeFetchCommand(string commandString)
        {
            /*
             * Input: commandString(string) -> query to execute.
             * Purpose: Take a command entered and execute it retrieve the queried values in a DataSet
             * Output: DataSet -> DataSet filled with the reulting querie's values
             */
            try
            {
                sqlCon.Open();
                // start the command
                command = new SqlCommand(commandString, sqlCon);
                // move into data adapter
                SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

                //fill data set
                DataSet data = new DataSet();
                sqlAdapt.Fill(data);

                sqlCon.Close();

                return data;

            }
            catch (Exception e)
            {
                // error message
                MessageBox.Show(e.ToString(), "Error");
                return null;
            }

        }

        public string getRecentQuery()
        {
            return command.CommandText;
        }

        public void executeSetCommand(string commandString)
        {
            /*
             * Input: commandString(string) -> update or deletion to execute.
             * Purpose: Take a command entered and execute it
             * Output: None
             */
            try
            {
                sqlCon.Open();
                command = new SqlCommand(commandString, sqlCon);
                command.ExecuteNonQuery();

                sqlCon.Close();
            }
            catch (Exception e)
            {
                // error message
                MessageBox.Show(e.ToString(), "Error");
            }
        }
    }
}
