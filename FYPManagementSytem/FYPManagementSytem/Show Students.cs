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
    public partial class Show_Students : Form
    {
        public Show_Students()
        {
            InitializeComponent();
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
           
            Add_Student add_new =new  Add_Student();
            this.Hide();
            add_new.Show();
        }
        DataTable table = new DataTable();
        private void Show_Students_Load(object sender, EventArgs e)
        {
            studentsGridView1.BorderStyle = BorderStyle.None;
            studentsGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            studentsGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentsGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            studentsGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            studentsGridView1.BackgroundColor = Color.White;

            studentsGridView1.EnableHeadersVisualStyles = false;
            studentsGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            studentsGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            studentsGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            studentsGridView1.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            studentsGridView1.Columns.Add(delbtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
        int selected;
        private void studentsGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = studentsGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = studentsGridView1.Rows[selected];
           
            if (e.ColumnIndex == 8)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Add_Student add = new Add_Student();
                this.Hide();
                add.Show();
            }
            else if (e.ColumnIndex == 9)
            {
                DialogResult dr = MessageBox.Show("Are you sure want delete this Student", "Delete Student", MessageBoxButtons.OKCancel,
       MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string deleteStudentQuery = string.Format("delete Student where Id='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);


                    string deletePersonQuery = string.Format("delete Person where Id='{0}'", selectId);
                    DataBaseConnection.getInstance().executeQuery(deletePersonQuery);


                    MessageBox.Show("Student deleted Successfully");
                    this.load_data_in_gridview();
                }
              

            }


        }
        private void load_data_in_gridview()
        {
            if (studentsGridView1.Rows.Count > 0)
            {
                table.Clear();
            }

            string query = "select Person.Id,Student.RegistrationNo,Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,Lookup.Value as Gender from Person join Student on Person.Id=Student.Id join Lookup on Lookup.Id=Person.Gender";
            var lst = DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            studentsGridView1.DataSource = table;
        }

        private void showProjectAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Project__Advisors projectAdvisor = new Manage_Project__Advisors();
            this.Hide();
            projectAdvisor.Show();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
