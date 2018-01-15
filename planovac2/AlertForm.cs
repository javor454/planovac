using System;
using System.Windows.Forms;

namespace planovac2
{
    public partial class AlertForm : Form
    {
        public AlertForm(Responsibility responsibility)
        {
            InitializeComponent();
            lblInfo.Text = "Type: " + responsibility.Type + "\r\nName: " + responsibility.Name+ "\r\nDescription: " + responsibility.Description;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
