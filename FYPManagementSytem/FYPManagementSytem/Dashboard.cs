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
    public partial class Dashboard : Form
    {
      
        public Dashboard()
        {
            InitializeComponent();
        }
     
        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdManageStudents_Click(object sender, EventArgs e)
        {
            Show_Students showStudent = new Show_Students();
            this.Hide();
            showStudent.Show();
        }

        private void cmdManageProjects_Click(object sender, EventArgs e)
        {
            Show_Projects showProject = new Show_Projects();
            this.Hide();
            showProject.Show();
        }

        private void cmdManageAdvisors_Click(object sender, EventArgs e)
        {
            Manage_Advisors manage_advisor = new Manage_Advisors();
            this.Hide();
            manage_advisor.Show();
        }

        private void cmdStudentGroups_Click(object sender, EventArgs e)
        {
            Manage_Student_Groups msg = new Manage_Student_Groups();
            this.Hide();
            msg.Show();
        }

        private void cmdGroupProject_Click(object sender, EventArgs e)
        {
            Manage_Group_Project mgp = new Manage_Group_Project();
            this.Hide();
            mgp.Show();
        }

        private void cmdProjectAdvisors_Click(object sender, EventArgs e)
        {
            Manage_Project__Advisors MPA = new Manage_Project__Advisors();
            this.Hide();
            MPA.Show();
        }
    }
}
