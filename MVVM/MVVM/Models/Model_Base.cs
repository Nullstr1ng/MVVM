//using System.Collections.Generic;
//using System.ComponentModel;

//namespace MVVM.Models
//{
//    public class Model_Base : INotifyPropertyChanged
//    {
//        /// <summary>
//        /// Assigns a new value to the property. Then, raises the PropertyChanged event if needed.
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="propertyName"></param>
//        /// <param name="field"></param>
//        /// <param name="newValue"></param>
//        public bool Set<T>(string propertyName, ref T field, T newValue = default(T))
//        {
//            bool ret = false;

//            if (EqualityComparer<T>.Default.Equals(field, newValue))
//            {
//                field = newValue;
//                RaisePropertyChangedEvent(propertyName);
//                ret = true;
//            }

//            return ret;
//        }

//        #region INotifyPropertyChanged implementation
//        public event PropertyChangedEventHandler PropertyChanged;
//        protected void RaisePropertyChangedEvent(string propertyName)
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//        #endregion
//    }
//}
