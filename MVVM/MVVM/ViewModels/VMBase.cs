using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.ViewModels
{
    public class VMBase : ViewModelBase
    {
        public ViewModel_Popup Popup
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_Popup>(); }
        }


    }
}
