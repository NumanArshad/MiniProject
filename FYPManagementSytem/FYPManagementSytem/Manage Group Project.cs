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
    public partial class Manage_Group_Project : Form
    {
        public Manage_Group_Project()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        Boolean isEditMode = false;
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                if (!is_invalid())
                {
                    string assignProjectQuery = string.Format("insert into GroupProject(ProjectId,GroupId,AssignmentDate) values((select Id from Project where Title='{0}'),'{1}','{2}')", cmbBxProjects.Text, cmbBxGroups.Text, Convert.ToDateTime(DateTime.Now));
                    DataBaseConnection.getInstance().executeQuery(assignProjectQuery);


                    string updateGroupStatuQuery = string.Format("update GroupStudent set Status='{0}' where GroupId='{1}'", 3, cmbBxGroups.Text);
                    DataBaseConnection.getInstance().executeQuery(updateGroupStatuQuery);
                }
            }
            else
            {
                string assignProjectQuery = string.Format("update GroupProject set ProjectId=(select Id from Project where Title='{0}') where GroupId='{1}'", cmbBxProjects.Text, cmbBxGroups.Text);
                DataBaseConnection.getInstance().executeQuery(assignProjectQuery);
                isEditMode = false;
            }

         
            this.load_Data_In_GridView();
        }
        public void load_Data_In_GridView()
        {
            cmbBxProjects.Text = ""; cmbBxGroups.Text = "";
            cmbBxGroups.Items.Clear();cmbBxProjects.Items.Clear();
            string queryProject = "select Title from Project where not Exists(select * from GroupProject where ProjectId=Project.Id)";
            var titledata = DataBaseConnection.getInstance().readData(queryProject);
            while (titledata.Read())
            {
                cmbBxProjects.Items.Add(titledata.GetString(0));
            }

            string queryGroups = "select Id from [Group] where not Exists(select * from GroupProject where GroupId=[Group].Id)";
            var groupdata = DataBaseConnection.getInstance().readData(queryGroups);
            while (groupdata.Read())
            {
                cmbBxGroups.Items.Add((int)groupdata.GetValue(0));
            }
            //  groupProjectGridView.Rows.Clear();
            if (groupProjectGridView.Rows.Count > 0)
            {
                table.Clear();
            }
            string queryGroupProject = "select GroupProject.GroupId,Project.Title,GroupProject.AssignmentDate from GroupProject join Project on GroupProject.ProjectId=Project.Id";
            var lst = DataBaseConnection.getInstance().getAllData(queryGroupProject);
            lst.Fill(table);
            groupProjectGridView.DataSource = table;
        }

        private Boolean is_invalid()
        {
            Boolean invalid = false;
            lblform.Text = "";

            if (cmbBxProjects.Text=="" || cmbBxGroups.Text=="")
            {
                lblform.Text = "Incomplete Entry"; invalid = true;
            }
         



            return invalid;
        }
        private void Manage_Group_Project_Load(object sender, EventArgs e)
        {
            groupProjectGridView.BorderStyle = BorderStyle.None;
            groupProjectGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            groupProjectGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            groupProjectGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            groupProjectGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            groupProjectGridView.BackgroundColor = Color.White;

            groupProjectGridView.EnableHeadersVisualStyles = false;
            groupProjectGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            groupProjectGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            groupProjectGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

         

            this.load_Data_In_GridView();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            groupProjectGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            groupProjectGridView.Columns.Add(delbtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        int selectedrow;
        private void groupProjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = groupProjectGridView.CurrentCell.RowIndex;
            DataGridViewRow row = groupProjectGridView.Rows[selectedrow];

            if (e.ColumnIndex == 3)
            {
               

                if (!cmbBxProjects.Items.Contains(row.Cells[1].Value.ToString()))
                {
                    cmbBxProjects.Items.Add(row.Cells[1].Value.ToString());
                    cmbBxProjects.Text = row.Cells[1].Value.ToString();
                }
                if (!cmbBxGroups.Items.Contains(row.Cells[0].Value.ToString()))
                {
                    cmbBxGroups.Items.Add(row.Cells[0].Value.ToString());
                    cmbBxGroups.Text = row.Cells[0].Value.ToString();
                }

                isEditMode =true;

            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("Are you sure want remove this Group from project", "Delete Project Group", MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string deletegroupProjectQuery = string.Format("delete GroupProject where GroupId='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deletegroupProjectQuery);

                    string deletegroupEvalutionQuery = string.Format("delete GroupEvaluation where GroupId='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deletegroupEvalutionQuery);

                    MessageBox.Show("group Project deleted Successfully");

                    string updateGroupStatuQuery = string.Format("update GroupStudent set Status='{0}' where GroupId='{1}'", 4, selectId.ToString());
                    DataBaseConnection.getInstance().executeQuery(updateGroupStatuQuery);

                    this.load_Data_In_GridView();


                }
            }
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
    }
}
