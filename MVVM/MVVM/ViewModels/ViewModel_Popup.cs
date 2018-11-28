using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ViewModel_Popup : ViewModelBase
    {
        #region events
        public event EventHandler OnOkTapped;
        #endregion

        #region vars

        #endregion

        #region properties
        private bool _isVisible = false;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { Set(nameof(IsVisible), ref _isVisible, value); }
        }

        private string _message = string.Empty;
        public string Message
        {
            get { return _message; }
            set { Set(nameof(Message), ref _message, value); }
        }
        #endregion

        #region commands
        public ICommand Command_Ok { get; set; }
        public ICommand Command_Cancel { get; set; }
        #endregion

        #region ctors
        public ViewModel_Popup()
        {
            InitCommands();
        }
        #endregion

        #region command methods
        void Command_Ok_Click()
        {
            OnOkTapped?.Invoke(this, null);
            this.HidePopup();
        }

        void Command_Cancel_Click()
        {
            this.HidePopup();
        }
        #endregion

        #region methods
        void InitCommands()
        {
            if (Command_Ok == null) Command_Ok = new RelayCommand(Command_Ok_Click);
            if (Command_Cancel == null) Command_Cancel = new RelayCommand(Command_Cancel_Click);
        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public void ShowPopup(string message)
        {
            this.Message = message;
            this.IsVisible = true;
        }

        public void HidePopup()
        {
            this.IsVisible = false;
        }
        #endregion
    }
}
