using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean.BL
{
    class ship
    {
        public ship()
        {

        }
        public ship(string shipNumber, int lat_degree, float lat_minutes, string lat_direction,
          int long_degree, float long_minutes, string long_direction)
        {
            setShipNumber(shipNumber);
            latitude.setDegree(lat_degree);
            latitude.setMinutes(lat_minutes);
            latitude.setDirection(lat_direction);
            longitude.setDegree(long_degree);
            longitude.setMinutes(long_minutes);
            longitude.setDirection(long_direction);
        }
        
        private string shipNumber;
        public angle latitude = new angle () ;
        public angle longitude = new angle();
        //.............member Functions............
        public string getShipNumber()
        {
            return shipNumber;
        }
        public void setShipNumber(string shipNumber)
        {
             this.shipNumber = shipNumber;
        }


    }
}
