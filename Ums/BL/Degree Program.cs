using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ums.BL
{
    class Degree_Program
    {
        //constructors...................
        public Degree_Program(string degree_title, int degree_duration, int seats)
        {
            this.degree_title = degree_title;
            this.degree_duration = degree_duration;
            this.seats = seats;
            subject_data = new List<subject>();
        }
        
        //data members...................
        public string degree_title;
        public int degree_duration;
        public int seats;
        public List<subject> subject_data= new List<subject>();
        //member functions...............
        public int caculating_CreditHours()
        {
            int count = 0;
            for(int i=0; i< subject_data.Count; i++)
            {
                count = count + subject_data[i].creditHours;
            }
            return count;
        }
        public bool Add_Subject(subject s)
        {
            int creditHours;
            creditHours = caculating_CreditHours();
            if(creditHours + s.creditHours <= 20)
            {
                subject_data.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
         public bool subjectExists(subject s)
        {
            
            foreach (subject su in subject_data)
            {
                if (su.code == s.code)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
