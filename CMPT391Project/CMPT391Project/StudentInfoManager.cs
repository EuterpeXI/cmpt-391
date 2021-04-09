using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * This class is used to store the student's info
 */
namespace CMPT391Project
{
    class StudentInfoManager
    {
        #region Singleton
        private static StudentInfoManager instance = null;
        private static readonly object padlock = new object();
        
        /*private class so that no other class can create another object*/
        private StudentInfoManager()
        {
        }

        public static StudentInfoManager Instance
        {
            get
            {
                lock (padlock);
                if(instance == null)
                {
                    instance = new StudentInfoManager();
                }
                return instance;
            }
        }
        #endregion

        private int studentID;

        public void setStudentID(int ID)
        {
            studentID = ID;
        }

        public int getStudentID()
        {
            return studentID;
        }
    }
}
