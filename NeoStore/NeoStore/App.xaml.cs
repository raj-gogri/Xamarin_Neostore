using NeoStore.HomePage;
using NeoStore.Loginpage;
using NeoStore.RegisterPage;
using System.Linq;

using Xamarin.Forms;

namespace NeoStore
{
    public partial class App : Application
    {

        public static DatabaseManager dbManager { get; private set; }

        public static HomepageManager hpManager { get; private set; }
        public static UserDetailsResponseData UserLoggedInDetails { get; set; }
        public static RegistrationDetailDatabase database;        
        public App()
        {
            InitializeComponent();
            UserLoggedInDetails = App.Database.GetItems().FirstOrDefault();
            dbManager = new DatabaseManager(new RestServices());
            hpManager = new HomepageManager();
           // hpManager = new HomepageManager(new HomepageRestServices());
            if (UserLoggedInDetails == null)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new HomePage.Homepage();

            }

        }
        public static RegistrationDetailDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new RegistrationDetailDatabase();
                }
                return database;
            }
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
