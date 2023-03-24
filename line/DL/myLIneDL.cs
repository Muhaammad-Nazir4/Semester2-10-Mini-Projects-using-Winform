using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using line.UI;
using line.BL;
using System.IO;

namespace line.DL
{
    class myLIneDL
    {

        public static void storeData(myLine point)
        {
            string path1 = "E:\\assignment\\line\\bothPointdata.txt";
            StreamWriter file = new StreamWriter(path1, true);

            file.WriteLine(point.getBegin().getX() + "," + point.getBegin().getY() + "," + point.getEnd().getX() + "," + point.getEnd().getY());
            file.Flush();
            file.Close();
        }
       
        public static bool readData()
        {
            string path1 = "E:\\assignment\\line\\bothPointdata.txt";
            StreamReader file = new StreamReader(path1);
            string record;
            if (File.Exists(path1))
            {
                
                while ((record = file.ReadLine()) != null)
                {
               
                   string[] splittedRecord = record.Split(',');
                    int x1_point = int.Parse(splittedRecord[0]);
                    int y1_point = int.Parse(splittedRecord[1]);
                    int x2_point = int.Parse(splittedRecord[2]);
                    int y2_point = int.Parse(splittedRecord[3]);
                    //myLine.setBegin(x1_point, y1_point);
                    //myLine.setEnd(x2_point, y2_point);
                    

            }
            file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
