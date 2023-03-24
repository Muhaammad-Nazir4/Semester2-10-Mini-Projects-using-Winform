using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesha.BL;
namespace tesha.UI
{
    class menuItemUI
    {
        public static menuItem addMenuItem()
        {
            string item_name, item_type;
            float item_price;
            Console.WriteLine("Enter name of the item: ");
            item_name = Console.ReadLine();
            Console.WriteLine("Enter type of the item: ");
            item_type = Console.ReadLine();
            Console.WriteLine("Enter price of the item");
            item_price = float.Parse(Console.ReadLine());
            menuItem data = new menuItem(item_name, item_type, item_price);
            return data;

        }

       public  static void viewDrinkItems(List<menuItem> menuList)
        {
            bool flag = false;
            for (int i = 0; i < menuList.Count; i++)
            {


                if (menuList[i].item_type == "Drink" || menuList[i].item_type == "drink")
                {
                    Console.WriteLine();
                    Console.WriteLine("...........................View Drink items........................... ");
                    Console.WriteLine();
                    Console.WriteLine("Item's Name" + "\t" + "Item's Price");
                    Console.WriteLine();
                    flag = true;
                    if (flag == true)
                    {
                        Console.WriteLine(menuList[i].item_name + "\t\t" + menuList[i].item_price);
                    }
                    else
                    {
                        Console.WriteLine("There is no item of drink type..........");
                    }
                }
            }
        }
       public  static void viewFoodItems(List<menuItem> menuList)
        {
            bool flag = false;
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine();

                if (menuList[i].item_type == "Food" || menuList[i].item_type == "food")
                {
                    Console.WriteLine(".........................View Food items.......................... ");
                    Console.WriteLine();
                    Console.WriteLine("Item's Name" + "\t" + "Item's Price");
                    Console.WriteLine();
                    flag = true;
                    if (flag == true)
                    {
                        Console.WriteLine(menuList[i].item_name + "\t\t" + menuList[i].item_price);
                    }
                    else
                    {
                        Console.WriteLine("There is no item of food type..........");
                    }
                }

            }
        }
    }
}
