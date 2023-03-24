using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean.BL;
using ocean.DL;
namespace ocean.UI
{
    class shipUI
    {
        public static ship AddShip()
        {
            Console.WriteLine("Enter Ship number:");
            string shipNumber = Console.ReadLine();
            Console.WriteLine("Enter Ship Lattitude:.............");
            Console.WriteLine("Enter Ship Lattitude's degree:");
            int Lat_degree = int.Parse(Console.ReadLine());
            while (Lat_degree < 0 || Lat_degree > 90)
            {
                Console.WriteLine("Enter valid Ship Lattitude's degree:");
                Lat_degree = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Ship Lattitude's minutes:");
            float Lat_minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Lattitude's direction:");
            string Lat_direction = Console.ReadLine();
            while (Lat_direction != "north" && Lat_direction != "south")
            {
                Console.WriteLine("Enter valid Ship Lattitude's direction:");
                Lat_direction = Console.ReadLine();
            }
            Console.WriteLine("Enter Ship Longitude:................");
            Console.WriteLine("Enter Ship Longitude's degree:");
            int Long_degree = int.Parse(Console.ReadLine());
            while (Long_degree < 0 || Long_degree > 180)
            {
                Console.WriteLine("Enter valid Ship Longitude's degree:");
                Long_degree = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Ship Longitude's minutes:");
            float Long_minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude's direction:");
            string Long_direction = Console.ReadLine();
            while (Long_direction != "east" && Long_direction != "west")
            {
                Console.WriteLine("Enter valid Ship Longitude's direction:");
                Long_direction = Console.ReadLine();
            }
            ship ship_data = new ship(shipNumber, Lat_degree, Lat_minutes, Lat_direction, Long_degree, Long_minutes, Long_direction);
            return ship_data;

        }
        public static void printShipPosition(List<ship> ships_data)
        {

            Console.WriteLine("Enter ship serial number to find its position......");
            string Serial_number = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < ships_data.Count; i++)
            {
                if (Serial_number == ships_data[i].getShipNumber())
                {
                   shipDL.printPosition(ships_data[i]);
                    flag = true;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("Not Found.");
            }
        }
       
    }
}
