using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planovac2
{
    public enum Type
    {
        Animal,
        Plant,
        Medication
    }

    [Serializable]
    public class Responsibility
    {
        private bool _alertOn;
        private Type _type;
        private string _name;
        private string _description;
        private int _alertQuantity;
        private List<DateTime> _alertTimes;

        public bool AlertOn
        {
            get
            {
                return _alertOn;
            }

            set
            {
                _alertOn = value;
            }
        }
        public Type Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public int AlertQuantity
        {
            get
            {
                return _alertQuantity;
            }

            set
            {
                _alertQuantity = value;
            }
        }
        public List<DateTime> AlertTimes
        {
            get
            {
                return _alertTimes;
            }

            set
            {
                _alertTimes = value;
            }
        }

        public Responsibility(Type type, string name, string description,  int alertQuantity, List<DateTime> alertTimes)
        {
            _alertOn = true;
            _type = type;
            _name = name;
            _description = description;
            _alertQuantity = alertQuantity;
            _alertTimes = alertTimes;
        }

        /// <summary>
        /// Alerts user about this responsibility.
        /// </summary>
        private void Alert()
        {
            AlertForm alertForm = new AlertForm(this);
            alertForm.Show();
        }

        /// <summary>
        /// Checks for possible alerts.
        /// </summary>
        /// <param name="appTime">Application time</param>
        public void CheckForAlert(DateTime appTime)
        {
            if (AlertOn)
            {
                foreach (DateTime alertTime in AlertTimes)
                {
                    if ((appTime.Hour == alertTime.Hour) && (appTime.Minute == alertTime.Minute))
                    {
                        Alert();
                    }
                }
            }
        }
    }
}
