using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ums.BL
{
    class student
    {
        //constructors...................
        public student(string name , int age , float Fsc_marks, float Ecat_marks , List<Degree_Program> preference)
        {
            this.name = name;
            this.age = age;
            this.Fsc_marks = Fsc_marks;
            this.Ecat_marks = Ecat_marks;
            this.preference = preference;
            registered_subjects = new List<subject>();
            
        }
     

        //data members...................
        public string name;
        public int age;
        public float Fsc_marks;
        public float Ecat_marks;
        public List<Degree_Program> preference; 
        public List<subject> registered_subjects;
        public Degree_Program registered_degree;
            public double merit;
        //member functions...............
        public double calculateMerit()
        {
            merit = ((Ecat_marks * 0.4F) + (Fsc_marks * 0.6F))*100;
            return merit;
        }
        public bool reg_subjects(subject s)
        {
            int creditHours = getCreditHours();
            if( registered_degree !=null && registered_degree.subjectExists(s) && creditHours + s.creditHours <= 9)
            {
                registered_subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (subject s in registered_subjects)
            {
                count = count + s.creditHours;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if(registered_degree != null)
            {
                foreach(subject su in registered_subjects)
                {
                    fee = fee + su.subjectFee;
                }
            }
            return fee;
        }
       

        
    }
}
