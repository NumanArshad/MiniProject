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
    public partial class Manage_Student_Groups : Form
    {
        public Manage_Student_Groups()
        {
            InitializeComponent();
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            Make_Group make_group = new Make_Group();
            this.Hide();
            make_group.Show();
        }
    }
}
