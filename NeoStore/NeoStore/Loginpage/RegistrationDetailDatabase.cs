using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using NeoStore;

namespace NeoStore.Loginpage
{
    public class RegistrationDetailDatabase
    {
        SQLiteConnection database;
        public RegistrationDetailDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<UserDetailsResponseData>();
        }
        public IEnumerable<UserDetailsResponseData> GetItems()
        {
            return (from i in database.Table<UserDetailsResponseData>() select i).ToList();
        }
        public int SaveItemdb(UserDetailsResponseData userdetails)
        {
            return database.Insert(userdetails);
        }
        public UserDetailsResponseData GetItem(int id)
        {
            return database.Table<UserDetailsResponseData>().FirstOrDefault(x => x.id == id);
        }
        public int DeleteUserDetails(UserDetailsResponseData userdetails)
        {
            return database.Delete(userdetails);
        }
    }
}
