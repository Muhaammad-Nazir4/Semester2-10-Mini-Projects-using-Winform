using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesha.BL;
namespace tesha.DL
{
    class coffeShopDL
    {
       
        public static List<string> order = new List<string>();
        public static void AddOrderIntoList(List<string> order, string item)
        {
            order.Add(item);
        }
       
    }
}
