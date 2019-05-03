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
    public partial class Evaluations_Report_Preview : Form
    {
        public Evaluations_Report_Preview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        DataTable table = new DataTable();
        List<EvaluationsReport> reportList;
        private void Evaluations_Report_Preview_Load(object sender, EventArgs e)
        {
          
            evaluationDetailGridView.BorderStyle = BorderStyle.None;
            evaluationDetailGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            evaluationDetailGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            evaluationDetailGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            evaluationDetailGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            evaluationDetailGridView.BackgroundColor = Color.White;

            evaluationDetailGridView.EnableHeadersVisualStyles = false;
            evaluationDetailGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            evaluationDetailGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            evaluationDetailGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            string query = "select  GroupProject.GroupId,Project.Title,Evaluation.Name,Student.RegistrationNo,Person.FirstName+' '+Person.LastName,GroupEvaluation.ObtainedMarks,Evaluation.TotalMarks,Evaluation.TotalWeightage from GroupProject join GroupEvaluation on GroupProject.GroupId=GroupEvaluation.GroupId join Evaluation on GroupEvaluation.EvaluationId=Evaluation.Id join GroupStudent on GroupProject.GroupId=GroupStudent.GroupId join Project on Project.Id=GroupProject.ProjectId join Student on Student.Id=GroupStudent.StudentId join Person on Person.Id=Student.Id order by GroupProject.GroupId";
              //var data1 = DataBaseConnection.getInstance().getAllData(query);
               // data1.Fill(table);
            //    evaluationDetailGridView.DataSource = table;
            var data = DataBaseConnection.getInstance().readData(query);
            reportList = new List<EvaluationsReport>();
            while (data.Read())
            {
                Boolean isExist = false;
                EvaluationsReport evaluation = new EvaluationsReport();
                  evaluation.GroupId = (int)data.GetValue(0);
                   evaluation.Title = data.GetValue(1).ToString();
                evaluation.Name = data.GetValue(2).ToString();
                evaluation.Student = data.GetValue(3).ToString() + '(' + data.GetValue(4).ToString() + ')';
                evaluation.ObtinedMarks =data.GetValue(5).ToString();
                evaluation.TotalMarks = data.GetValue(6).ToString();
                evaluation.TotalWeightage =data.GetValue(7).ToString();
                foreach (EvaluationsReport rep in reportList)
                {
                  if (rep.GroupId == evaluation.GroupId)
                    {
                        isExist = true;
                       
                        if (!rep.Student.Contains(evaluation.Student))
                        {
                            rep.Student += "\n" + evaluation.Student;
                        }
                        if (!rep.ObtinedMarks.Contains(evaluation.ObtinedMarks))
                        {
                            rep.ObtinedMarks += "\n" + evaluation.ObtinedMarks;
                        }
                        if (!rep.Name.Contains(evaluation.Name))
                        {
                            rep.Name += "\n" + evaluation.Name;
                        }
                        if (!rep.TotalMarks.Contains(evaluation.TotalMarks))
                        {
                            rep.TotalMarks += "\n" + evaluation.TotalMarks;
                        }
                        if (!rep.TotalWeightage.Contains(evaluation.TotalWeightage))
                        {
                            rep.TotalWeightage += "\n" + evaluation.TotalWeightage;
                        }
                        break;
                    }
                  

                }

                if (!isExist)
                {
                    reportList.Add(evaluation);
                }
                
            }
            evaluationDetailGridView.DataSource = reportList;

         
           
            
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

                             PdfPTable pdftable = new PdfPTable(evaluationDetailGridView.Columns.Count);
                             pdftable.WidthPercentage = 100;

                        Paragraph prgAuthor = new Paragraph();
                        BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        //    System.Drawing.Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
                      //  Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
                        prgAuthor.Alignment = Element.ALIGN_LEFT;
                        prgAuthor.Add(new Chunk("Group Evalutions Report"));
                        prgAuthor.Add(new Chunk("\n Date : " + DateTime.Now.ToShortDateString()+"\n\n"));
                        document.Add(prgAuthor);


                        //Set columns names in the pdf file
                        for (int k = 0; k < evaluationDetailGridView.Columns.Count; k++)
                             {
                                 PdfPCell cell = new PdfPCell(new Phrase(evaluationDetailGridView.Columns[k].Name));

                                 cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                 cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                                 cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
                            

                                 pdftable.AddCell(cell);
                             }

                             //Add values of DataTable in pdf file
                             for (int i = 0; i < evaluationDetailGridView.Rows.Count; i++)
                             {
                                 for (int j = 0; j < evaluationDetailGridView.Columns.Count; j++)
                                 {
                                   //  MessageBox.Show(evaluationDetailGridView.Rows[i].Cells[j].Value.ToString());
                                     PdfPCell cell = new PdfPCell(new Phrase(evaluationDetailGridView.Rows[i].Cells[j].Value.ToString()));

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
