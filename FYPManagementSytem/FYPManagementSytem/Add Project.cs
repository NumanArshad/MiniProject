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
            if (is_editMode())
            {
                string query = string.Format("select * from Project where Id='{0}'", GeneralID.selectedObjectid);
                var selectedProject = DataBaseConnection.getInstance().readData(query);
                while (selectedProject.Read())
                {
                    richTextBxDesc.Text = selectedProject.GetString(1);
                    txtBxTitle.Text = selectedProject.GetString(2);
                }

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!is_editMode())
            {

                string queryProject = string.Format("insert into Project(Description,Title) values('{0}','{1}')", richTextBxDesc.Text, txtBxTitle.Text);
                DataBaseConnection.getInstance().executeQuery(queryProject);
                MessageBox.Show("Added Success");
            }
            else
            {
                string updateQuery= string.Format("update Project  set Title='{0}',Description='{1}' where Id='{2}'", txtBxTitle.Text,richTextBxDesc.Text, GeneralID.selectedObjectid);
                DataBaseConnection.getInstance().executeQuery(updateQuery);
                MessageBox.Show("Update Success");
                GeneralID.selectedObjectid = 0; //reset it to zero after successfull update
            }
            Show_Projects showProject = new Show_Projects();
            this.Hide();
            showProject.Show();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Show_Projects projects = new Show_Projects();
            this.Hide();
            projects.Show();
        }
        private Boolean is_editMode()
        {
            bool EditMode = false;
            if (GeneralID.selectedObjectid != 0)
            {
                // MessageBox.Show(GeneralID.selectedObjectid.ToString());
                EditMode = true;
            }
            return EditMode;

        }
    }
}
