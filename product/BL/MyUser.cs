using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.BL
{
    class MyUser
    {
        public MyUser(string username , string password , string userRole)
        {
            this.username = username;
            this.password = password;
            this.userRole = userRole;
        }
       
        public string username;
        public string password;
        public string userRole;
        
        
       
    }
}
