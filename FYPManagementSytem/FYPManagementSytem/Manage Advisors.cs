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
    public partial class Manage_Advisors : Form
    {
        
       
        public Manage_Advisors()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
      
        private void Manage_Advisors_Load(object sender, EventArgs e)
        {

            advisorsGridView.BorderStyle = BorderStyle.None;
            advisorsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            advisorsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            advisorsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            advisorsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            advisorsGridView.BackgroundColor = Color.White;

            advisorsGridView.EnableHeadersVisualStyles = false;
            advisorsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            advisorsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            advisorsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();
            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            advisorsGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            advisorsGridView.Columns.Add(delbtn);
        }

       
        private void load_data_in_gridview()
        {
            if (advisorsGridView.Rows.Count > 0)
            {
               table.Clear();
               
            }

            string advisorsQuery = "select Advisor.Id,Lookup.Value as Designation,Advisor.Salary from Advisor join Lookup on Advisor.Designation=Lookup.Id";
            var advisors = DataBaseConnection.getInstance().getAllData(advisorsQuery);
            advisors.Fill(table);
            advisorsGridView.DataSource = table;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
           
            Add_Advisor newAdvisor = new Add_Advisor();
            this.Hide();
            newAdvisor.Show();
        }
        int selectedrow;
        private void advisorsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = advisorsGridView.CurrentCell.RowIndex;
            DataGridViewRow row = advisorsGridView.Rows[selectedrow];

            if (e.ColumnIndex == 3)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Add_Advisor add = new Add_Advisor();
                this.Hide();
                add.Show();
            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("Are you sure want delete this Advisor", "Delete Advisor", MessageBoxButtons.OKCancel,
       MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string deleteAdvisorQuery = string.Format("delete Advisor where Id='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deleteAdvisorQuery);

                    MessageBox.Show("Advisor deleted Successfully");
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
