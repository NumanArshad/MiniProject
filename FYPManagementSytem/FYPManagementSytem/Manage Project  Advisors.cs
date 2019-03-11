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
    public partial class Manage_Project__Advisors : Form
    {
        public Manage_Project__Advisors()
        {
            InitializeComponent();
        }

        private void Manage_Project__Advisors_Load(object sender, EventArgs e)
        {
            string queryAdvisor = "select Id from Advisor";
            var advisordata = DataBaseConnection.getInstance().readData(queryAdvisor);
            while (advisordata.Read())
            {
                cmbBxAdvisors.Items.Add((int)advisordata.GetValue(0));
            }

            string queryTitle = "select Title from Project";
            var titledata = DataBaseConnection.getInstance().readData(queryTitle);
            while (titledata.Read())
            {
                cmbBxProjects.Items.Add(titledata.GetString(0));
            }

            string queryAdvisorRole = "select Value from Lookup where Category='ADVISOR_ROLE'";
            var Rolesdata = DataBaseConnection.getInstance().readData(queryAdvisorRole);
            while (Rolesdata.Read())
            {
                cmbBxAdvisorRoles.Items.Add(Rolesdata.GetString(0));
            }
            this.load_data_in_gridview();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            string insertQuery = string.Format("insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate) values('{0}',(select Id from Project where Title='{1}'),(select Id from Lookup where Value='{2}'),'{3}')", cmbBxAdvisors.Text, cmbBxProjects.Text, cmbBxAdvisorRoles.Text,DateTime.Now);
            DataBaseConnection.getInstance().executeQuery(insertQuery);

            this.load_data_in_gridview();
        }
        DataTable table = new DataTable();
        public void load_data_in_gridview()
        {
            if (projectAdvisorGridView.Rows.Count > 0)
            {
                table.Clear();
            }
            string query = "select * from ProjectAdvisor";
            var lst=DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            projectAdvisorGridView.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
