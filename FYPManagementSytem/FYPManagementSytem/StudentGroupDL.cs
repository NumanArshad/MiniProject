using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSytem
{
    class StudentGroupDL
    {
        private List<Student> stdGrpLst = new List<Student>();
        private static StudentGroupDL instance = null;
        private StudentGroupDL()
        {

        }
        public static StudentGroupDL getInstance()
        {
            if (instance == null)
            {
                instance = new StudentGroupDL();
            }
            return instance;
        }
        public void addStudent(Student obj)
        {
            stdGrpLst.Add(obj);
        }
        public List<Student> getStudentGroup()
        {
            return stdGrpLst;
        }
    }
}
