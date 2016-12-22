using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore
{
    public class ResponseData
    {
        [PrimaryKey, AutoIncrement]
        public int id{ get; set; }
        public int role_id { get; set; }
        public string first_name{ get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string profile_pic { get; set; }
        public string country_id { get; set; }
        public string gender { get; set; }
        public int phone_no { get; set; }
        public string dob { get; set; }
        public Boolean is_active { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string access_Token { get; set; }

    }
}
