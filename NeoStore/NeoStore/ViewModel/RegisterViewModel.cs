using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.ViewModel
{
    public class RegisterViewModel : INotifyPropertyChanged, IValidation
    {
        public int MyProperty { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        

        public void OnRegClicked(object sender, EventArgs e)
        {

            DisplayAlert("hi", "hi", "Ok");
        }

        public void numberLength()
        {
            DisplayAlert("Error", "Enter Correct Contact Number", "Ok");
        }

        public void Fname()
        {
            DisplayAlert("Error", "FirstName can not be null", "Ok");
        }

        public void Lname()
        {
            DisplayAlert("Error", "FirstName can not be null", "Ok");
        }

        public void EmailID()
        {
            DisplayAlert("Error", "FirstName can not be null", "Ok");
        }

        public void Pass()
        {
            DisplayAlert("Error", "FirstName can not be null", "Ok");
        }

        public void ConfirmPass()
        {
            DisplayAlert("Error", "FirstName can not be null", "Ok");
        }
    }
}
