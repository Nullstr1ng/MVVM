using GalaSoft.MvvmLight;

namespace MVVM.Models
{
    public class Model_Person : ViewModelBase
    {
        private string _profilePicture = string.Empty;
        public string ProfilePicture
        {
            get { return _profilePicture; }
            set { Set(nameof(ProfilePicture), ref _profilePicture, value); }
        }

        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { Set(nameof(FirstName), ref _firstName, value); }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { Set(nameof(LastName), ref _lastName, value); }
        }
    }
}
