using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameObject.BL;
using gameObject.DL;

namespace gameObject.UI
{
    class ObjectOfGameUI
    {
        public static void drawObject()
        {
            int y = ObjectOfGameDL.g1.startingPoint.getY();
            for (int i = 0; i < ObjectOfGameDL.shape.GetLength(0); i++)
            {
                int x = ObjectOfGameDL.g1.startingPoint.getX();
                for (int j = 0; j < ObjectOfGameDL.shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(ObjectOfGameDL.shape[i, j]);
                    x++;
                }
                Console.Write("\n");
                y++;
            }

        }
    }
}
