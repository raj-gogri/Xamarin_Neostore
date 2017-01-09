using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.HomePage
{
    class MasterPageViewModel: INotifyPropertyChanged
    {
        public string fname;
        public string lname;
        public string src;
        public string emailid;
        public ObservableCollection<MasterList> productList;
        public event PropertyChangedEventHandler PropertyChanged;
        public string fullname
        {
            get
            {
                return first_name+" "+last_name; 
            }            

        }
        public string first_name
        {
            get
            {
                return fname;
            }
            set
            {
                fname=value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("first_name"));
            }
        }
        public string last_name
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("last_name"));
            }
        }

        public string profile_pic
        {
            get
            {
                return src;
            }
            set
            {
                src = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("profile_pic"));
            }
        }

        public string email
        {
            get
            {
                return emailid;
            }
            set
            {
                emailid = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("email"));
            }
        }

        public MasterPageViewModel()
        {
            
        }
        
        public ObservableCollection<MasterList> ProductList
        {
            get
            {               
                return productList;
            }
            set
            {
                productList = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("ProductList"));
            }
        }
    }
}
