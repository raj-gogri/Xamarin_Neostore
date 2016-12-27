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
using NeoStore.Droid;
using SQLite;
using System.IO;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAndroid))]

namespace NeoStore.Droid
{
    class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid()
        { }
        public SQLiteConnection GetConnection()
        {
            var sqlitefilename = "NeoStore.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqlitefilename);

            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}