using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean.UI
{
    class menuUI
    {
        public static void header()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("**************Ocean Navigation System*************");
            Console.WriteLine("**************************************************");
        }
        public static string menu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship position");
            Console.WriteLine("3.View Ship serial number");
            Console.WriteLine("4.Change ship position");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Choose option.....");
            string option = Console.ReadLine();
            return option;
        }
        public static void clear()
        {
            Console.WriteLine("Press any key to continue.....");
            Console.ReadLine();
        }
    }
}
