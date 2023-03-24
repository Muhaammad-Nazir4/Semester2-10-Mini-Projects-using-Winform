using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameObject.BL;
using gameObject.DL;
using gameObject.UI;
using System.Threading;
namespace gameObject
{
    class Program
    {
       
        static void Main(string[] args) {
           
            while (true)
            {
                Thread.Sleep(100);
                Console.Clear();
                    //ObjectOfGameUI.eraseObject();
                    ObjectOfGameDL.g1.moveObject();
                    ObjectOfGameUI.drawObject();

            }

        }
               
    }
             
    }
   
