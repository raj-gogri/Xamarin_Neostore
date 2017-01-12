using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.ForgetPasswordPage
{
    class ForgetPasswordViewModel
    {
        public static ForgetPasswordManager ForgetPasswordmanager { get; set; }
        private string Email;
        public ICommand OnSendMailClicked { get; set; }
        string err;
        public ForgetPasswordViewModel()
        {
            ForgetPasswordmanager = new ForgetPasswordManager(new ForgetPasswordRestService());
            OnSendMailClicked = new Command(
                ()=>
                {
                    if ((email == null) || (email == ""))
                    {
                        err = "Email cannot be empty";
                        MessagingCenter.Send<ForgetPasswordViewModel, string>(this, "Warning", err);
                    }
                    else
                    {
                        ForgetPasswordmanager.ForgetPasswordTaskAsync(this);
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
        public event PropertyChangedEventHandler PropertyChanged;

    }
}