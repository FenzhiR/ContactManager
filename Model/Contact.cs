using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    [Serializable]
    public class Contact : Notifier
    {
        private Address _address = new Address();
        private string _cellPhone;
        private string _firstName;
        private string _homePhone;
        private Guid _id = Guid.Empty;
        private string _imagePath;
        private string _jobTitle;
        private string _lastName;
        private string _officePhone;
        private string _organization;
        private string _primaryEmail;
        private string _secondaryEmail;

        public Guid Id
        {
            get { return _id; }
            set
            {
                if(_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                if (_imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged("ImagePath");
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("LookupName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("LookupName");
                }
            }
        }

        public string Organization
        {
            get { return _organization; }
            set
            {
                if (_organization != value)
                {
                    _organization = value;
                    OnPropertyChanged("Organization");
                }
            }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                if (_jobTitle != value)
                {
                    _jobTitle = value;
                    OnPropertyChanged("JobTitle");
                }
            }
        }

        public string OfficePhone
        {
            get { return _officePhone; }
            set
            {
                if (_officePhone != value)
                {
                    _officePhone = value;
                    OnPropertyChanged("OfficePhone");
                }
            }
        }

        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                if (_cellPhone != value)
                {
                    _cellPhone = value;
                    OnPropertyChanged("CellPhone");
                }
            }
        }

        public string HomePhone
        {
            get { return _homePhone; }
            set
            {
                if (_homePhone != value)
                {
                    _homePhone = value;
                    OnPropertyChanged("HomePhone");
                }
            }
        }

        public string PrimaryEmail
        {
            get { return _primaryEmail; }
            set
            {
                if (_primaryEmail != value)
                {
                    _primaryEmail = value;
                    OnPropertyChanged("PrimaryEmail");
                }
            }
        }

        public string SecondaryEmail
        {
            get { return _secondaryEmail; }
            set
            {
                if (_secondaryEmail != value)
                {
                    _secondaryEmail = value;
                    OnPropertyChanged("SecondaryEmail");
                }
            }
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public string LookupName
        {
            get { return string.Format("{0}, {1}", _lastName, FirstName); }
        }

        public override string ToString()
        {
            return LookupName;
        }

        public override bool Equals(object obj)
        {
            Contact other = obj as Contact;
            return other == null ? false : other.Id == this.Id;
        }
    }
}
