﻿using GalaSoft.MvvmLight;
using MVVM.Models;
using System;
using System.Collections.ObjectModel;

namespace MVVM.ViewModels
{
    public class ViewModel_PersonManagement : ViewModelBase
    {
        #region events

        #endregion

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
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_PersonManagement()
        {
            InitCommands();
            DesignData();
        }
        #endregion

        #region command methods

        #endregion

        #region methods
        void InitCommands()
        {

        }

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

        void RuntimeData()
        {

        }

        public void SaveNewPerson()
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
        }
        #endregion
    }
}