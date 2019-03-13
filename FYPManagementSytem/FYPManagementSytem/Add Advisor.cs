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
    public partial class Add_Advisor : Form
    {
        public Add_Advisor()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Manage_Advisors showAdvisor = new Manage_Advisors();
            this.Hide();
            showAdvisor.Show();
        }

        private void Add_Advisor_Load(object sender, EventArgs e)
        {
            string designationQuery = "select Value from Lookup where Category='DESIGNATION'";//"select Value from Lookup where Id BETWEEN 6 and 10";
           var designatins= DataBaseConnection.getInstance().readData(designationQuery);
           while (designatins.Read())
           {
               cmbBxDesignation.Items.Add(designatins.GetString(0));

            }
            if (is_editMode())
            {
                string query1 = string.Format("select * from Advisor where Id='{0}'", GeneralID.selectedObjectid);
                var selectedAdvisor= DataBaseConnection.getInstance().readData(query1);
                int selectDesignationId = 0;
                while (selectedAdvisor.Read())
                {
                    selectDesignationId = (int)selectedAdvisor.GetValue(1);
                    txtBxSalary.Text = selectedAdvisor.GetValue(2).ToString();
                }

                string query2 = string.Format("select Value from Lookup where Id='{0}'", selectDesignationId);
                var selectedAd = DataBaseConnection.getInstance().readData(query2);
                while (selectedAd.Read())
                {
                    cmbBxDesignation.Text = selectedAd.GetString(0);
                   
                }



            }


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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!is_editMode())
            {
                string queryProject = "";
                try
                {
                    int maxId;
                    string querymx = "select max(Id) from Advisor";
                    maxId = DataBaseConnection.getInstance().getRowsCount(querymx) + 1;
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
                    if (txtBxSalary.Text == "")
                    {
                        queryProject = string.Format("insert into Advisor(Id,Designation) values(1,(select Id from Lookup where Value='{0}'),'{1}')", cmbBxDesignation.Text);
                    }
                    else
                    {
                        queryProject = string.Format("insert into Advisor(Id,Designation,Salary) values(1,(select Id from Lookup where Value='{0}'),'{1}')", cmbBxDesignation.Text, int.Parse(txtBxSalary.Text));
                    }

                }

                DataBaseConnection.getInstance().executeQuery(queryProject);
                MessageBox.Show("Added Success");

            }
            else
            {
                string queryUpdateAdvisor;
                if (txtBxSalary.Text == "")
                {
                     queryUpdateAdvisor = string.Format("update Advisor  set Designation=(select Id from Lookup where Value='{0}'),Salary='{1}' where Id='{2}'", cmbBxDesignation.Text,null , GeneralID.selectedObjectid);

                }
                else
                {
                    queryUpdateAdvisor = string.Format("update Advisor  set Designation=(select Id from Lookup where Value='{0}'),Salary='{1}' where Id='{2}'", cmbBxDesignation.Text,int.Parse(txtBxSalary.Text),GeneralID.selectedObjectid);
                }
                DataBaseConnection.getInstance().executeQuery(queryUpdateAdvisor);
                MessageBox.Show("Update Success");

            }

            Manage_Advisors showAdvisor = new Manage_Advisors();
            this.Hide();
            showAdvisor.Show();
        }
    }
}
