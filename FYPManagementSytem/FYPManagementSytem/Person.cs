//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FYPManagementSytem
//{
//    class Person
//    {
//        private Student student;
//        private string firstName;
//        private string lastName;
//        private string contact;
//        private string email;
//        private DateTime dateofBirth;
//        private string gender;

//        private static Person instance = null;

//        internal Student Student
//        {
//            get
//            {
//                return student;
//            }

//            set
//            {
//                student = value;
//            }
//        }

//        public string FirstName
//        {
//            get
//            {
//                return firstName;
//            }

//            set
//            {
//                firstName = value;
//            }
//        }

//        public string LastName
//        {
//            get
//            {
//                return lastName;
//            }

//            set
//            {
//                lastName = value;
//            }
//        }

//        public string Contact
//        {
//            get
//            {
//                return contact;
//            }

//            set
//            {
//                contact = value;
//            }
//        }

//        public string Email
//        {
//            get
//            {
//                return email;
//            }

//            set
//            {
//                email = value;
//            }
//        }

//        public DateTime DateofBirth
//        {
//            get
//            {
//                return dateofBirth;
//            }

//            set
//            {
//                dateofBirth = value;
//            }
//        }

//        public string Gender
//        {
//            get
//            {
//                return gender;
//            }

//            set
//            {
//                gender = value;
//            }
//        }
//        private Person()
//        {

//        }
//        public static Person getInstance()
//        {
//            if (instance == null)
//            {
//                instance = new Person();
//            }
//            return instance;
//        }
//    }
//}
