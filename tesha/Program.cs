using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesha.BL;
using tesha.UI;
using tesha.DL;
namespace tesha
{
    class Program
    {           
        static void Main(string[] args)
        {
            menuItemDL.readData();

                string option ;
            do
            {
                option = menuUI.menu();
                Console.Clear();
                if (option == "1")
                {
                    menuItem data;
                    menuUI.Header();
                    data = menuItemUI.addMenuItem();
                    menuItemDL.addItemIntolist(menuItemDL.menuList, data);
                    menuItemDL.storeData(data);
                    menuUI.clearScreen();
                }
                else if (option == "2")
                {
                    menuUI.Header();
                    menuItem data = menuItem.getCheepest(menuItemDL.menuList);
                    Console.WriteLine("Cheepest Product");
                    Console.WriteLine("Product name" + "\t" + "Product Price");
                    Console.WriteLine(data.item_name + "\t\t" + data.item_price);

                }
                else if (option == "3")
                {
                    menuUI.Header();
                    menuItemUI.viewDrinkItems(menuItemDL.menuList);
                    menuUI.clearScreen();
                }
                else if (option == "4")
                {
                    menuUI.Header();
                    menuItemUI.viewFoodItems(menuItemDL.menuList);
                    menuUI.clearScreen();
                }
                else if (option == "5")
                {
                    menuUI.Header();
                    string item = coffeShopUI.AddOrder(menuItemDL.menuList );
                    coffeShopDL.AddOrderIntoList(coffeShopDL.order, item);
                    menuUI.clearScreen();
                }
                else if (option == "6")
                {
                    menuUI.Header();
                    coffeShopUI.fullFillOrders(coffeShopDL.order);
                    menuUI.clearScreen();
                }
                else if (option == "7")
                {
                    menuUI.Header();
                    coffeShopUI.ViewOrderList(coffeShopDL.order);
                    menuUI.clearScreen();
                }
                else if (option == "8")
                {
                    menuUI.Header();
                    menuItem.BillPayableAmount(menuItemDL.menuList , coffeShopDL.order);
                    menuUI.clearScreen();
                }
            }
            while (option != "9");
                    
            }
        }
    }

