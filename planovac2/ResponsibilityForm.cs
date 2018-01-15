using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace planovac2
{
    public partial class ResponsibilityForm : Form
    {
        private bool _editMode;
        private int _editIndex;

        public bool EditMode
        {
            get
            {
                return _editMode;
            }

            private set
            {
                _editMode = value;
            }
        }
        public int EditIndex
        {
            get
            {
                return _editIndex;
            }

            set
            {
                _editIndex = value;
            }
        }

        public ResponsibilityForm()
        {
            _editMode = false;
            InitializeComponent();

            cmbType.DataSource = Enum.GetValues(typeof(Type)); //fill cmb with enum items
        }

        public ResponsibilityForm(int respIndex)
        {
            _editMode = true;
            _editIndex = respIndex;
            InitializeComponent();

            cmbType.DataSource = Enum.GetValues(typeof(Type));
            MainForm mainForm = (Application.OpenForms[0] as MainForm); //MainForm instance
            Responsibility responsibility = mainForm.Responsibilities[respIndex]; //edited responsibility
            lblCreate.Text = "Edit your responsibility:";
            cmbType.SelectedItem = responsibility.Type;
            txtName.Text = responsibility.Name;
            txtDescription.Text = responsibility.Description;
            nudAlert.Value = responsibility.AlertQuantity;
            //nudAlert settings to enable/disable certain controls depending on its value + data filling
            #region nudSettings
            switch ((int)nudAlert.Value)
            {
                case 1:
                    lblAlert2.Enabled = false;
                    txtAlert2.Enabled = false;
                    lblAlert3.Enabled = false;
                    txtAlert3.Enabled = false;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    txtAlert1.Text = string.Format("{0:HH:mm}",responsibility.AlertTimes[0]);
                    break;
                case 2:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = false;
                    txtAlert3.Enabled = false;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    txtAlert1.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[0]);
                    txtAlert2.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[1]);
                    break;
                case 3:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    txtAlert1.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[0]);
                    txtAlert2.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[1]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[2]);
                    break;
                case 4:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = true;
                    txtAlert4.Enabled = true;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    txtAlert1.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[0]);
                    txtAlert2.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[1]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[2]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[3]);
                    break;
                case 5:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = true;
                    txtAlert4.Enabled = true;
                    lblAlert5.Enabled = true;
                    txtAlert5.Enabled = true;
                    txtAlert1.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[0]);
                    txtAlert2.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[1]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[2]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[3]);
                    txtAlert3.Text = string.Format("{0:HH:mm}", responsibility.AlertTimes[4]);
                    break;
            }
            #endregion
            btnCreate.Text = "Save";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<DateTime> dateTimeList = new List<DateTime>();
            MainForm mainForm = (Application.OpenForms[0] as MainForm);
            if (EditMode)
            {
                Responsibility responsibility = mainForm.Responsibilities[EditIndex];
                try
                {
                    switch ((int)nudAlert.Value)
                    {
                        case 1:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            break;
                        case 2:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            break;
                        case 3:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            break;
                        case 4:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert4.Text));
                            break;
                        case 5:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert4.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert5.Text));
                            break;
                    }
                    responsibility.Type = (Type)cmbType.SelectedItem;
                    responsibility.Name = txtName.Text;
                    responsibility.Description = txtDescription.Text;
                    responsibility.AlertQuantity = (int)nudAlert.Value;
                    responsibility.AlertTimes = dateTimeList;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "Application was not able to parse alert times you entered. Please, check for mistakes and correct format.",
                        "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lblFormat.ForeColor = Color.Red;
                }
            }
            else
            {
                try
                {
                    switch ((int)nudAlert.Value)
                    {
                        case 1:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            break;
                        case 2:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            break;
                        case 3:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            break;
                        case 4:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert4.Text));
                            break;
                        case 5:
                            dateTimeList.Add(Convert.ToDateTime(txtAlert1.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert2.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert3.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert4.Text));
                            dateTimeList.Add(Convert.ToDateTime(txtAlert5.Text));
                            break;
                    }
                    mainForm.AddResponsibility(new Responsibility(
                        (Type)cmbType.SelectedItem,
                        txtName.Text,
                        txtDescription.Text,
                        (int)nudAlert.Value,
                        dateTimeList
                    ));
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "Application was not able to parse alert times you entered. Please, check for mistakes and correct format.",
                        "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lblFormat.ForeColor = Color.Red;
                }
            }
        }

        private void nudAlert_ValueChanged(object sender, EventArgs e)
        {
            //nudAlert settings to enable/disable certain controls depending on its value
            #region nudSettings
            switch ((int)nudAlert.Value)
            {
                case 1:
                    lblAlert2.Enabled = false;
                    txtAlert2.Enabled = false;
                    lblAlert3.Enabled = false;
                    txtAlert3.Enabled = false;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    break;
                case 2:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = false;
                    txtAlert3.Enabled = false;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    break;
                case 3:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = false;
                    txtAlert4.Enabled = false;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    break;
                case 4:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = true;
                    txtAlert4.Enabled = true;
                    lblAlert5.Enabled = false;
                    txtAlert5.Enabled = false;
                    break;
                case 5:
                    lblAlert2.Enabled = true;
                    txtAlert2.Enabled = true;
                    lblAlert3.Enabled = true;
                    txtAlert3.Enabled = true;
                    lblAlert4.Enabled = true;
                    txtAlert4.Enabled = true;
                    lblAlert5.Enabled = true;
                    txtAlert5.Enabled = true;
                    break;
            }
            #endregion  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
