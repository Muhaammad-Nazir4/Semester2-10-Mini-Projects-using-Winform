using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using line.BL;
using line.UI;
using line.DL;

namespace line
{
    class Program
    {     
        static void Main(string[] args)
        {
             //myLIneDL.readData();
            myLine point = new myLine();
            string option;
            do
            {
                Console.Clear();
                option = menuUI.menu();
                if (option == "1")
                {
                    menuUI.Header();
                    MyLineUI.formLine(point);
                    //myLIneDL.storeData();
                    menuUI.clearScreen();
                }
                else if (option == "2")
                {
                    menuUI.Header();
                    MyLineUI.updateBeginPoint(point);
                    menuUI.clearScreen();
                }
                else if (option == "3")
                {
                    menuUI.Header();
                    MyLineUI.updateEndPoint(point);
                    menuUI.clearScreen();
                }
                else if (option == "4")
                {
                    menuUI.Header();
                    MyLineUI.displayUpdate(point);
                    menuUI.clearScreen();
                }
                else if (option == "5")
                {
                    menuUI.Header();
                    MyLineUI.displayEndPoints(point);
                    menuUI.clearScreen();
                }
                else if (option == "6")
                {
                    menuUI.Header();
                    double lengthOfLine;
                    lengthOfLine = myLine.getLength(point);
                    Console.WriteLine("Length of Line is:" + lengthOfLine);
                    menuUI.clearScreen();

                }
                else if (option == "7")
                {
                    menuUI.Header();
                    double slope;
                    slope = myLine.getGradient(point);
                    Console.WriteLine("Gradient of Line is:" + slope);
                    menuUI.clearScreen();
                }
                else if (option == "8")
                {
                    menuUI.Header();
                    double length;
                    length = myLine.DistanceoFBeginPointFromZero(point);
                    Console.WriteLine("Length of Begin Point from Zero:" + length);
                    menuUI.clearScreen();
                }
                else if (option == "9")
                {
                    menuUI.Header();
                    double length;
                    length = myLine.DistanceoFEndPointFromZero(point);
                    Console.WriteLine("Length of End Point from Zero:" + length);
                    menuUI.clearScreen();
                }
            }
            while (option != "10");
     
            }
        }
    }

