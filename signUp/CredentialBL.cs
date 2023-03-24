using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp
{
    class MyUser
    {
        public MyUser(string username, string password, string userRole)
        {
            setUserName(username);
            setPassword(password);
            setUserrole(userRole);
        }

        private string username;
        private string password;
        private string userRole;

        public string getUserName()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public string getUserRole()
        {
            return userRole;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setUserrole(string userRole)
        {
            this.userRole = userRole;
        }
    }
}
