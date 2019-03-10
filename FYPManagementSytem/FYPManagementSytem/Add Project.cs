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
    public partial class Add_Project : Form
    {
        public Add_Project()
        {
            InitializeComponent();
        }

        private void Add_Project_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string queryProject = string.Format("insert into Project(Description,Title) values('{0}','{1}')", richTextBxDesc.Text,txtBxTitle.Text);
            DataBaseConnection.getInstance().executeQuery(queryProject);
            MessageBox.Show("Added Success");
            Show_Projects showProject = new Show_Projects();
            this.Hide();
            showProject.Show();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
