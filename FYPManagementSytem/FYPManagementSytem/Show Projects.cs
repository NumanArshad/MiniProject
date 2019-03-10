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
    }
}
