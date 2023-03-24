using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameObject.BL;
using gameObject.UI;
namespace gameObject.DL
{
    class ObjectOfGameDL
    {
       public static char[,] shape = new char[6, 6] { { ' ', ' ', 'O','O', ' ', ' '} , { ' ', 'O', 'O','O', 'O', ' '} ,
               { 'M', 'N', 'A','Z', 'I', 'R'} ,{ ' ', 'O', 'O','O', 'O', ' '} , { ' ', ' ', 'O','O', ' ', ' '},
               { ' ', 'O', 'O','O', 'O', ' '}};
       public static boundary b = new boundary(new point(0, 0), new point(0, 90), new point(90, 0), new point(90, 90));

        //public static ObjectOfGame g1 = new ObjectOfGame(ObjectOfGameDL.shape, new point(10, 10), "LeftToRight", b);
        //public static ObjectOfGame g1 = new ObjectOfGame(ObjectOfGameDL.shape, new point(10, 10), "RightToLeft", b);
        //public static ObjectOfGame g1 = new ObjectOfGame(ObjectOfGameDL.shape, new point(10, 10), "Diagonals"  , b);
        public static ObjectOfGame g1 = new ObjectOfGame(ObjectOfGameDL.shape, new point(10, 10), "Random"     , b);
        //public static ObjectOfGame g1 = new ObjectOfGame(ObjectOfGameDL.shape, new point(10, 10), "Projectile" , b);
    }
}
