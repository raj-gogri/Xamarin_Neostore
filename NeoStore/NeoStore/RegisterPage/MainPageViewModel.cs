using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.RegisterPage
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand OnRegisterClicked { get; set; }

        public MainPageViewModel()
        {
            OnRegisterClicked = new Command(
               () =>
               {
                   MessagingCenter.Send<MainPageViewModel>(this, "Navigate");
               });
        }
    }
}
