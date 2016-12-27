using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NeoStore.HomePage
{
    public class HomepageModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand MycartClick { get; set; }
        public ICommand TablesClick { get; set; }
        public ICommand SofasClick { get; set; }
        public ICommand ChairClick { get; set; }
        public ICommand CupboardClick { get; set; }
        public ICommand AccountClick { get; set; }
        public ICommand StoreLocationClick { get; set; }
        public ICommand MyOrdersClick { get; set; }
        public ICommand LogoutClick { get; set; }

        public HomepageModelView()
        {

        }
    }
}
