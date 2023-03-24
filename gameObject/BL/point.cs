using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gameObject.BL
{
    class point
    {
        // constructors.......................
      
        public point(int x_coordinate , int y_coordinate)
        {
            this.x_coordinate = x_coordinate;
            this.y_coordinate = y_coordinate;
        }
        //attributes..................
        public int x_coordinate;
         public int y_coordinate;
       //member functions ..................
        public int getX()
        {
            return x_coordinate;
        }
        public int getY()
        {
            return y_coordinate;
        }
        public void setX(int x_coordinate)
        {
            this.x_coordinate = x_coordinate;
        }
        public void setY(int y_coordinate)
        {
            this.y_coordinate = y_coordinate;
        }
        public void setXY(int x_coordinate, int y_coordinate)
        {
            this.x_coordinate = x_coordinate;
            this.y_coordinate = y_coordinate;
        }
    }
}
