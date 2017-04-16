using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using SelaPersonProject.Annotations;
using SelaPersonProject.Model;

namespace SelaPersonProject.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            if (PersonListCollection.Count == 0)
                InitMockData();

            _personListCollectionView = CollectionViewSource.GetDefaultView(PersonListCollection);
        }


        #region Property
        private readonly ICollectionView _personListCollectionView;
        public ICollectionView PersonListCollectionView
        {
            get { return _personListCollectionView; }
        }


        private IList<Person> _personCollectionlist;
        public IList<Person> PersonListCollection
        {
            get
            {
                return _personCollectionlist ??
                       (_personCollectionlist = new List<Person>());
            }
        }

        private Person _personItem;
        public Person PersonItem
        {
            get { return _personItem; }
            set
            {
                if (_personItem == value) return;
                _personItem = value;
                NotifyPropertyChanged();

                NotifyPropertyChanged("ImageGender");
            }
        }

        public string ImageGender
        {
            get
            {
                if (PersonItem != null)
                {
                    if (PersonItem.IsFemale)
                        return @"~\..\Icons\Female.png";
                    return @"~\..\Icons\Male.png";
                }
                return string.Empty;
            }
        } 
        #endregion

        #region Commands
        private ICommand _saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand =
                    new DelegateCommand(() => { UpdatePerson(PersonItem); }));
            }

        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand =
                    new DelegateCommand(() => { DeletePerson(PersonItem); }));
            }
        }

        private ICommand _genderToMaleCommand;
        public ICommand GenderToMaleCommand
        {
            get
            {
                return _genderToMaleCommand ?? (_genderToMaleCommand =
                    new DelegateCommand(() =>
                    {
                        PersonItem.PersonGender = Gender.Male; NotifyPropertyChanged("ImageGender");
                    }));
            }
        }

        private ICommand _genderToFemaleCommand;
        public ICommand GenderToFemaleCommand
        {
            get
            {
                return _genderToFemaleCommand ?? (_genderToFemaleCommand =
                    new DelegateCommand(() =>
                    {
                        PersonItem.PersonGender = Gender.Female; NotifyPropertyChanged("ImageGender");
                    }));
            }
        }
        #endregion

        #region Private Method
        private void InitMockData()
        {
            PersonListCollection.Add(new Person()
            {
                Id = 1,
                FirstName = "Albert",
                LastName = "Smith",
                PersonGender = Gender.Male,
                Birthday = DateTime.Parse("6/6/1980"),
                SecretPerson = "SecretMySecret"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 2,
                FirstName = "Alston",
                LastName = "Price",
                PersonGender = Gender.Male,
                Birthday = DateTime.Parse("7/15/1970"),
                SecretPerson = "MySecretSecret"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 3,
                FirstName = "Arlen",
                LastName = "Wood",
                PersonGender = Gender.Male,
                Birthday = DateTime.Parse("1/21/1990"),
                SecretPerson = "MySecretWood"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 4,
                FirstName = "Alison",
                LastName = "Ross",
                PersonGender = Gender.Female,
                Birthday = DateTime.Parse("2/13/1956"),
                SecretPerson = "RossMySecret"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 5,
                FirstName = "Jane",
                LastName = "Ross",
                PersonGender = Gender.Female,
                Birthday = DateTime.Parse("3/26/1992"),
                SecretPerson = "JaneMySecret"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 6,
                FirstName = "Nina",
                LastName = "Porina",
                PersonGender = Gender.Female,
                Birthday = DateTime.Parse("4/11/1901"),
                SecretPerson = "MySecretNina"
            });
            PersonListCollection.Add(new Person()
            {
                Id = 7,
                FirstName = "Jas",
                LastName = "Gilbert",
                PersonGender = Gender.Female,
                Birthday = DateTime.Parse("3/14/2001"),
                SecretPerson = "MyJasSecret"
            });
        }
        private void DeletePerson(Person person)
        {
            PersonListCollection.Remove(person);
            PersonListCollectionView.Refresh();
        }
        private void UpdatePerson(Person personItem)
        {

        }
        #endregion

        #region NotifyPropertyChanged
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
        #endregion
    }
}
