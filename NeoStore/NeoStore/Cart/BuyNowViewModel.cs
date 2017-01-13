using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.Cart
{
    public class BuyNowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static BuyNowManger buynowmanager { get; set; }
        public int quant;
        public ICommand OnSubmitClicked { get; set; }
        string err = null;
        public BuyNowViewModel()
        {
            buynowmanager= new BuyNowManger(new BuyNowRestService());
            OnSubmitClicked = new Command(
                () =>
                {
                    if(quantity>0 && quantity<9)
                        buynowmanager.BuyNowTaskAsync(this);
                    else
                        MessagingCenter.Send<BuyNowViewModel, string>(this, "quantValidate", "Quantity must be in between 0 to 8");
                });
        }
        public int quantity
        {
            get
            {
                return quant;
            }
            set
            {
                quant=value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("quantity"));
                }
            }
        }
    }
}
