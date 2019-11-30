using System;
using System.ComponentModel;
using System.Windows.Input;
using HDDPHDemo.Services;
using Xamarin.Forms;

namespace HDDPHDemo
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        private readonly IPushService pushService = DependencyService.Get<IPushService>();

        public ICommand GetTokenCommand { get; set; }


        public MainPageViewModel()
        {
            GetTokenCommand = new Command(GetToken);
        }


        void GetToken()
        {

        }

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
