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
    public partial class Show_Evaluations : Form
    {
        public Show_Evaluations()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Show_Evaluations_Load(object sender, EventArgs e)
        {
            evaluationsGridView.BorderStyle = BorderStyle.None;
            evaluationsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            evaluationsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            evaluationsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            evaluationsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            evaluationsGridView.BackgroundColor = Color.White;

            evaluationsGridView.EnableHeadersVisualStyles = false;
            evaluationsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            evaluationsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            evaluationsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.load_data_in_gridview();

            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            editbtn.HeaderText = "Edit";
            editbtn.Name = "button";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            evaluationsGridView.Columns.Add(editbtn);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.HeaderText = "Delete";
            delbtn.Name = "button";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            evaluationsGridView.Columns.Add(delbtn);
        }
        private void load_data_in_gridview()
        {
            if (evaluationsGridView.Rows.Count > 0)
            {
                table.Clear();
            }

            string query = "select * from Evaluation";
            var lst = DataBaseConnection.getInstance().getAllData(query);
            lst.Fill(table);
            evaluationsGridView.DataSource = table;
        }
        int selectedRow;
        private void evaluationsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = evaluationsGridView.CurrentCell.RowIndex;
            DataGridViewRow row = evaluationsGridView.Rows[selectedRow];

            if (e.ColumnIndex == 4)
            {
                GeneralID.selectedObjectid = (int)row.Cells[0].Value;
                Add_Evaluation add = new Add_Evaluation();
                this.Hide();
                add.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                int selectId = (int)row.Cells[0].Value;
                string deleteStudentQuery = string.Format("delete Evaluation where Id='{0}'", selectId);
                DataBaseConnection.getInstance().executeQuery(deleteStudentQuery);
                MessageBox.Show("Evaluation deleted Successfully");
                this.load_data_in_gridview();

            }
        }

        private void picBxAddNew_Click(object sender, EventArgs e)
        {
            Add_Evaluation newEvaluation = new Add_Evaluation();
            this.Hide();
            newEvaluation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
