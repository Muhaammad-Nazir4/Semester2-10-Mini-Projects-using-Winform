using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ums.BL
{
    class subject
    {
        //constructors...................
        public subject(string code, int creditHours, string subjectType,int subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
       
        //data members...................
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;
        
        //member functions...............
    }
}
