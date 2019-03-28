﻿using System;
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
    public partial class Project_Students_AdvisorBoard_Report_Preview : Form
    {
        public Project_Students_AdvisorBoard_Report_Preview()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Project_Students_AdvisorBoard_Report_Preview_Load(object sender, EventArgs e)
        {
            StudentAdvisorBoardGridView.BorderStyle = BorderStyle.None;
            StudentAdvisorBoardGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            StudentAdvisorBoardGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StudentAdvisorBoardGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            StudentAdvisorBoardGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            StudentAdvisorBoardGridView.BackgroundColor = Color.White;

            StudentAdvisorBoardGridView.EnableHeadersVisualStyles = false;
            StudentAdvisorBoardGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            StudentAdvisorBoardGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            StudentAdvisorBoardGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            string query = "select  GroupProject.GroupId,ProjectAdvisor.AdvisorId, Project.Title,Student.RegistrationNo from ProjectAdvisor join GroupProject on ProjectAdvisor.ProjectId=GroupProject.ProjectId  join Project on GroupProject.ProjectId=Project.Id join GroupStudent on GroupProject.GroupId=GroupStudent.GroupId join Student on GroupStudent.StudentId=Student.Id ";
            var data = DataBaseConnection.getInstance().getAllData(query);
            data.Fill(table);
            StudentAdvisorBoardGridView.DataSource = table;


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();

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
