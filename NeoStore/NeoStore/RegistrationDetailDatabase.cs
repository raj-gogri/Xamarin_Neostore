using NeoStore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore
{
    public class RegistrationDetailDatabase
    {
        SQLiteConnection database;
        public RegistrationDetailDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<LoginResponse>();
        }
        public IEnumerable<LoginResponse> GetItems()
        {
            return (from i in database.Table<LoginResponse>() select i).ToList();
        }
        public ResponseData GetItem(int id)
        {
            return database.Table<ResponseData>().FirstOrDefault(x=>x.id==id);
        }
    }
}
