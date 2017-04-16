using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SelaPersonProject.Model
{
    public class Person : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value) return;
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value) return;
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (_birthday == value) return;
                _birthday = value;
                NotifyPropertyChanged();
            }
        }

        private Gender _personGender;
        public Gender PersonGender
        {
            get { return _personGender; }
            set
            {
                if (_personGender == value) return;
                _personGender = value;
                NotifyPropertyChanged();
            }
        }

        private string _secretPerson;
        public string SecretPerson
        {
            get { return _secretPerson; }
            set
            {
                if (_secretPerson == value) return;
                _secretPerson = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsFemale
        {
            get { return _personGender == Gender.Female; }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
