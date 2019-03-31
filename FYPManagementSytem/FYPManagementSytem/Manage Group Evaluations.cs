
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
    public partial class Manage_Group_Evaluations : Form
    {
        public Manage_Group_Evaluations()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        Boolean isEditMode = false;
        private void Manage_Group_Evaluations_Load(object sender, EventArgs e)
        {
            groupEvaluationGridView.BorderStyle = BorderStyle.None;
            groupEvaluationGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            groupEvaluationGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            groupEvaluationGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            groupEvaluationGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            groupEvaluationGridView.BackgroundColor = Color.White;

            groupEvaluationGridView.EnableHeadersVisualStyles = false;
            groupEvaluationGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            groupEvaluationGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            groupEvaluationGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_Data_In_GridView();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            groupEvaluationGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            groupEvaluationGridView.Columns.Add(delbtn);

        }
        public void load_Data_In_GridView()
        {
            
            cmbBxGroup.Items.Clear(); cmbBxEvaluation.Items.Clear();txtBxObtainedMark.Text = "";
            string queryGroup = "select Id from [[Group]]]";
            var Groupdata = DataBaseConnection.getInstance().readData(queryGroup);
            while (Groupdata.Read())
            {
                cmbBxGroup.Items.Add((int)Groupdata.GetValue(0));
            }

            string queryEvaluation = "select Name from Evaluation";
            var evaluationdata = DataBaseConnection.getInstance().readData(queryEvaluation);
            while (evaluationdata.Read())
            {
                cmbBxEvaluation.Items.Add(evaluationdata.GetString(0));
            }
            //  groupProjectGridView.Rows.Clear();
            if (groupEvaluationGridView.Rows.Count > 0)
            {
                table.Clear();
            }
            string queryGroupProject = "select GroupEvaluation.GroupId,Evaluation.Name,GroupEvaluation.ObtainedMarks,GroupEvaluation.EvaluationDate from GroupEvaluation join Evaluation on GroupEvaluation.EvaluationId=Evaluation.Id";
            var lst = DataBaseConnection.getInstance().getAllData(queryGroupProject);
            lst.Fill(table);
            groupEvaluationGridView.DataSource = table;
        }
        string prevEvaluation;
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!is_invalid())
            {
                if (!isEditMode)
                {

                    string queryInsert = string.Format("insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate) values('{0}',(select Id from Evaluation where Name='{1}'),'{2}','{3}')", cmbBxGroup.Text, cmbBxEvaluation.Text, int.Parse(txtBxObtainedMark.Text), DateTime.Now);
                    DataBaseConnection.getInstance().executeQuery(queryInsert);
                    MessageBox.Show("added success");
                    //   cmbBxGroup.Text = ""; cmbBxEvaluation.Text = ""; txtBxObtainedMark.Text = "";
                    this.load_Data_In_GridView();
                }

                else
                {
                    string queryUpdate = string.Format("update GroupEvaluation set EvaluationId=(select Id from Evaluation where Name='{0}'),ObtainedMarks='{1}' where GroupId='{2}' and EvaluationId=(select Id from Evaluation where Name='{3}')", cmbBxEvaluation.Text, int.Parse(txtBxObtainedMark.Text), cmbBxGroup.Text, prevEvaluation);
                    DataBaseConnection.getInstance().executeQuery(queryUpdate);
                    MessageBox.Show("update success");
                    //   cmbBxGroup.Text = ""; cmbBxEvaluation.Text = ""; txtBxObtainedMark.Text = "";
                    isEditMode = false;
                    cmbBxGroup.Enabled = true;
                    this.load_Data_In_GridView();
                }
            }
            
        }

        private Boolean is_invalid()
        {
            Boolean invalid = false, isCurrentAdvisor = false;
            lblform.Text = "";
            string checkCount = string.Format("select count(EvaluationId) from GroupEvaluation where GroupId='{0}' and EvaluationId=(select Id from Evaluation where Evaluation.Name='{1}')", cmbBxGroup.Text, cmbBxEvaluation.Text);
            int countEvaluation = DataBaseConnection.getInstance().getRowsCount(checkCount);

        try {
                string getTotalMarks = string.Format("select TotalMarks from  Evaluation where Name='{0}'", cmbBxEvaluation.Text);
                int totalMarks = DataBaseConnection.getInstance().getRowsCount(getTotalMarks);
                //  MessageBox.Show(totalMarks.ToString());
                if (isEditMode)
                {
                    foreach (DataGridViewRow row in groupEvaluationGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == cmbBxGroup.Text && row.Cells[1].Value.ToString() == cmbBxEvaluation.Text && row.Cells[2].Value.ToString() == txtBxObtainedMark.Text)
                        {
                            isCurrentAdvisor = true;
                            break;

                        }


                    }
                    if (!isCurrentAdvisor)
                    {
                        if (countEvaluation > 0)
                        {

                            lblform.Text = "Evaluation Already exist for that group"; invalid = true;
                        }
                        else if (!txtBxObtainedMark.Text.All(Char.IsDigit))
                        {
                            lblform.Text = "Marks should be integer"; invalid = true;
                        }
                        else if (int.Parse(txtBxObtainedMark.Text) > totalMarks)
                        {
                            lblform.Text = "Obtained Marks should not be greater than total marks"; invalid = true;
                        }
                    }
                }
                else
                {
                    if (countEvaluation > 0)
                    {

                        lblform.Text = "Evaluation Already exist for that group"; invalid = true;
                    }
                    else if (!txtBxObtainedMark.Text.All(Char.IsDigit))
                    {
                        lblform.Text = "Marks should be integer"; invalid = true;
                    }
                    else if (int.Parse(txtBxObtainedMark.Text) > totalMarks)
                    {
                        lblform.Text = "Obtained Marks should not be greater than total marks"; invalid = true;
                    }
                }
            }
            catch
            {
             //   if (cmbBxGroup.Text == "" || cmbBxEvaluation.Text == "" || txtBxObtainedMark.Text == "")
              //  {
                    lblform.Text = "Your missing some entry"; invalid = true;

               // }

            }
           
            return invalid;
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
        int selectedrow;
        private void groupEvaluationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = groupEvaluationGridView.CurrentCell.RowIndex;
            DataGridViewRow row = groupEvaluationGridView.Rows[selectedrow];

            if (e.ColumnIndex == 4)
            {
                cmbBxGroup.Enabled = false;
                cmbBxGroup.Text = row.Cells[0].Value.ToString();
               cmbBxEvaluation.Text = row.Cells[1].Value.ToString();
                txtBxObtainedMark.Text= row.Cells[2].Value.ToString();
                prevEvaluation= row.Cells[1].Value.ToString(); 
                isEditMode = true;

            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dr = MessageBox.Show("Are you sure want remove this Evaluation for Group", "Delete Group Evaluation", MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    int selectId = (int)row.Cells[0].Value;
                    string selectedEvaluation= row.Cells[1].Value.ToString();
                    string delGroupEvaluationQuery = string.Format("delete GroupEvaluation where GroupId='{0}' and EvaluationId=(select Id from Evaluation where Name='{1}')", selectId,selectedEvaluation);
                    DataBaseConnection.getInstance().executeQuery(delGroupEvaluationQuery);
                    MessageBox.Show("deleted successfully");
                    cmbBxGroup.Enabled = true;
                    this.load_Data_In_GridView();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
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
