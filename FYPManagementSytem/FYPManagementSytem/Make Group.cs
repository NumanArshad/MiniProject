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
            //   MessageBox.Show(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
            //  dateTime.ToString("dd/MM/yyyy")
            var currentDateTime = DateTime.Now;//Convert.ToDateTime(DateTime.Now);
          string queryGroup = string.Format("insert into Group1(Created_On) values('{0}')", currentDateTime.Date);
            DataBaseConnection.getInstance().executeQuery(queryGroup);
            foreach (Student st in StudentGroupDL.getInstance().getStudentGroup())
            {
                string queryStudentGroup = string.Format("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values((select max(Id) from Group1),'{0}','{1}','{2}')", st.Id1, 4, currentDateTime);
                DataBaseConnection.getInstance().executeQuery(queryStudentGroup);
               

            }

            StudentGroupDL.getInstance().getStudentGroup().Clear();
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
        }

        DataTable table = new DataTable();
        private void cmdAddInGroup_Click(object sender, EventArgs e)
        {
            string query = string.Format("select Id from Student where RegistrationNo='{0}'", txtBxSearchStudent.Text);
            int studentId = DataBaseConnection.getInstance().getRowsCount(query);
            Student student = new Student();
            student.Id1 = studentId;
            student.RegNo1 = txtBxSearchStudent.Text;

            StudentGroupDL.getInstance().addStudent(student);
            BindingSource bind = new BindingSource();
            bind.DataSource = StudentGroupDL.getInstance().getStudentGroup();
            studentGroupGridView.DataSource = bind;
            txtBxSearchStudent.Clear();
        }
    }
}
