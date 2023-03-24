using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean.BL
{
    class angle
    {
       
        private int degree;
        private float minutes;
        private string direction;

        public int getDegree()
        {
            return degree;
        }
        public float getMinutes()
        {
            return minutes;
        }
        public string getDirection()
        {
            return direction;
        }
        public void setDegree(int degree)
        {
            this.degree = degree;
        }
        public void setMinutes(float minutes)
        {
            this.minutes = minutes;
        }
        public void setDirection(string direction)
        {
            this.direction = direction;
        }

    }
}
