﻿
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
            DataBaseConnection.getInstance().conStr = "Data Source=UET\\NUMANSQL;Initial Catalog=ProjectA;Integrated Security=True";
            try
            {

                DataBaseConnection.getInstance().getConnection();
                MessageBox.Show("Data base connected");
                string queryStudent = "select count(Id) from Student";
                int countStudent = DataBaseConnection.getInstance().getRowsCount(queryStudent);

                string queryProject = "select count(Id) from Project";
                int countProject = DataBaseConnection.getInstance().getRowsCount(queryProject);

                
                string queryAdvisor = "select count(Id) from Advisor";
                int countAdvisor = DataBaseConnection.getInstance().getRowsCount(queryAdvisor);
                string queryGroup = "select count(Id) from [Group]";
             int countGroup = DataBaseConnection.getInstance().getRowsCount(queryGroup);

                         string querySelectedProject = "select count(ProjectId) from GroupProject";
                                int countSelectedProject = DataBaseConnection.getInstance().getRowsCount(querySelectedProject);

                            string queryGroupEvaluation = "select  count(distinct GroupId) from GroupEvaluation";
                                int countGroupEvaluation = DataBaseConnection.getInstance().getRowsCount(queryGroupEvaluation);

                lblCountStudent.Text = countStudent.ToString();
                lblCountProject.Text = countProject.ToString();
                lblCountAdvisor.Text = countAdvisor.ToString();
                lblCountGroup.Text= countGroup.ToString();
                lblCountSelectedProject.Text = countSelectedProject.ToString();
                lblGroupEvaluation.Text = countGroupEvaluation.ToString();
        
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in " + ex.ToString());
            }

        }

        private void showProjectAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Project__Advisors projectAdvisor = new Manage_Project__Advisors();
            this.Hide();
            projectAdvisor.Show();
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Students showStudent = new Show_Students();
            this.Hide();
            showStudent.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student addStudent = new Add_Student();
            this.Hide();
            addStudent.Show();
        }

        private void showProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Projects showProject = new Show_Projects();
            this.Hide();
            showProject.Show();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Project addProject = new Add_Project();
            this.Hide();
            addProject.Show();
        }

        private void showAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Advisors manage_advisor = new Manage_Advisors();
            this.Hide();
            manage_advisor.Show();
        }

        private void addAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Advisor addAdvisor = new Add_Advisor();
            this.Hide();
            addAdvisor.Show();
        }

        private void showEvaluationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Evaluations Evaluation = new Show_Evaluations();
            this.Hide();
            Evaluation.Show();
        }

        private void addEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Evaluation addEvaluation = new Add_Evaluation();
            this.Hide();
            addEvaluation.Show();
                 
        }

        private void showGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Student_Groups studentGroup = new Manage_Student_Groups();
            this.Hide();
            studentGroup.Show();
        }

        private void createGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Make_Group createGroup = new Make_Group();
            this.Hide();
            createGroup.Show();
        }

       private void showProjectGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Group_Project groupProject = new Manage_Group_Project();
            this.Hide();
            groupProject.Show();
        }

        private void manageProjectAdvisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Project__Advisors projectAdvisor = new Manage_Project__Advisors();
            this.Hide();
            projectAdvisor.Show();
        }

        private void manageGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Group_Evaluations groupEvaluation = new Manage_Group_Evaluations();
            this.Hide();
            groupEvaluation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  DGVPrinter print = new DGVPrinter();
              print.SubTitle = "subtitle";
              print.Title = "title";
              print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
              print.Footer = "Fox Learn";
           print.PrintDataGridView()*/
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void advisorProjectStudentReportPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_Students_AdvisorBoard_Report_Preview det = new Project_Students_AdvisorBoard_Report_Preview();
            this.Hide();
            det.Show();
        }

        private void groupEvaluationReportPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Evaluations_Report_Preview det = new Evaluations_Report_Preview();
            this.Hide();
            det.Show();

        }
    }
}
