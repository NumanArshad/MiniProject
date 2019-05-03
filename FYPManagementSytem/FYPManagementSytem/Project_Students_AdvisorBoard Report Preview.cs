using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<AdvisorsProjectReport> projectReportList;
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

            string query = "select  GroupProject.GroupId,ProjectAdvisor.AdvisorId,Lookup.Value,Project.Title,Student.RegistrationNo,Person.FirstName + ' '+Person.LastName from ProjectAdvisor join Lookup on Lookup.Id=ProjectAdvisor.AdvisorRole  join GroupProject on ProjectAdvisor.ProjectId=GroupProject.ProjectId  join Project on GroupProject.ProjectId=Project.Id join GroupStudent on GroupProject.GroupId=GroupStudent.GroupId join Student on GroupStudent.StudentId=Student.Id join Person on Person.Id=Student.Id";
            //   var data = DataBaseConnection.getInstance().getAllData(query);
            //    data.Fill(table);
            var data = DataBaseConnection.getInstance().readData(query);
            projectReportList = new List<AdvisorsProjectReport>();
            while (data.Read())
            {
                Boolean isExist = false;
                AdvisorsProjectReport report = new AdvisorsProjectReport();
                report.GroupId = (int)data.GetValue(0);
                report.Advisor = data.GetValue(1).ToString() + '(' + data.GetString(2) + ')';
                report.Title = data.GetString(3);
                report.Student = data.GetString(4)+'(' + data.GetString(5)+')';
                foreach(AdvisorsProjectReport obj in projectReportList)
                {
                    if (obj.GroupId == report.GroupId)
                    {
                        isExist = true;
                      
                        if (!obj.Advisor.Contains(report.Advisor))
                        {
                            obj.Advisor += "\n" + report.Advisor;

                        }
                        if (!obj.Student.Contains(report.Student))
                        {
                            obj.Student += "\n" + report.Student;

                        }
                    }
                }
                if (!isExist)
                {
                    projectReportList.Add(report);
                }
            }
            StudentAdvisorBoardGridView.DataSource = projectReportList;//table;


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

        private void StudentAdvisorBoardGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdExportPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {


                        Document document = new Document();

                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                        document.Open();

                        PdfPTable pdftable = new PdfPTable(StudentAdvisorBoardGridView.Columns.Count);
                        pdftable.WidthPercentage = 100;

                        Paragraph prgAuthor = new Paragraph();
                        BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        //    System.Drawing.Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
                        //  Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
                        prgAuthor.Alignment = Element.ALIGN_LEFT;
                        prgAuthor.Add(new Chunk("Students Advisor Board Report"));
                        prgAuthor.Add(new Chunk("\n Date : " + DateTime.Now.ToShortDateString() + "\n\n"));
                        document.Add(prgAuthor);


                        //Set columns names in the pdf file
                        for (int k = 0; k < StudentAdvisorBoardGridView.Columns.Count; k++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(StudentAdvisorBoardGridView.Columns[k].Name));

                            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);


                            pdftable.AddCell(cell);
                        }

                        //Add values of DataTable in pdf file
                        for (int i = 0; i < StudentAdvisorBoardGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < StudentAdvisorBoardGridView.Columns.Count; j++)
                            {
                                //  MessageBox.Show(evaluationDetailGridView.Rows[i].Cells[j].Value.ToString());
                                PdfPCell cell = new PdfPCell(new Phrase(StudentAdvisorBoardGridView.Rows[i].Cells[j].Value.ToString()));

                                //Align the cell in the center
                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                                pdftable.AddCell(cell);
                            }
                        }

                        document.Add(pdftable);
                        document.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
