using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSytem
{
    class EvaluationsReport
    {
        private int groupId;
        private string title;
        private string name;
        private string student;
        
        private string obtinedMarks;
        private string totalMarks;
        private string totalWeightage;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public string ObtinedMarks
        {
            get
            {
                return obtinedMarks;
            }

            set
            {
                obtinedMarks = value;
            }
        }

        public string TotalMarks
        {
            get
            {
                return totalMarks;
            }

            set
            {
                totalMarks = value;
            }
        }

        public string TotalWeightage
        {
            get
            {
                return totalWeightage;
            }

            set
            {
                totalWeightage = value;
            }
        }
    }
}
