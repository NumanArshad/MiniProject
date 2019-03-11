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
    public partial class Manage_Group_Project : Form
    {
        public Manage_Group_Project()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string assignProjectQuery = string.Format("insert into GroupProject(ProjectId,GroupId,AssignmentDate) values((select Id from Project where Title='{0}'),'{1}','{2}')", cmbBxProjects.Text, cmbBxGroups.Text, Convert.ToDateTime(DateTime.Now));
            DataBaseConnection.getInstance().executeQuery(assignProjectQuery);
            this.load_Data_In_GridView();
        }
        public void load_Data_In_GridView()
        {
            //  groupProjectGridView.Rows.Clear();
            if (groupProjectGridView.Rows.Count > 0)
            {
                table.Clear();
            }
            string queryGroupProject = "select * from GroupProject";
            var lst = DataBaseConnection.getInstance().getAllData(queryGroupProject);
            lst.Fill(table);
            groupProjectGridView.DataSource = table;
        } 

        private void Manage_Group_Project_Load(object sender, EventArgs e)
        {
            string queryProject = "select Title from Project where not Exists(select * from GroupProject where ProjectId=Project.Id)";
            var titledata = DataBaseConnection.getInstance().readData(queryProject);
            while (titledata.Read())
            {
                cmbBxProjects.Items.Add(titledata.GetString(0));
            }

            string queryGroups = "select Id from Group1 where not Exists(select * from GroupProject where GroupId=Group1.Id)";
            var groupdata = DataBaseConnection.getInstance().readData(queryGroups);
            while (groupdata.Read())
            {
             cmbBxGroups.Items.Add((int)groupdata.GetValue(0));
            }

            this.load_Data_In_GridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
