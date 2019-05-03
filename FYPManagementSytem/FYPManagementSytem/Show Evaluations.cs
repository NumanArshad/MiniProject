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
    public partial class Show_Evaluations : Form
    {
        public Show_Evaluations()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Show_Evaluations_Load(object sender, EventArgs e)
        {
            evaluationsGridView.BorderStyle = BorderStyle.None;
            evaluationsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            evaluationsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            evaluationsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            evaluationsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            evaluationsGridView.BackgroundColor = Color.White;

            evaluationsGridView.EnableHeadersVisualStyles = false;
            evaluationsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            evaluationsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            evaluationsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            evaluationsGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            evaluationsGridView.Columns.Add(delbtn);
        }
        private void load_data_in_gridview()
        {
            if (evaluationsGridView.Rows.Count > 0)
            {
                table.Clear();
            }

            string query = "select * from Evaluation";
            var lst = DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            evaluationsGridView.DataSource = table;
        }
        int selectedRow;
        private void evaluationsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = evaluationsGridView.CurrentCell.RowIndex;
            DataGridViewRow row = evaluationsGridView.Rows[selectedRow];

            if (e.ColumnIndex == 4)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Add_Evaluation add = new Add_Evaluation();
                this.Hide();
                add.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dr = MessageBox.Show("Are you sure want delete this Evaluation", "Delete Evaluation", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string deleteGroupEvaluationQuery = string.Format("delete GroupEvaluation where EvaluationId='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deleteGroupEvaluationQuery);
                   
                    string deleteStudentQuery = string.Format("delete Evaluation where Id='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);

                    MessageBox.Show("Evaluation deleted Successfully");
                    this.load_data_in_gridview();
                }

            }
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            Add_Evaluation newEvaluation = new Add_Evaluation();
            this.Hide();
            newEvaluation.Show();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
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
