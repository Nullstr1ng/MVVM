using System.ComponentModel;

namespace MVVM.Models
{
    public class Model_Person : INotifyPropertyChanged
    {
        private string _profilePicture = string.Empty;
        public string ProfilePicture
        {
            get { return _profilePicture; }
            set
            {
                if (_profilePicture != value)
                {
                    _profilePicture = value;
                    RaisePropertyChangedEvent(nameof(ProfilePicture));
                }
            }
        }

        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChangedEvent(nameof(FirstName));
                }
            }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChangedEvent(nameof(LastName));
                }
            }
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
