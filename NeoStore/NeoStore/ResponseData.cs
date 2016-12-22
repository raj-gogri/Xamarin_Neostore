using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore
{
    public class ResponseData
    {
        public int ID { get; set; }
        public int Role_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email{ get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Phone_No { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Nodified { get; set; }

        public string Access_Token { get; set; }
    }
}
