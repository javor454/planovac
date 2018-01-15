using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace planovac2
{
    public partial class MainForm : Form
    {
        private DateTime _time;
        private BindingList<Responsibility> _responsibilities;

        public DateTime Time
        {
            get
            {
                return _time;
            }

            private set
            {
                _time = value;
            }
        }
        public BindingList<Responsibility> Responsibilities
        {
            get
            {
                return _responsibilities;
            }

            private set
            {
                _responsibilities = value;
            }
        }

        public MainForm()
        {
            _time = DateTime.Now;
            _responsibilities = new BindingList<Responsibility>();
            LoadResponsibilities();
            InitializeComponent();

            lblDate.Text = GetDateOnly();
            lblTime.Text = GetTimeOnly();
        }

        /// <summary>
        /// Adds new responsibility to application responsibility list.
        /// </summary>
        /// <param name="newResponsibility">New responsibility</param>
        public void AddResponsibility(Responsibility newResponsibility)
        {
            Responsibilities.Add(newResponsibility);
        }

        /// <summary>
        /// Removes responsibility at specified index of application responsibility list.
        /// </summary>
        /// <param name="responsibilityIndex">Responsibility index</param>
        public void RemoveResponsibilityAt(int responsibilityIndex)
        {
            Responsibilities.RemoveAt(responsibilityIndex);
        }

        /// <summary>
        /// Formats DateTime to string representation of date only.
        /// </summary>
        /// <param name="time">DateTime to be formated into string</param>
        /// <returns>String representation of date only</returns>
        public string GetDateOnly()
        {
            return string.Format("{0:D}", Time);
        }

        /// <summary>
        /// Formats DateTime to string representation of time only.
        /// </summary>
        /// <returns>String representation of time only</returns>
        public string GetTimeOnly()
        {
            return string.Format("{0:HH:mm}", Time);
        }


        /// <summary>
        /// Saves BindingList of Responsibilities to binary file.
        /// </summary>
        private void SaveResponsibilities()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("responsibilities.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, Responsibilities);
            }
        }

        /// <summary>
        /// Loads BindingList of Responsibilities from binary file.
        /// </summary>
        private void LoadResponsibilities()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream stream = new FileStream("responsibilities.bin", FileMode.Open, FileAccess.Read))
                {
                    Responsibilities = formatter.Deserialize(stream) as BindingList<Responsibility>;
                }
            }
            catch (FileNotFoundException)
            {
                //no need to do anything
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            SaveResponsibilities();
            Close();
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            PlanningForm planForm = new PlanningForm();
            planForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            Time = DateTime.Now;
            lblDate.Text = GetDateOnly();
            lblTime.Text = GetTimeOnly();
        }

        private void lblTime_TextChanged(object sender, EventArgs e)
        {
            foreach (Responsibility responsibility in Responsibilities)
            {
                responsibility.CheckForAlert(Time);
            }
        }
    }
}
