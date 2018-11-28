using GalaSoft.MvvmLight.Ioc;

namespace MVVM.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel_MainPage>();
        }

        public ViewModel_MainPage Main
        {
            get { return SimpleIoc.Default.GetInstance<ViewModel_MainPage>(); }
        }
    }
}
