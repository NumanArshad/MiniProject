using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSytem
{
    class AdvisorsProjectReport
    {
        private int groupId;
        private string advisor;
        private string title;
        private string student;

        public int GroupId
        {
            get
            {
                return groupId;
            }

            set
            {
                groupId = value;
            }
        }
        public string Advisor
        {
            get
            {
                return advisor;
            }

            set
            {
                advisor = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }
    }
}
