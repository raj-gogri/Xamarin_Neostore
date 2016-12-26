using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace NeoStore.RegisterPage
{
    public class RegistrationDetailDatabase
    {
        SQLiteConnection con;
        RestServices rest;
        public RegistrationDetailDatabase()
        {
            con = DependencyService.Get<ISQLite>().GetConnection();
            con.CreateTable<RegistrationResponse>();
        }

        public IEnumerable<RegistrationResponse> GetMsgs()
        {
            return (from t in con.Table<RegistrationResponse>()
                    select t).ToList();
        }
     
        public int AddMsg(RegistrationResponse msg)
        {
            return con.Insert(msg);
        }
    }
}

