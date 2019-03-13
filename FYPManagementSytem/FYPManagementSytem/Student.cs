using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSytem
{
    class Student
    {
        private int id;
        private string regNo;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string RegNo
        {
            get
            {
                return regNo;
            }

            set
            {
                regNo = value;
            }
        }
    }
}
