using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;

namespace NeoStore.Droid
{
    class SQLiteAndroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var FileName = "SomeItemList.db";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, FileName);

            var con = new SQLite.SQLiteConnection(path);
            return con;
        }
    }
}