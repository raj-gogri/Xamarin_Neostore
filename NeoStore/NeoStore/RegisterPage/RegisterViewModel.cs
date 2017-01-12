    using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;



using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;

namespace NeoStore.RegisterPage
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string First_name;
        private string Last_name;      
        private string Email;
        private string Password;
        private string Confirm_password;
        private string Gender;
        private string isOn;
        private int Phone_no;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OnRegClicked { get; set; }        
        string err=null;

        public RegisterViewModel()
        {                    

            OnRegClicked = new Command(
                () =>
                 {
                     CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

                     if (first_name == null)
                         err = "First Name can not be null";
                     else if (last_name == null)
                         err = "Last Name can not be null";
                     else if (email == null)
                         err = "Email Id can not be null";
                     else if (password == null)
                         err = "Password can not be null";
                     else if (confirm_password == null || confirm_password != password)
                         err = "Enter Correct Password";
                     else if (gender == null)
                         err = "Select Gender";
                     else if ((phone_no.ToString()).Length != 10)
                         err = "Enter Correct Number";
                     else if (phone_no.ToString() == null)
                         err = "Enter Correct Number";
                     else if (IsOn == false)
                         err = "Check Terms And Conditions";

                     if (err==null)
                     {                        
                         App.dbManager.SaveTaskAsync(this);
                     }
                     else
                        MessagingCenter.Send<RegisterViewModel, string>(this, "validate1", err);                     
                 });
        }

        private void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (!e.IsConnected)

                MessagingCenter.Send<RegisterViewModel, string>(this, "InternetConnection", "PLease Check Internet Conncetion");
        }


        public string first_name
        {
            get
            {
                return First_name;
            }
            set
            {
                First_name = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("first_name"));
                }
            }
        }
        public string last_name
        {
            get
            {
                return Last_name;
            }
            set
            {
                Last_name = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("last_name"));
                }
            }
        }
        [PrimaryKey]
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("email"));
                }
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("password"));
                }
            }
        }       
        public bool IsOn
        {
            get
            {
                return bool.Parse ((isOn==null)?"false":isOn);
            }
            set
            {
                isOn =  (value==false?"false":value.ToString());
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("ison"));
                }
            }
        }
        public string gender
        {
            get
            {
                return ((gender1 == false) ? "M" : "F");
            }
        }
        public bool gender1
        {
            get
            {
                return bool.Parse ((Gender==null)?"false":Gender);
            }
            set
            {
                Gender =  (value==false?"false":value.ToString());
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("gender1"));
                }
            }
        }
        public string confirm_password
        {
            get
            {
                return Confirm_password;
            }
            set
            {
                Confirm_password = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("confirm_password"));
                }
            }
        }
        public int phone_no
        {
            get
            {
                return Phone_no;
            }
            set
            {
                Phone_no = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("phone_no"));
                }
            }
        }

     }
}
