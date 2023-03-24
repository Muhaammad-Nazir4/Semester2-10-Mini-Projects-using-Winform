using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using line.BL;

namespace line.UI
{
    class MyLineUI
    {
        public  static void formLine(myLine details)
        {
            Console.WriteLine("Enter x1 coordinate for begin point.....");
            details.getBegin().setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter y1 coordinate for begin point.....");
            details.getBegin().setY(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter x2 coordinate for begin point.....");
            details.getEnd().setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter y2 coordinate for begin point.....");
            details.getEnd().setY(int.Parse(Console.ReadLine()));
        }
        public static void updateBeginPoint(myLine data)
        {
            Console.WriteLine("Enter x1 coordinate for begin point.....");
            data.getBegin().setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter y1 coordinate for begin point.....");
            data.getBegin().setY(int.Parse(Console.ReadLine()));
        }

        public static void updateEndPoint(myLine data)
        {
            Console.WriteLine("Enter x2 coordinate for begin point.....");
            data.getEnd().setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter y2 coordinate for begin point.....");
            data.getEnd().setY(int.Parse(Console.ReadLine()));
        }
        public static void displayUpdate(myLine point)
        {
            Console.WriteLine("X1 Coordinate:" + point.getBegin().getX());
            Console.WriteLine("Y1 Coordinate:" + point.getBegin().getY());
            Console.WriteLine("X2 Coordinate:" + point.getEnd().getX());
            Console.WriteLine("Y2 Coordinate:" + point.getEnd().getY());
        }
        public static void displayEndPoints(myLine point)
        {
            Console.WriteLine("X Coordinate of end Point is:" + point.getEnd().getX());
            Console.WriteLine("Y Coordinate of end Point is:" + point.getEnd().getY());
        }
        
    }
}
