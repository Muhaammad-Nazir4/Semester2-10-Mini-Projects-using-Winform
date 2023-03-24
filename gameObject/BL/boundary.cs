using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameObject.BL
{
    class boundary
    {  
       
        public boundary()
        {
            topLeft.setXY(0,0);
            topRight.setXY(0,90);
            bottomLeft.setXY(90, 0);
            bottomRight.setXY(90,90);
        }
        public boundary(point topLeft,point topRight, point bottomLeft , point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }

      
        public point topLeft;
        public point topRight;
        public point bottomLeft;
        public point bottomRight;


    }
}

