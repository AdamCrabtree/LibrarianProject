using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarinProject
{
    public class User
    {
        public string username { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string user_id { get; set;}
        public string success { get; set; } //check if login was sucessful
        public string role { get; set; } //1 for user 2 for administrator 3 for root
    }
}
