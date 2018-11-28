using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ViewModel_MainPage : ViewModelBase
    {
        #region vars
        Random _r = new Random(DateTime.Now.Second);
        #endregion

        #region properties
        // used to show a collection of Person in a ListView
        public ObservableCollection<Model_Person> PersonCollection { get; set; } = new ObservableCollection<Model_Person>();

        // holds the data of the selected Person in a ListView
        private Model_Person _selectedPerson = new Model_Person();
        public Model_Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { Set(nameof(SelectedPerson), ref _selectedPerson, value); }
        }

        // holds the data entered in Entry control
        private Model_Person _personEntry = new Model_Person();
        public Model_Person PersonEntry
        {
            get { return _personEntry; }
            set { Set(nameof(PersonEntry), ref _personEntry, value); }
        }

        // show / hides the view for adding a Person
        private bool _showAddView = false;
        public bool ShowAddView
        {
            get { return _showAddView; }
            set { Set(nameof(ShowAddView), ref _showAddView, value); }
        }

        // show / hides the person details view pane
        private bool _ShowViewDetailsPane = false;
        public bool ShowViewDetailsPane
        {
            get { return _ShowViewDetailsPane; }
            set { Set(nameof(ShowViewDetailsPane), ref _ShowViewDetailsPane, value); }
        }
        #endregion

        #region ctors
        public ViewModel_MainPage()
        {
            InitCommands();
            DesignData();
        }
        #endregion

        // This will be used to bind on a Button
        #region commands 

        public ICommand Command_Save { get; set; }

        public ICommand Command_ShowAddView { get; set; }

        public ICommand Command_CloseAddView { get; set; }

        public ICommand Command_ShowPersonDetails { get; set; }

        public ICommand Command_CloseViewDetailsPane { get; set; }
        #endregion

        #region command methods
        void Command_Save_Click()
        {
            // create a new instance of Model_Person in our collection
            PersonCollection.Add(new Model_Person()
            {
                FirstName = PersonEntry.FirstName,
                LastName = PersonEntry.LastName
            });


            // and clear the fields
            PersonEntry.FirstName = null;
            PersonEntry.LastName = null;

            // then hide the view
            Command_CloseAddView.Execute(null);
        }

        void Command_ShowAddView_Click()
        {
            ShowAddView = true;
        }

        void Command_CloseAddView_Click()
        {
            this.ShowAddView = false;
        }

        void Command_ShowPersonDetails_Click(Model_Person person)
        {
            this.SelectedPerson = person;
            this.ShowViewDetailsPane = true;
        }

        void Command_CloseViewDetailsPane_Click()
        {
            this.ShowViewDetailsPane = false;
        }
        #endregion

        #region methods
        // Initialize command handlers so we can trigger a specific method tied into that ICommand
        void InitCommands()
        {
            if (Command_Save == null) Command_Save = new RelayCommand(Command_Save_Click);
            if (Command_ShowAddView == null) Command_ShowAddView = new RelayCommand(Command_ShowAddView_Click);
            if (Command_CloseAddView == null) Command_CloseAddView = new RelayCommand(Command_CloseAddView_Click);
            if (Command_ShowPersonDetails == null) Command_ShowPersonDetails = new RelayCommand<Model_Person>(Command_ShowPersonDetails_Click);
            if (Command_CloseViewDetailsPane == null) Command_CloseViewDetailsPane = new RelayCommand(Command_CloseViewDetailsPane_Click);
        }

        // create an initial persons for our ListView
        void DesignData()
        {
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Koushuu",
                LastName = "Matsusaki"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Katsuhiko",
                LastName = "Miyake"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Taiga",
                LastName = "Miwa"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Kiyosumi",
                LastName = "Chouda"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Izumi",
                LastName = "Kawano"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Yoshiaki",
                LastName = "Kouyama"
            });
            this.PersonCollection.Add(new Model_Person()
            {
                ProfilePicture = $"https://randomuser.me/api/portraits/men/{_r.Next(1, 62)}.jpg",
                FirstName = "Michinori",
                LastName = "Aoyagi"
            });
        }
        #endregion
    }
}
