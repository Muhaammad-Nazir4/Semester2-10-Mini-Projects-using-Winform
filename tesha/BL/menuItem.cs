using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesha.BL
{
    class menuItem
    {
        public menuItem()
        {

        }
        public menuItem(string item_name, string item_type, float item_price)
        {
            this.item_name = item_name;
            this.item_type = item_type;
            this.item_price = item_price;
        }
        public string item_name;
        public string item_type;
        public float item_price;

        public static menuItem getCheepest(List<menuItem> menuList)
        {
            menuItem data = new menuItem();
            data.item_price = 1000000000000000F;
            data.item_name = "";
            for (int i = 0; i < menuList.Count; i++)
            {

                if (menuList[i].item_price < data.item_price)
                {
                    data.item_price = menuList[i].item_price;
                    data.item_name = menuList[i].item_name;

                }
            }
            return data;
        }
        public static void BillPayableAmount(List<menuItem> menuList, List<string> order)
        {
            float sum = 0F;
            foreach (menuItem i in menuList)
            {
                foreach (string j in order)
                {
                    if (i.item_name == j)
                    {
                        sum = sum + i.item_price;
                    }
                }
        }
            Console.WriteLine("total price of ordered is :" + "\t" + sum);
        }
    }
}

