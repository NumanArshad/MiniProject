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
            showStudentGroupsGridView.BorderStyle = BorderStyle.None;
            showStudentGroupsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            showStudentGroupsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            showStudentGroupsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            showStudentGroupsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            showStudentGroupsGridView.BackgroundColor = Color.White;

            showStudentGroupsGridView.EnableHeadersVisualStyles = false;
            showStudentGroupsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            showStudentGroupsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            showStudentGroupsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            showStudentGroupsGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            showStudentGroupsGridView.Columns.Add(delbtn);
        }

        private void load_data_in_gridview()
        {
            if (showStudentGroupsGridView.Rows.Count > 0)
            {
                table.Clear();
            }

            string query = "select GroupStudent.GroupId,Student.RegistrationNo,Lookup.Value,GroupStudent.AssignmentDate from GroupStudent  join Student on GroupStudent.StudentId=Student.Id join Lookup on Lookup.Id=GroupStudent.Status";
            var lst = DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            showStudentGroupsGridView.DataSource = table;
        }


        int selectedrow;

        private void showStudentGroupsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = showStudentGroupsGridView.CurrentCell.RowIndex;
            DataGridViewRow row = showStudentGroupsGridView.Rows[selectedrow];

           if (e.ColumnIndex == 4)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Make_Group makeGroup = new Make_Group();
                this.Hide();
                makeGroup.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dr = MessageBox.Show("Are you sure want remove this Student from  Group", "Remove Student", MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    string selectStudent = row.Cells[1].Value.ToString();
                    MessageBox.Show(selectStudent.Length.ToString());
                    string deleteStudentQuery = string.Format("delete GroupStudent where StudentId=(select Id from Student where RegistrationNo='{0}')", selectStudent);
                    DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);

                    //if group students delete then total group remove as well as assign project removed
                    int groupId = (int)row.Cells[0].Value;
                    string query = string.Format("select count(GroupId) from GroupStudent where GroupId='{0}'", groupId);
                    int countStudent = DataBaseConnection.getInstance().getRowsCount(query);
                    if (countStudent == 0)
                    {
                        MessageBox.Show("yes its zero");
                      

                        string deleteAssignGroupProject = string.Format("delete GroupProject where GroupId='{0}'", groupId);
                        DataBaseConnection.getInstance().executeQuery(deleteAssignGroupProject);
                        string deletenGroupEvaluation = string.Format("delete GroupEvaluation where GroupId='{0}'", groupId);
                        DataBaseConnection.getInstance().executeQuery(deletenGroupEvaluation);
                        string deleteTotalGroup = string.Format("delete [[Group]]] where Id='{0}'", groupId);
                        DataBaseConnection.getInstance().executeQuery(deleteTotalGroup);
                      
                        MessageBox.Show("Total group,its evaluations and assign project remove as Group Empty");
                    }

                    MessageBox.Show("Student Remove Successfully");
                    this.load_data_in_gridview();

                }
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void manageGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Group_Evaluations groupEvaluation = new Manage_Group_Evaluations();
            this.Hide();
            groupEvaluation.Show();
        }
    }
}
