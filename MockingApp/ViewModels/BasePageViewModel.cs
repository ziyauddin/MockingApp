using MockingApp.Services;
using System.ComponentModel;

namespace MockingApp.ViewModels
{
    public class BasePageViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
        public IApiManager Api { get; set; }

        public BasePageViewModel()
        {
#if MOCK
             Api= new ApiMockManager();
#else
            Api = new ApiManager();
#endif
        }

        #region INotifyPropertyChanged implementation

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// On property changed
        /// </summary>
        /// <param name="propertyName"></param>
		protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
