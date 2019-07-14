using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    [Serializable]
    public class Address : Notifier
    {
        private string _city;
        private string _country;
        private string _line1;
        private string _line2;
        private string _state;
        private string _zip;

        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnPropertyChanged("City");
                }
            }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    OnPropertyChanged("Country");
                }
            }
        }

        public string Line1
        {
            get { return _line1; }
            set
            {
                if (_line1 != value)
                {
                    _line1 = value;
                    OnPropertyChanged("Line1");
                }
            }
        }

        public string Line2
        {
            get { return _line2; }
            set
            {
                if (_line2 != value)
                {
                    _line2 = value;
                    OnPropertyChanged("Line2");
                }
            }
        }

        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        public string Zip
        {
            get { return _zip; }
            set
            {
                if (_zip != value)
                {
                    _zip = value;
                    OnPropertyChanged("Zip");
                }
            }
        }
    }
}
