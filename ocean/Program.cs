using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean.BL;
using ocean.UI;
using ocean.DL;
namespace ocean
{
    class Program
    {
       
        static void Main(string[] args)
        {
            shipDL.readData();
            string option;
            menuUI.header();
            option = menuUI.menu();
            while (true)
            {
                if (option == "1")
                {
                    Console.Clear();
                    menuUI.header();
                    ship data = shipUI.AddShip();
                    shipDL.AddShipDataIntoList(shipDL.ships_data, data);
                    shipDL.storeData( data);
                    menuUI.clear();
                    Console.Clear();
                    option = menuUI.menu();
                }
                if (option == "2")
                {
                    Console.Clear();
                    menuUI.header();
                    shipUI.printShipPosition(shipDL.ships_data);
                    menuUI.clear();
                    Console.Clear();
                    option = menuUI.menu();
                }
                if (option == "3")
                {
                    Console.Clear();
                    menuUI.header();
                    shipDL.findshipNumber(shipDL.ships_data);
                    menuUI.clear();
                    Console.Clear();
                    option = menuUI.menu();
                }
                if (option == "4")
                {
                    Console.Clear();
                    menuUI.header();
                    shipDL.changeDirection(shipDL.ships_data);
                    menuUI.clear();
                    Console.Clear();
                    option = menuUI.menu();
                }
                if (option == "5")
                {
                    break;
                }
            }
           
        }
    }
}
