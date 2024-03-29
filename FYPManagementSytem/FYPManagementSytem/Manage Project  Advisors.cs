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
    public partial class Manage_Project__Advisors : Form
    {
        public Manage_Project__Advisors()
        {
            InitializeComponent();
        }

        private void Manage_Project__Advisors_Load(object sender, EventArgs e)
        {
            projectAdvisorGridView.BorderStyle = BorderStyle.None;
            projectAdvisorGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            projectAdvisorGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            projectAdvisorGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            projectAdvisorGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            projectAdvisorGridView.BackgroundColor = Color.White;

            projectAdvisorGridView.EnableHeadersVisualStyles = false;
            projectAdvisorGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            projectAdvisorGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            projectAdvisorGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

         
            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            projectAdvisorGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            projectAdvisorGridView.Columns.Add(delbtn);
        }

        Boolean isEditMode = false;
        string previousProject,advisor, advisorRole;
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!is_invalid())
            {
                if (!isEditMode)
                {



                    string insertQuery = string.Format("insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate) values('{0}',(select Id from Project where Title='{1}'),(select Id from Lookup where Value='{2}'),'{3}')", cmbBxAdvisors.Text, cmbBxProjects.Text, cmbBxAdvisorRoles.Text, DateTime.Now);
                    DataBaseConnection.getInstance().executeQuery(insertQuery);
                    MessageBox.Show("Insert Success");
                    this.load_data_in_gridview();

                }
                else
                {



                    string insertQuery = string.Format("update ProjectAdvisor set ProjectId=(select Id from Project where Title='{0}') where AdvisorId='{1}' and ProjectId=(select Id from Project where Title='{2}') and AdvisorRole=(select Id from Lookup where Value='{3}')", cmbBxProjects.Text, cmbBxAdvisors.Text, previousProject, cmbBxAdvisorRoles.Text);
                    DataBaseConnection.getInstance().executeQuery(insertQuery);
                    MessageBox.Show("update success");
                    this.load_data_in_gridview();
                    isEditMode = false;
                }
            }

          
        }
        DataTable table = new DataTable();
     
        public void load_data_in_gridview()
        {
            cmbBxAdvisors.Text = "";cmbBxProjects.Text = "";cmbBxAdvisorRoles.Text = "";
            cmbBxAdvisors.Items.Clear();cmbBxProjects.Items.Clear();cmbBxAdvisorRoles.Items.Clear();
            cmbBxAdvisors.Enabled = true;
            string queryAdvisor = "select Id from Advisor";
            var advisordata = DataBaseConnection.getInstance().readData(queryAdvisor);
            while (advisordata.Read())
            {
                cmbBxAdvisors.Items.Add((int)advisordata.GetValue(0));
            }

            string queryTitle = "select Title from Project";
            var titledata = DataBaseConnection.getInstance().readData(queryTitle);
            while (titledata.Read())
            {
                cmbBxProjects.Items.Add(titledata.GetString(0));
            }

            string queryAdvisorRole = "select Value from Lookup where Category='ADVISOR_ROLE'";
            var Rolesdata = DataBaseConnection.getInstance().readData(queryAdvisorRole);
            while (Rolesdata.Read())
            {
                cmbBxAdvisorRoles.Items.Add(Rolesdata.GetString(0));
            }

            if (projectAdvisorGridView.Rows.Count > 0)
            {
                table.Clear();
            }
            string query = "select ProjectAdvisor.AdvisorId,Project.Title,Lookup.Value from ProjectAdvisor  join Project on Project.Id=ProjectAdvisor.ProjectId  join Lookup on ProjectAdvisor.AdvisorRole=Lookup.Id order by Project.Title ";
            var lst=DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            projectAdvisorGridView.DataSource = table;
        }

        private Boolean is_invalid()
        {
            Boolean invalid = false, isCurrent = false;
            lblform.Text = "";

            try
            {
                string AdvisorRoleExistQuery = string.Format("select AdvisorId from ProjectAdvisor where AdvisorRole=(select Id from Lookup where Value='{0}') and ProjectId=(select Id from Project where Title='{1}')",cmbBxAdvisorRoles.Text,cmbBxProjects.Text);
                int Role = DataBaseConnection.getInstance().getRowsCount(AdvisorRoleExistQuery);
                

                string AdvisorExistQuery = string.Format("select count(ProjectId) from ProjectAdvisor where AdvisorId='{0}' and ProjectId=(select Id from Project where Title='{1}')",cmbBxAdvisors.Text,cmbBxProjects.Text);
                int count = DataBaseConnection.getInstance().getRowsCount(AdvisorExistQuery);

                if (isEditMode)
                {
                    if (cmbBxAdvisors.Text == advisor && cmbBxProjects.Text == previousProject && cmbBxAdvisorRoles.Text == advisorRole)
                    {
                        isCurrent = true;
                    }
                    if (!isCurrent)
                    {
                        if (count > 0)
                        {

                            lblform.Text = "This Advisor is already assign to this project"; invalid = true;
                        }
                        else if (Role > 0)
                        {

                            lblform.Text = "This Project already has advisor with same role"; invalid = true;
                        }

                    }

                }
                else
                {
                    if (count > 0)
                    {

                        lblform.Text = "This Advisor is already assign to this project"; invalid = true;
                    }
                    else if (Role > 0)
                    {

                        lblform.Text = "This Project already has advisor with same role"; invalid = true;
                    }
                }



            }
            catch {
                if (cmbBxAdvisors.Text == "" || cmbBxProjects.Text == "" || cmbBxAdvisorRoles.Text == "")
                {
                    lblform.Text = "Incomplete Entry"; invalid = true;
                }
            }

   

            




            return invalid;
        }


        private void button1_Click(object sender, EventArgs e)
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

        int selectedrow;
        private void projectAdvisorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = projectAdvisorGridView.CurrentCell.RowIndex;
            DataGridViewRow row = projectAdvisorGridView.Rows[selectedrow];

            if (e.ColumnIndex == 3)
            {
              
                cmbBxAdvisors.Text = row.Cells[0].Value.ToString();
                advisor =  row.Cells[0].Value.ToString();
                cmbBxProjects.Text = row.Cells[1].Value.ToString();
                previousProject= row.Cells[1].Value.ToString();
                cmbBxAdvisorRoles.Text = row.Cells[2].Value.ToString();
               advisorRole=row.Cells[2].Value.ToString();
                cmbBxAdvisors.Enabled = false;
                isEditMode = true;

            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("Are you sure want delete this Project Advisor", "Delete Project Advisor", MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectAdvisorId = (int)row.Cells[0].Value;
                    string selectProject = row.Cells[1].Value.ToString();
                
                  string deleteStudentQuery = string.Format("delete ProjectAdvisor where AdvisorId='{0}' and ProjectId=(select Id from Project where Title='{1}')", selectAdvisorId, selectProject);
                    DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);

                    MessageBox.Show("Project Advisor deleted Successfully");
                    this.load_data_in_gridview();

                }

            }
        }

        private void manageGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Group_Evaluations groupEvaluation = new Manage_Group_Evaluations();
            this.Hide();
            groupEvaluation.Show();
        }

        private void assignProjectsReportPreviewToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
