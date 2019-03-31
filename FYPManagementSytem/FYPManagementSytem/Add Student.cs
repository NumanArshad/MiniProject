using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if (!is_invalid())  //validate data
                {
                    
                    if (!is_editMode()) //check either new student is going to added
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
            txtBxFirstName.Text, txtBxLastName.Text, txtBxContact.Text, txtBxEmail.Text, Convert.ToDateTime(dateTimePickerDOB.Value), cmbBxGender.Text, GeneralID.selectedObjectid);
                        DataBaseConnection.getInstance().executeQuery(queryPerson);
                        string queryStudent = string.Format("update Student  set RegistrationNo='{0}' where Id='{1}'", txtBxReg.Text, GeneralID.selectedObjectid);
                        DataBaseConnection.getInstance().executeQuery(queryStudent);
                        MessageBox.Show("Update Success");
                        GeneralID.selectedObjectid = 0; //reset it to zero after successfull update
                       
                    }
                    Show_Students showStudent = new Show_Students();
                    this.Hide();
                    showStudent.Show();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("added failed"+ex.ToString());
            }

            


        }

        private Boolean is_invalid()
        {
            Boolean invalid = false;
            lblRegNoError.Text = "";lblFirstNameError.Text = "";lblLastNameError.Text = "";
            lblContactError.Text = "";lblEmailError.Text = "";lblDOBError.Text = "";
            lblGenderError.Text = "";

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); //regex expression for email
            Match match = regex.Match(txtBxEmail.Text);
            if (!is_editMode() && existAlready())
            {
                invalid = true;
            }
         
            if (txtBxReg.Text.Count() != 11 || !txtBxReg.Text.Split('-')[0].All(Char.IsDigit) || txtBxReg.Text[4] != '-' || txtBxReg.Text[7] != '-' ||
                !txtBxReg.Text.Split('-')[1].All(Char.IsLetter) || !txtBxReg.Text.Split('-')[2].All(Char.IsDigit) ||
            !txtBxReg.Text.Split('-')[1].All(Char.IsUpper))
            {
                lblRegNoError.Text = "Invalid Registration Number hint(2016-CS-311)";
                   invalid = true;
            }
            if(txtBxFirstName.Text.Any(Char.IsDigit) || txtBxFirstName.Text == "")
            {
                lblFirstNameError.Text = "Invalid First Name";
                invalid = true;
            }
            if (txtBxLastName.Text.Any(Char.IsDigit) || txtBxLastName.Text == "")
            {
                lblLastNameError.Text = "Invalid Last Name";
                invalid = true;
            }
            if (txtBxContact.Text.Count()!=11 || !txtBxContact.Text.All(Char.IsDigit))
            {
                lblContactError.Text = "Invalid Contact Number hint(03082345678)";
                invalid = true;
            }
            if (txtBxEmail.Text == "" || txtBxEmail.Text.Count() < 13 || !match.Success) 
            {
                lblEmailError.Text = "Invalid Email";
                invalid = true;
            }
            if (Convert.ToDateTime(dateTimePickerDOB.Value).Year>=DateTime.Now.Year-15)
            {
                lblDOBError.Text = "Invalid date of Birth hint(less than 2004)";
                invalid = true;
            }
            if(cmbBxGender.Text.Any(Char.IsDigit) || cmbBxGender.Text == "")
            {
                lblGenderError.Text = "Invalid Gender Selection";
                invalid = true;
            }
           return invalid;
   }

        private Boolean existAlready()
        {
            Boolean isExist = false;
            string query = string.Format("select RegistrationNo from Student");
            var existStudent = DataBaseConnection.getInstance().readData(query);
            while (existStudent.Read())
            {
                if (existStudent.GetString(0) == txtBxReg.Text)
                {
                    lblRegNoError.Text = "RegNo exist Already";
                    isExist = true;
                    break;
                }
            }
            string queryEmail = string.Format("select Email from Person");
            var existEmail = DataBaseConnection.getInstance().readData(queryEmail);
            while (existEmail.Read())
            {

                if (existEmail.GetString(0) == txtBxEmail.Text)
                {

                    lblEmailError.Text = "Email Already Exist";
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            GeneralID.selectedObjectid = 0; //reset it to zero after successfull update
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
