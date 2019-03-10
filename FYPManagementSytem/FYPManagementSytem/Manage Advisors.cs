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
            // TODO: This line of code loads data into the 'projectADataSet.Advisor' table. You can move, or remove it, as needed.
            this.advisorTableAdapter.Fill(this.projectADataSet.Advisor);


            string designationQuery = "select Value from Lookup where Id BETWEEN 6 and 10";
            var designatins= DataBaseConnection.getInstance().readData(designationQuery);
            while (designatins.Read())
            {
                cmbBxDesignation.Items.Add(designatins.GetString(0));

             }
        }

        private void showAllAdvisors()
        {

            
            string advisorsQuery = "select * from Advisor";
            var advisors = DataBaseConnection.getInstance().getAllData(advisorsQuery);
            advisors.Fill(table);
            advisorsGridView.DataSource = table;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string  queryProject="";
          try
            {
                int maxId;
                string querymx = "select max(Id) from Advisor";
                maxId = DataBaseConnection.getInstance().getRowsCount(querymx)+1;
                if (txtBxSalary.Text == "")
                {
                    queryProject = string.Format("insert into Advisor(Id,Designation) values('{0}',(select Id from Lookup where Value='{1}'))", maxId, cmbBxDesignation.Text);
                }
                else
                {
                    queryProject = string.Format("insert into Advisor(Id,Designation,Salary) values('{0}',(select Id from Lookup where Value='{1}'),'{2}')", maxId, cmbBxDesignation.Text, int.Parse(txtBxSalary.Text));
                }

            }
            catch
            {
                queryProject = string.Format("insert into Advisor(Id,Designation,Salary) values(1,(select Id from Lookup where Value='{0}'),'{1}')", cmbBxDesignation.Text, int.Parse(txtBxSalary.Text));
            }

            DataBaseConnection.getInstance().executeQuery(queryProject);
            MessageBox.Show("Added Success");
            this.showAllAdvisors();






        }
    }
}
