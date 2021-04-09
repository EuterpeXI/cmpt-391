using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT391Project
{
    class XMLHandler
    {
        public XMLHandler()
        {
        }

        //TODO: check if the data exist in th database
        //Insert into the database
        /*
         * <table id="number"(called by attirbutes)>
         *  <columns (called by elements)>value</columns> 
         */
        public static string loadFile(SQLWarehouseController controller, string filename)
        {
            XElement root = XElement.Load(filename);
            try
            {
                XMLHandler.insertDate(controller, root);
                XMLHandler.insertCourse(controller, root);
                XMLHandler.insertInstructor(controller, root);
                XMLHandler.insertStudent(controller, root);
                return "Insertion Success!";
            }
            catch
            {
                return "Insertion fail";
            }
            //return "success";
        }

        private static void insertDate(SQLWarehouseController controller, XElement root)
        {//@date, @semester, @year
            string queryString = "";
            foreach(XElement Level1 in root.Elements("date"))
            {
                queryString = "EXEC dbo.usp_insert_date ";
                queryString += "@date = "+Level1.Attribute("date_id").Value.ToString() + ", ";
                queryString += "@semester = '" + Level1.Element("semester").Value.ToString() + "', ";
                queryString += "@year = " + Level1.Element("year").Value.ToString() + " ";
                controller.executeFetchCommand(queryString);
            }
        }

        private static void insertCourse(SQLWarehouseController controller, XElement root)
        {
            //@course_id, @department, @faculty, @university
            string queryString = "";
            foreach (XElement Level1 in root.Elements("course"))
            {
                queryString = "EXEC dbo.usp_insert_course ";
                queryString += " @course_id = " + Level1.Attribute("course_id").Value.ToString() + ", ";
                queryString += " @department = '" + Level1.Element("department").Value.ToString() + "', ";
                queryString += " @faculty = '" + Level1.Element("faculty").Value.ToString() + "', ";
                queryString += " @university = '" + Level1.Element("university").Value.ToString() + "' ";
                controller.executeFetchCommand(queryString);
            }
        }

        private static void insertInstructor(SQLWarehouseController controller, XElement root)
        {
            //@instructor_id, @faculty, @rank, @university
            string queryString = "";
            foreach (XElement Level1 in root.Elements("instructor"))
            {
                queryString = "EXEC dbo.usp_insert_instructor ";
                queryString += " @instructor_id = " + Level1.Attribute("instructor_id").Value.ToString() + ", ";
                queryString += " @faculty = '" + Level1.Element("faculty").Value.ToString() + "', ";
                queryString += " @rank = '" + Level1.Element("rank").Value.ToString() + "', ";
                queryString += " @university = '" + Level1.Element("university").Value.ToString() + "' ";
                controller.executeFetchCommand(queryString);
            }
        }

        private static void insertStudent(SQLWarehouseController controller, XElement root)
        {
            //@student_id, @major, @gender
            string queryString = "";
            foreach(XElement Level1 in root.Elements("student"))
            {
                queryString = "EXEC dbo.usp_insert_student";
                queryString += " @student_id = " + Level1.Attribute("student_id").Value.ToString() + ", ";
                queryString += " @major = '" + Level1.Element("major").Value.ToString() + "', ";
                queryString += " @gender = '" + Level1.Element("gender").Value.ToString() + "' ";
                controller.executeFetchCommand(queryString);
            }
        }
    }
}
