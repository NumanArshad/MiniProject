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
    public partial class Make_Group : Form
    {
        public Make_Group()
        {
            InitializeComponent();
        }

        private void cmdCreateGroup_Click(object sender, EventArgs e)
        {
            Manage_Student_Groups msg = new Manage_Student_Groups();
            this.Hide();
            msg.Show();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Manage_Student_Groups msg = new Manage_Student_Groups();
            this.Hide();
            msg.Show();
        }
    }
}
