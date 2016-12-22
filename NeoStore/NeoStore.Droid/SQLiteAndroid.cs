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
using System.Runtime.CompilerServices;
using NeoStore.Droid;
using Xamarin.Forms;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof (SQLiteAndroid))]

namespace NeoStore.Droid
{
    class SQLiteAndroid:ISQLite
    {
        public SQLiteAndroid()
        { }

        public SQLiteConnection GetConnection()
        {
            var sqlitefilename = "TodoSQLite.db3";
            string documentsPath =System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath,sqlitefilename);
            if(!File.Exists(path))
            {
                var s = Forms.Context.Resources.OpenRawResource(Resource.Raw.TodoSQLite);
            }

            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}