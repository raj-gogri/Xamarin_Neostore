using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore
{
   public class LoginViewModel:INotifyPropertyChanged
    {
        private string Email;
        private string passWord;
        public ICommand OnloginClicked { get; set; }
        string err;
        public LoginViewModel()
        {
            OnloginClicked = new Command(
                ()=>
                {
                    if (((email == null)|| email== "")||(( password == null) || (password=="")))
                    {   
                        err = "Email/Password cannot be empty";
                        MessagingCenter.Send<LoginViewModel, string>(this, "Warning", err);
                    }
                    else
                    {
                        App.Loginmanager.LoginTaskAsync(this);
                    }
                });           
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                if (Email != value)
                {
                    Email = value;

                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("email"));
                    }
                }
            }
        }
        public string password
        {
            get
            {
                return passWord;
            }
            set
            {
                if (passWord != value)
                {
                    passWord = value;
                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("password"));
                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
