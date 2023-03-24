using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesha.UI
{
    class menuUI
    {
        public static void Header()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("******************Tesha's Coffee Shop**************");
            Console.WriteLine("***************************************************");
        }
        public static string menu()
        {
            Header();
            string choice;
            Console.WriteLine("1) Add a Menu item");
            Console.WriteLine("2) View the Cheapest Item in the menu");
            Console.WriteLine("3) View the Drink’s Menu");
            Console.WriteLine("4) View the Food’s Menu");
            Console.WriteLine("5) Add Order");
            Console.WriteLine("6) Fulfill the Order");
            Console.WriteLine("7) View the Orders’s List");
            Console.WriteLine("8) Total Payable Amount");
            Console.WriteLine("9) Exit");
            Console.WriteLine("Choose your option ");
            choice = Console.ReadLine();
            Console.Clear();
            return choice;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue..........");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
