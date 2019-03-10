using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSytem
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try {
                string queryPerson = string.Format("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}',(select Id from Lookup where Value='{5}'))",
           txtBxFirstName.Text, txtBxLastName.Text, txtBxContact.Text, txtBxEmail.Text, Convert.ToDateTime(dateTimePickerDOB.Value), cmbBxGender.Text);
                DataBaseConnection.getInstance().executeQuery(queryPerson);
                string queryStudent = string.Format("insert into Student(Id,RegistrationNo) values((select max(Id) from Person),'{0}')", txtBxReg.Text);
                DataBaseConnection.getInstance().executeQuery(queryStudent);
                MessageBox.Show("Added Success");
                Show_Students showStudent = new Show_Students();
                this.Hide();
                showStudent.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("added failed"+ex.ToString());
            }

            


        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Show_Students showStudent = new Show_Students();
            this.Hide();
            showStudent.Show();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
         
          /*  string getdata = string.Format("select Value from Lookup where Category='GENDER'");
          var  gender = DataBaseConnection.getInstance().readData(getdata);
            while (gender.Read())
            {
                cmbBxGender.Items.Add(gender.GetString(0));
            }*/
        }
    }
}
