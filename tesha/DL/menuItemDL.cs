using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesha.BL;
using System.IO;
namespace tesha.DL
{
    class menuItemDL
    {
        public static List<menuItem> menuList = new List<menuItem>();
        public static void addItemIntolist(List<menuItem> menuList, menuItem data)
        {
            menuList.Add(data);
        }
        public static void storeData(menuItem data)
        {
            string path1 = "E:\\assignment\\tesha\\menuItemData.txt";
            StreamWriter file = new StreamWriter(path1, true);
            file.WriteLine(data.item_name + "," + data.item_type + "," + data.item_price);
            file.Flush();
            file.Close();
        }
        public static bool readData()
        {
            string path1 = "E:\\assignment\\tesha\\menuItemData.txt";
           
            if (File.Exists(path1))
            {
                StreamReader file = new StreamReader(path1);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];                   
                    string type = splittedRecord[1];
                    float long_minutes = float.Parse(splittedRecord[2]);
                    menuItem data = new menuItem(name, type, long_minutes);
                    menuList.Add(data);
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
