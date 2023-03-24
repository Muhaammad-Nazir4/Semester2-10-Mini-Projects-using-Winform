using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesha.BL;

namespace tesha.UI
{
    class coffeShopUI
    {
        public static string AddOrder(List<menuItem> menuList)
        {
            string order_item;
            bool flag = false;
            Console.WriteLine("Enter the name of item that you want to order...........");
            order_item = Console.ReadLine();

            foreach (menuItem M in menuList)
            {
                if (M.item_name == order_item)
                {
                    flag = false;
                    break;
                }
                if (flag == true)
                {
                    Console.WriteLine("You have ordered Successfully.");
                }
                else if (flag == false)
                {
                    Console.WriteLine("You cannot order because the item is not present.");

                }
                return order_item;

            }
            return order_item;

        }
        public static void ViewOrderList(List<string> order)
        {
            Console.WriteLine("...............................View Orders................................");
            for (int i = 0; i < order.Count; i++)
            {
                Console.WriteLine(order[i]);
            }

        }
        public static void fullFillOrders(List<string> order)
        {
            if (order == null)
            {
                Console.WriteLine("Orders are already fulfilled");
            }

            if (order != null)
            {
                for (int i = 0; i < order.Count; i++)
                {
                    Console.WriteLine(order[i] + "\t" + "is ready");
                }
                order = null;
            }

        }
    }
}
