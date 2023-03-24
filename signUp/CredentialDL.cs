using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace signUp
{
    class CredentialDL
    {
        public static List<MyUser> signUpdata = new List<MyUser>();
        public static void addSignUpIntoList(MyUser credential)
        {
            signUpdata.Add(credential);
        }
        public static string SignIn(string username, string password, List<MyUser> sign)
        {
            foreach (MyUser storedata in sign)
            {
                if (username == storedata.getUserName() && password == storedata.getPassword())
                {
                    return storedata.getUserRole();
                }
            } 
            return "NA";

        }
        public static void storeData(MyUser data)
        {

            string path1 = "E:\\assignment\\product\\LoginData.txt";
            StreamWriter file = new StreamWriter(path1, true);
            file.WriteLine(data.getUserName() + "," + data.getPassword() + "," + data.getUserRole());
            file.Flush();
            file.Close();
        }

        public static bool readData()
        {
            string path1 = "E:\\assignment\\product\\LoginData.txt";
            StreamReader file = new StreamReader(path1);
            string record;
            if (File.Exists(path1))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string userRole = splittedRecord[2];

                    MyUser data = new MyUser(username, password, userRole);
                    signUpdata.Add(data);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
