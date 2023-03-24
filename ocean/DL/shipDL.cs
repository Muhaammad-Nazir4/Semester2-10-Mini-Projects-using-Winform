using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean.UI;
using ocean.BL;
using System.IO;
namespace ocean.DL
{
    class shipDL
    {
       public static List<ship> ships_data = new List<ship>();
        public static void changeDirection(List<ship> ships_data)
        {
            Console.WriteLine("Enter ship serial number to find its position......");
            string Serial_number = Console.ReadLine();
                     
            int idx = searchData(ships_data, Serial_number);
            ships_data[idx] = shipUI.AddShip();
        }
        public static int searchData(List<ship> ships_data, string SR_number)
        {
            int idx = 0;
            for (int i = 0; i < ships_data.Count; i++)
            {

                if (SR_number == ships_data[i].getShipNumber())
                {
                    idx = i;
                }

            }
            return idx;

        }
        public static void AddShipDataIntoList(List<ship> ships_data, ship data)
        {
            ships_data.Add(data);
        }
        public static void printPosition(ship data)
        {
           
            Console.WriteLine("ship is at " + "\t" + data.latitude.getDegree() + "\u00b0" + data.latitude.getMinutes() + "\t" + data.latitude.getDirection() + "and" + "\t" +
                data.longitude.getDegree() + "\u00b0" + data.longitude.getMinutes() + "'" + "\t" + data.longitude.getDirection());
        }
        public static void printNumber(ship data)
        {
            Console.WriteLine("The seriol number is" +  "\t" + data.getShipNumber());
        }

        public static void findshipNumber(List<ship> ships_data)
        {
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
            Console.WriteLine("Enter Ship Longitude's minutes:");
            float Long_minutes = float.Parse(Console.ReadLine());
            while (Long_degree < 0 || Long_degree > 180)
            {
                Console.WriteLine("Enter valid Ship Longitude's degree:");
                Long_degree = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Ship Longitude's direction:");
            string Long_direction = Console.ReadLine();
            while (Long_direction != "east" && Long_direction != "west")
            {
                Console.WriteLine("Enter valid Ship Longitude's direction:");
                Long_direction = Console.ReadLine();
            }
            bool flag = false;
            for (int i = 0; i < ships_data.Count; i++)
            {
                if (Lat_degree == ships_data[i].latitude.getDegree() && Lat_minutes == ships_data[i].latitude.getMinutes() &&
                    Lat_direction == ships_data[i].latitude.getDirection() && Long_degree == ships_data[i].longitude.getDegree() &&
                    Long_minutes == ships_data[i].longitude.getMinutes() && Long_direction == ships_data[i].longitude.getDirection())
                {
                    printNumber(ships_data[i]);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Not Found.");
            }
        }

        public static void storeData( ship data)
        {
            string path1 = "E:\\assignment\\ocean\\shipdata.txt";
            StreamWriter file = new StreamWriter(path1, true);                     
                file.WriteLine(data.getShipNumber() + "," + data.latitude.getDegree() + "," + data.latitude.getMinutes() + "," + data.latitude.getDirection() + "," +
                 data.longitude.getDegree() + "," + data.longitude.getMinutes() + "," + data.longitude.getDirection());                   
            file.Flush();
            file.Close();
        }

       public static bool readData()
        {
            string path1 = "E:\\assignment\\ocean\\shipdata.txt";
            StreamReader file = new StreamReader(path1);
            string record;
            if (File.Exists(path1))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string ship = splittedRecord[0];
                    int lat_degree = int.Parse(splittedRecord[1]);
                    float lat_minutes = float.Parse(splittedRecord[2]);
                    string lat_direction = splittedRecord[3];
                    int long_degree = int.Parse(splittedRecord[4]);
                    float long_minutes = float.Parse(splittedRecord[5]);
                    string long_direction = splittedRecord[6];
                   
                    ship data = new ship(ship, lat_degree, lat_minutes, lat_direction, long_degree, long_minutes, long_direction);
                    ships_data.Add(data);
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
