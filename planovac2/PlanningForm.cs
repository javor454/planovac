using System;
using System.Windows.Forms;

namespace planovac2
{
    public partial class PlanningForm : Form
    {
        public PlanningForm()
        {
            InitializeComponent();

            MainForm mainForm = (Application.OpenForms[0] as MainForm); //mainform instance
            dgvResponsibilities.AutoGenerateColumns = false;
            chkAlertOn.DataPropertyName = "AlertOn";
            txtType.DataPropertyName = "Type";
            txtName.DataPropertyName = "Name";
            txtDescription.DataPropertyName = "Description";
            dgvResponsibilities.DataSource = mainForm.Responsibilities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResponsibilityForm createResponsibilityForm = new ResponsibilityForm();
            createResponsibilityForm.ShowDialog();
            if (createResponsibilityForm.DialogResult == DialogResult.OK)
            {
                dgvResponsibilities.Invalidate();
            }
        }

        private void dgvResponsibilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm mainForm = (Application.OpenForms[0] as MainForm);

            if ((sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0) //if clicked cell content is dgvcheckboxcolumn and not in the first header row
            {
                if (mainForm.Responsibilities[e.RowIndex].AlertOn)
                {
                    mainForm.Responsibilities[e.RowIndex].AlertOn = false;
                }
                else
                {
                    mainForm.Responsibilities[e.RowIndex].AlertOn = true;
                }
            }

            if ((sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) //if clicked cell content is dgvbuttoncolumn and not in the first header row
            {
                if (e.ColumnIndex == 4)
                {
                    ResponsibilityForm editResponsibilityForm = new ResponsibilityForm(e.RowIndex);
                    editResponsibilityForm.ShowDialog();
                    if (editResponsibilityForm.DialogResult == DialogResult.OK)
                    {
                        dgvResponsibilities.Invalidate();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to remove this responsibility?", "Remove responsibility", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        mainForm.RemoveResponsibilityAt(e.RowIndex);
                    }
                }
            }
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
