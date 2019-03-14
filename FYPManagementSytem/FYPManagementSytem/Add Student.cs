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
                //check either new student is going too added
                if (!is_editMode())  
                {
                    string queryPerson = string.Format("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}',(select Id from Lookup where Value='{5}'))",
               txtBxFirstName.Text, txtBxLastName.Text, txtBxContact.Text, txtBxEmail.Text, Convert.ToDateTime(dateTimePickerDOB.Value), cmbBxGender.Text);
                    DataBaseConnection.getInstance().executeQuery(queryPerson);
                    string queryStudent = string.Format("insert into Student(Id,RegistrationNo) values((select max(Id) from Person),'{0}')", txtBxReg.Text);
                    DataBaseConnection.getInstance().executeQuery(queryStudent);
                    MessageBox.Show("Added Success");
                 
                }
                else  // student is being updated
                {
                    string queryPerson = string.Format("update Person set FirstName='{0}',LastName='{1}',Contact='{2}',Email='{3}',DateOfBirth='{4}',Gender=(select Id from Lookup where Value='{5}') where Id='{6}'",
        txtBxFirstName.Text, txtBxLastName.Text, txtBxContact.Text, txtBxEmail.Text, Convert.ToDateTime(dateTimePickerDOB.Value), cmbBxGender.Text,GeneralID.selectedObjectid);
                    DataBaseConnection.getInstance().executeQuery(queryPerson);
                    string queryStudent = string.Format("update Student  set RegistrationNo='{0}' where Id='{1}'", txtBxReg.Text,GeneralID.selectedObjectid);
                    DataBaseConnection.getInstance().executeQuery(queryStudent);
                    MessageBox.Show("Update Success");
                    GeneralID.selectedObjectid = 0; //reset it to zero after successfull update
                }
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
     //       txtBxReg.Focus();
            string getdata = string.Format("select Value from Lookup where Category='GENDER'");
            var gender = DataBaseConnection.getInstance().readData(getdata);
            while (gender.Read())
            {
                cmbBxGender.Items.Add(gender.GetString(0));
            }
            //check if form is open to edit student
            if (is_editMode())  
            {
               // get person detail to show in textbox for edit
                string query1 = string.Format("select * from Person where Id='{0}'", GeneralID.selectedObjectid);
                var selectedPerson = DataBaseConnection.getInstance().readData(query1);
                
                int genderid=0;
                while (selectedPerson.Read())
                {
                    txtBxFirstName.Text = selectedPerson.GetString(1);
                    txtBxLastName.Text = selectedPerson.GetString(2);
                    txtBxContact.Text = selectedPerson.GetString(3);
                    txtBxEmail.Text= selectedPerson.GetString(4);
                   
                   dateTimePickerDOB.Value= selectedPerson.GetDateTime(5);
                    genderid = (int)selectedPerson.GetValue(6);

                }

                //get gender from lookup using gender ID 
                string query2 = string.Format("select Value from  Lookup where Id='{0}'", genderid);
                var getSelectedPersonGender = DataBaseConnection.getInstance().readData(query2);
                while (getSelectedPersonGender.Read())
                {
                    cmbBxGender.Text = getSelectedPersonGender.GetString(0);
                }

                //get selected student regiteration number
                string query3 = string.Format("select RegistrationNo  from Student where Id='{0}'", GeneralID.selectedObjectid);
                var SelectedStudentRegNo = DataBaseConnection.getInstance().readData(query3);
                while (SelectedStudentRegNo.Read())
                {
                    txtBxReg.Text = SelectedStudentRegNo.GetString(0);
                }


             
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
