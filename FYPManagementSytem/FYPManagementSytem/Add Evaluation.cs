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
    public partial class Add_Evaluation : Form
    {
        public Add_Evaluation()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Show_Evaluations evaluation = new Show_Evaluations();
            this.Hide();
            evaluation.Show();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!is_editMode())
            {
                string query = string.Format("insert into Evaluation(Name,TotalMarks,TotalWeightage) values('{0}','{1}','{2}')", txtBxName.Text, int.Parse(txtBxTotalMark.Text), int.Parse(txtBxTotalWeightage.Text));
                DataBaseConnection.getInstance().executeQuery(query);
                MessageBox.Show("Evaluation added Successfully");
            }
            else
            {
                string query = string.Format("update Evaluation set Name='{0}',TotalMarks='{1}',TotalWeightage='{2}' where Id='{3}'", txtBxName.Text, int.Parse(txtBxTotalMark.Text), int.Parse(txtBxTotalWeightage.Text),GeneralID.selectedObjectid);
                DataBaseConnection.getInstance().executeQuery(query);
                MessageBox.Show("Evaluation updated Successfully");
                GeneralID.selectedObjectid = 0; //reset it to zero after successfull update
            }
            Show_Evaluations evaluation = new Show_Evaluations();
            this.Hide();
            evaluation.Show();
        }

        private void Add_Evaluation_Load(object sender, EventArgs e)
        {
            if (is_editMode())
            {
                string query = string.Format("select * from Evaluation where Id='{0}'", GeneralID.selectedObjectid);
                var selectedEvaluation = DataBaseConnection.getInstance().readData(query);
                while (selectedEvaluation.Read())
                {
                    txtBxName.Text = selectedEvaluation.GetString(1);
                    txtBxTotalMark.Text = selectedEvaluation.GetValue(2).ToString();
                    txtBxTotalWeightage.Text= selectedEvaluation.GetValue(3).ToString();
                }
            }
        }

        private Boolean is_editMode()
        {
            bool EditMode = false;
            if (GeneralID.selectedObjectid != 0)
            {
               EditMode = true;
            }
            return EditMode;

        }
    }
}
