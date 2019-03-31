using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSytem
{
    public partial class Make_Group : Form
    {
        public Make_Group()
        {
            InitializeComponent();
        }

        private void cmdCreateGroup_Click(object sender, EventArgs e)
        {
            var currentDateTime = DateTime.Now;
            if (!is_editMode())
            {
                
                    string queryGroup = string.Format("insert into [[Group]]](Created_On) values('{0}')", currentDateTime.Date);
                    DataBaseConnection.getInstance().executeQuery(queryGroup);
                    foreach (Student st in newGroupStudents)  //StudentGroupDL.getInstance().getStudentGroup()
                    {
                        string queryStudentGroup = string.Format("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values((select max(Id) from [[Group]]]),'{0}','{1}','{2}')", st.Id, 4, currentDateTime);
                        DataBaseConnection.getInstance().executeQuery(queryStudentGroup);

                    }

                    MessageBox.Show("Student added in group  successfully");
                
            }
            else
            {
                //group member status
                string statusQuery = "select Status from GroupStudent where GroupId=" + GeneralID.selectedObjectid + "";
                var getStatus = DataBaseConnection.getInstance().readData(statusQuery);
                getStatus.Read();
                int countStatusValue = (int)getStatus.GetValue(0);
                foreach (Student st in newGroupStudents)  //StudentGroupDL.getInstance().getStudentGroup()
                {
                    string countExistQuery = string.Format("select count(StudentId) from GroupStudent where StudentId='{0}'", st.Id);
                   
                    int countStudentInGroup = DataBaseConnection.getInstance().getRowsCount(countExistQuery);
               //     MessageBox.Show(countStudentInGroup.ToString());
                         if (countStudentInGroup == 0)
                          {
                              MessageBox.Show("New Student added in this Group");
                              string queryStudentGroup = string.Format("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values('{0}','{1}','{2}','{3}')", GeneralID.selectedObjectid,st.Id, countStatusValue, currentDateTime);
                              DataBaseConnection.getInstance().executeQuery(queryStudentGroup);

                          }


                }
                MessageBox.Show("update success");
                GeneralID.selectedObjectid = 0;
            }


            //  StudentGroupDL.getInstance().getStudentGroup().Clear();
            Manage_Student_Groups msg = new Manage_Student_Groups();
                this.Hide();
                msg.Show();

            }
      /*  public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == form.Name)
                    return true;
            return false;
        }
        */
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //foreach(Form form in Application.OpenForms)
            //{
            //    //    MessageBox.Show(form.GetType().Name);
            //    if (form.GetType().Name == "Make_Group")
            //    {
            //        //  MessageBox.Show(form.Name);
            //        form.Hide();
            //    }
            //}
       
        Manage_Student_Groups msg = new Manage_Student_Groups();
         this.Hide();
            msg.Show();
        }

        private void txtBxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            //@RegistrationNo
           /*    string autotextQuery = "select RegistrationNo from Student where RegistrationNo like RegistrationNo";
                var data= DataBaseConnection.getInstance().autoComplete(autotextQuery,"RegistrationNo",txtBxSearchStudent.Text);
               AutoCompleteStringCollection col = new AutoCompleteStringCollection();
               while (data.Read())
               {
                   col.Add(data.GetString(0));
               }

            txtBxSearchStudent.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBxSearchStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBxSearchStudent.AutoCompleteCustomSource = col;*/

        }
        List<Student> newGroupStudents;
        private void Make_Group_Load(object sender, EventArgs e)
        {
          //  string autotextQuery = "select RegistrationNo from Student where RegistrationNo like RegistrationNo";
            string autotextQuery = "select RegistrationNo from Student where  RegistrationNo like RegistrationNo and  not EXISTS(select * from  GroupStudent where StudentId=Student.Id)";
            var data = DataBaseConnection.getInstance().autoComplete(autotextQuery, "RegistrationNo", txtBxSearchStudent.Text);
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (data.Read())
            {
                 col.Add(data.GetString(0));
            }
            txtBxSearchStudent.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBxSearchStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBxSearchStudent.AutoCompleteCustomSource = col;

              newGroupStudents = new List<Student>();

            if (is_editMode())
            {
                string groupQuery = string.Format("select Student.Id,Student.RegistrationNo from Student join GroupStudent on GroupStudent.GroupId='{0}' and Student.Id=GroupStudent.StudentId", GeneralID.selectedObjectid);
                var readStudent = DataBaseConnection.getInstance().readData(groupQuery);

                while (readStudent.Read())
                {
                    Student st = new Student();
                    st.Id = (int)readStudent.GetValue(0);
                    st.RegNo = readStudent.GetValue(1).ToString();
                    newGroupStudents.Add(st);
                }
                BindingSource bind = new BindingSource();
                bind.DataSource = newGroupStudents;//StudentGroupDL.getInstance().getStudentGroup();
                studentGroupGridView.DataSource = bind;
            }

            cmdCreateGroup.Enabled = false;
        }

        private Boolean is_invalid()
        {
            Boolean invalid = false;
            lblform.Text = "";

            if (txtBxSearchStudent.Text == "")
            {
                lblform.Text = "Please select student";
                invalid = true;
            }
            else if(newGroupStudents.Count()>0)
            {
                MessageBox.Show("executing");
                foreach(Student st in newGroupStudents)
                {
                    if (st.RegNo == txtBxSearchStudent.Text)
                    {
                        lblform.Text = "Student is already in this group";
                        invalid = true;
                        break;
                    }

                }
            }
            MessageBox.Show(invalid.ToString());
            return invalid;
        }
        DataTable table = new DataTable();
        private void cmdAddInGroup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(is_invalid().ToString());
            if (!is_invalid())
            {

                string query = string.Format("select Id from Student where RegistrationNo='{0}'", txtBxSearchStudent.Text);
                int studentId = DataBaseConnection.getInstance().getRowsCount(query);
                Student student = new Student();
                student.Id = studentId;
                student.RegNo = txtBxSearchStudent.Text;
                //   student.FirstName1 = null;
                //      StudentGroupDL.getInstance().addStudent(student);

                newGroupStudents.Add(student);
                BindingSource bind = new BindingSource();
                bind.DataSource = newGroupStudents;//StudentGroupDL.getInstance().getStudentGroup();
                studentGroupGridView.DataSource = bind;
                txtBxSearchStudent.Clear();
                MessageBox.Show("Student added in group successfully");
                cmdCreateGroup.Enabled = true;
            }
        }
        private Boolean is_editMode()
        {
            bool EditMode = false;
            if (GeneralID.selectedObjectid != 0)
            {
                // MessageBox.Show(GeneralID.selectedObjectid.ToString());
                EditMode = true;
            }
            return EditMode;

        }
    }
}
