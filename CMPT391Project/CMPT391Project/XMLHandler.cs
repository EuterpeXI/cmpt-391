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
        public static string loadFile(string filename)
        {
            string returnText = "";
            foreach(XElement e1 in XElement.Load(filename).Elements("course"))
            {
                returnText += e1.Attribute("course_id").Value.ToString();
                returnText += " department: "+e1.Element("department").Value.ToString();
                returnText += " faculty: " + e1.Element("faculty").Value.ToString();
                returnText += " university: " + e1.Element("university").Value.ToString();
            }
            return returnText;
        }
    }
}
