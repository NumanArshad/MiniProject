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
    public partial class Show_Students : Form
    {
        public Show_Students()
        {
            InitializeComponent();
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            Add_Student add_new =new  Add_Student();
            this.Hide();
            add_new.Show();
        }
    }
}
