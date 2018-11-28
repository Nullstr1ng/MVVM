using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using MVVM.Models;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ViewModel_MainPage : VMBase
    {
        #region properties
        // we need the instance of this ViewModel so we can
        // call some of its functions inside thes ViewModel
        ViewModel_PersonManagement Person
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_PersonManagement>(); }
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

            // make a subscription to this event
            Person.OnPersonDeleted += Person_OnPersonDeleted;
        }
        #endregion

        #region event triggers
        // just make sure to hide the details pane 
        // if we deleted a person
        private void Person_OnPersonDeleted(object sender, Model_Person e)
        {
            this.ShowViewDetailsPane = false;
        }
        #endregion

        // This will be used to bind on a Button
        #region commands 

        public ICommand Command_Save { get; set; }

        public ICommand Command_ShowAddView { get; set; }

        public ICommand Command_CloseAddView { get; set; }

        public ICommand Command_ShowPersonDetails { get; set; }

        public ICommand Command_CloseViewDetailsPane { get; set; }
        public ICommand Command_DeleteSelectedPerson { get; set; }
        #endregion

        #region command methods
        void Command_Save_Click()
        {
            Person.SaveNewPerson();

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
            Person.SelectedPerson = person;
            this.ShowViewDetailsPane = true;
        }

        void Command_CloseViewDetailsPane_Click()
        {
            this.ShowViewDetailsPane = false;
        }

        void Command_DeleteSelectedPerson_Click()
        {
            Person.DeleteSelectedPerson();
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
            if (Command_DeleteSelectedPerson == null) Command_DeleteSelectedPerson = new RelayCommand(Command_DeleteSelectedPerson_Click);
        }

        // create an initial persons for our ListView
        void DesignData()
        {
            
        }
        #endregion
    }
}
