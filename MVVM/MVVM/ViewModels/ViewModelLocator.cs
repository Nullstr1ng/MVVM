using GalaSoft.MvvmLight.Ioc;

namespace MVVM.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel_MainPage>();
            SimpleIoc.Default.Register<ViewModel_PersonManagement>();
            SimpleIoc.Default.Register<ViewModel_Popup>();
        }

        public ViewModel_MainPage Main
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_MainPage>(); }
        }

        public ViewModel_PersonManagement Person
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_PersonManagement>(); }
        }

        public ViewModel_Popup Popup
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_Popup>(); }
        }
    }
}
