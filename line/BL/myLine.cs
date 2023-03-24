using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using line.BL;
using line.DL;

namespace line.BL
{
    class myLine
    {
        //attributes...............
        private myPoint begin=new myPoint();
        private myPoint end=new myPoint(); 
        //constructors...............
        public myLine(myPoint begin, myPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public myLine()
        {

        }
        // member functions..................
        public myPoint getBegin()
        {
            return begin;
        }
        public myPoint getEnd()
        {
            return end;
        }
        public void setBegin(myPoint begin)
        {
            this.begin=begin;
        }
        public void setEnd(myPoint end)
        {
            this.end = end;
        }

        public static double getLength(myLine data)
        {
            double length;
            double result1 = Math.Pow((data.getEnd().getX()- data.getBegin().getX()), 2);
            double result2 = Math.Pow((data.getEnd().getY() - data.getBegin().getY()), 2);
            length = Math.Sqrt(result1 + result2);
            return length;
        }

        public static  double getGradient(myLine data)
        {
            double gradient;
            double numerator = (data.getEnd().getY() - data.getBegin().getY());
            double denominator = (data.getEnd().getX() - data.getBegin().getX());
            gradient = (numerator / denominator);
            return gradient;
        }

        public static double DistanceoFBeginPointFromZero(myLine data)
        {
            double length;
            double result1 = Math.Pow((0 - data.getBegin().getY()), 2);
            double result2 = Math.Pow((0 - data.getBegin().getX()), 2);
            length = Math.Sqrt(result1 + result2);
            return length;

        }

        public static double DistanceoFEndPointFromZero(myLine data)
        {
            double length;
            double result1 = Math.Pow((data.getEnd().getY() - 0), 2);
            double result2 = Math.Pow((data.getEnd().getX() - 0), 2);
            length = Math.Sqrt(result1 + result2);
            return length;

        }
    }
}
