using NeoStore.RegisterPage;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.RegisterPage
{
    
    public class DatabaseManager
    {
        IRestServices restservices;
        public DatabaseManager(IRestServices service)
        {
            restservices = service;
        }
        public async Task SaveTaskAsync(RegisterViewModel item)
        {
            string err;
           var abc = await restservices.RegisterUserDetails(item);
            if ((abc.stat) == 200)
                err = "Registration Successful";
            else
                err = "Registration UnSuccessful";

            MessagingCenter.Send<DatabaseManager, string>(this, "validate2", err);
        }
    }
}
