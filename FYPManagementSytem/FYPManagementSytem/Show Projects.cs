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
    public partial class Show_Projects : Form
    {
        public Show_Projects()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Show_Projects_Load(object sender, EventArgs e)
        {

            projectsGridView.BorderStyle = BorderStyle.None;
            projectsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            projectsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            projectsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            projectsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            projectsGridView.BackgroundColor = Color.White;

            projectsGridView.EnableHeadersVisualStyles = false;
            projectsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            projectsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            projectsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            projectsGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            projectsGridView.Columns.Add(delbtn);
        }

        private void load_data_in_gridview()
        {
            if (projectsGridView.Rows.Count > 0)
            {
                table.Clear();
            }

            string query = "select * from Project";
            var lst = DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            projectsGridView.DataSource = table;
        }
        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            
           Add_Project add = new Add_Project();
            this.Hide();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        int selectedrow;
        private void projectsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = projectsGridView.CurrentCell.RowIndex;
            DataGridViewRow row = projectsGridView.Rows[selectedrow];

            if (e.ColumnIndex == 3)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Add_Project add = new Add_Project();
                this.Hide();
                add.Show();
            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("Are you sure want delete this Project", "Delete Project", MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string deleteStudentQuery = string.Format("delete Project where Id='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);

                    MessageBox.Show("Project deleted Successfully");
                    this.load_data_in_gridview();

                }

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
