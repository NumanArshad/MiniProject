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
    public partial class Manage_Student_Groups : Form
    {
        public Manage_Student_Groups()
        {
            InitializeComponent();
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            Make_Group make_group = new Make_Group();
            this.Hide();
            make_group.Show();
        }
        DataTable table = new DataTable();
        private void Manage_Student_Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectADataSet1.GroupStudent' table. You can move, or remove it, as needed.
            // this.groupStudentTableAdapter.Fill(this.projectADataSet1.GroupStudent);
            string query = "select GroupStudent.GroupId,Student.RegistrationNo,Lookup.Value,GroupStudent.AssignmentDate from GroupStudent  join Student on GroupStudent.StudentId=Student.Id join Lookup on Lookup.Id=GroupStudent.Status";
                 var lst = DataBaseConnection.getInstance().getAllData(query);
               lst.Fill(table);

          
            showStudentGroupsGridView.DataSource = table;
}
      
       
          

        

        private void showStudentGroupsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
