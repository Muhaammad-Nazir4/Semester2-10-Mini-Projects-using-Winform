using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace line.UI
{
    class menuUI
    {
        public static string menu()
        {
            Header();
            Console.WriteLine("1-Make a Line.......... ");
            Console.WriteLine("2-Update the begin point......... ");
            Console.WriteLine("3-Update the end point........... ");
            Console.WriteLine("4-Show the update point............ ");
            Console.WriteLine("5-Show the end point................ ");
            Console.WriteLine("6-Get the length of a Line............ ");
            Console.WriteLine("7-Get the gradient of a Line............ ");
            Console.WriteLine("8-Find he distnce of begin point from zero to coordinates...... ");
            Console.WriteLine("9-Find he distnce of end point from zero to coordinates........ ");
            Console.WriteLine("10-Exit ");
            Console.WriteLine("Enter your choice ................ ");
            string option;
            option = Console.ReadLine();
            Console.Clear();
            return option;
        }
        public static void Header()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("***********Point and Line Problem*******************");
            Console.WriteLine("****************************************************");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue............. ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
