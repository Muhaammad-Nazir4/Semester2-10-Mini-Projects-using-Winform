using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ums.BL;

namespace Ums
{
    class Program
    {
        
        static string menu()
        {
            Console.WriteLine("1. Add student................");
            Console.WriteLine("2. Add Degree Program..........");
            Console.WriteLine("3. Generate Merit..............");
            Console.WriteLine("4. View Registered students.....");
            Console.WriteLine("5. View students of a specific Program.......");
            Console.WriteLine("6. Regestered subjects for a specific students.....");
            Console.WriteLine("7. calculate fees for all registered subjects.......");
            Console.WriteLine("8. Exit.....");
            Console.WriteLine("Press any key to continue.......");
            string option = Console.ReadLine();
            return option;
        }
        static student AddStudent(List<Degree_Program> degree)
        {
            List<Degree_Program> preference = new List<Degree_Program>();
            Console.WriteLine("Enter Student name..........");
            string name = Console.ReadLine();
             Console.WriteLine("Enter student age.............");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc marks..........");
            float Fsc_marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat marks..........");
            float Ecat_marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            viewPrograms(degree);
            Console.WriteLine("Enter how many preference to enter..........");
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i < count; i++)
            {
                String degree_title = Console.ReadLine();
                bool flag = false;
                foreach(Degree_Program d in degree)
                {
                    if(degree_title == d.degree_title && !(preference.Contains(d)))
                    {
                        preference.Add(d);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid degree program name");
                    i--;
                }
            }
            student s = new student(name, age, Fsc_marks, Ecat_marks , preference);
            return s;
        }
        static student studentPresent(string name , List<student> stu)
        {
            foreach(student s in stu)
            {
                if(name == s.name && s.registered_degree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void calculatefeeForAll(List<student> stu)
        {
            foreach(student s in stu)
            {
                if(s.registered_degree != null)
                {
                    Console.WriteLine(s.name + " has" + s.calculateFee() + "fees");
                }
            }
        }
        static void registeredsubjects(student s)
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i< count; i++)
            {
                Console.WriteLine("Enter the subject code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(subject sub in s.registered_degree.subject_data)
                {
                    if(code == sub.code && !(s.registered_subjects.Contains(sub)))
                    {
                        s.reg_subjects(sub);
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    i--;
                }
            }
        }
        static List<student> sortStudentsByMerit(List<student> stu)
        {
            List<student> sortedStudentList = new List<student>();
            foreach(student s in stu)
            {
                s.calculateMerit();
            }
            sortedStudentList = stu.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<student> sortedStudentList)
        {
            foreach(student s in sortedStudentList)
            {
                foreach(Degree_Program d in s.preference)
                {
                    if(d.seats > 0 && s.registered_degree == null)
                    {
                        s.registered_degree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        static void printStudents(List<student> stu)
        {
            foreach (student s in stu)
            {
                if (s.registered_degree != null)
                {
                    Console.WriteLine(s.name + "got admisssion in " + s.registered_degree.degree_title);
                }
                else
                {
                    Console.WriteLine(s.name + "did not got admisssion in ");
                }
                }
            }
        static void viewstudentInDegree(string degree_title , List<student> stu)
        {
            Console.WriteLine("Name" + "\t" + "FSC" + "\t" + "ECAT" + "\t" + "Age" + "\t");
            foreach(student s in stu)
            {
                if (s.registered_degree != null)
                {
                    if(degree_title == s.registered_degree.degree_title)
                    {
                        Console.WriteLine(s.name + "\t" + s.Fsc_marks + "\t" + s.Ecat_marks + "\t" + s.age + "\t");
                    }
                }
            }
        }
        static void viewRegisteredStudents(List<student> stu)
        {
            Console.WriteLine("Name" + "\t" + "FSC" + "\t" + "ECAT" + "\t" + "Age" + "\t");
            foreach (student s in stu)
            {
                if (s.registered_degree != null)
                {                  
                        Console.WriteLine(s.name + "\t" + s.Fsc_marks + "\t" + s.Ecat_marks + "\t" + s.age + "\t");                   
                }
            }
        }
        static void clearscreen()
        {
            Console.WriteLine("Press any key to continue.................");
            Console.ReadLine();
        }

        static Degree_Program AdddegreeData()
        {

            Console.WriteLine("Enter Degree name..........");
            string degree_title = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration.............");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for degree..........");
            int seats = int.Parse(Console.ReadLine());

            Degree_Program degree_data = new Degree_Program(degree_title,duration,seats);
             
            Console.WriteLine("Enter how many subjects to enter..........");
            int sub = int.Parse(Console.ReadLine());
            for (int i=1; i<sub; i++)
            {
                
                degree_data.Add_Subject(AddSubject());
            }
            return degree_data;

        }
        static subject AddSubject()
        {
            Console.WriteLine("Enter subject code..........");
            string code = Console.ReadLine();
            Console.WriteLine("Enter subject type..........");
            string subjectType = Console.ReadLine();
            Console.WriteLine("Enter subject creditHours ..........");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject subjectFee..........");
            int subjectFee = int.Parse(Console.ReadLine());
            subject temp = new subject(code, creditHours, subjectType, subjectFee);
            return temp;
        }
        static void AddSubjectIntoList(Degree_Program d, List<Degree_Program> degree)
        {
            degree.Add(d);
        }
        static void ADDStudentIntoList(student s , List<student> stu)
        {
            stu.Add(s);
        }
        static void viewPrograms(List<Degree_Program> degree)
        {
            foreach(Degree_Program d in degree)
            {
                Console.WriteLine(d.degree_title);
            }
        }
        static void header()
        {
            Console.WriteLine("...........................");
            Console.WriteLine("         UAMAS             ");
            Console.WriteLine("...........................");
        }

        static void viewSubjects(student s)
        {
            if (s.registered_degree != null)
            {
                Console.WriteLine("Subject Code" + "\t" + "Subject Type");
                foreach(subject su in s.registered_degree.subject_data)
                {
                    Console.WriteLine(su.code + "\t" + su.subjectType);
                }
            }
        }

        static void Main(string[] args)
        {
            List<student> stu = new List<student>();
            List<Degree_Program> degree = new List<Degree_Program>();

            string option = menu();
            while (true)
            {
                
                if (option == "1")
                {
                    Console.Clear();
                    if(degree.Count > 0)
                    {
                        student s = AddStudent(degree);
                        ADDStudentIntoList(s, stu);
                        clearscreen();
                        Console.Clear();
                        option = menu();
                    }
                                   
                }

                if (option == "2")
                {
                    Console.Clear();
                    Degree_Program d = AdddegreeData();
                    AddSubjectIntoList(d, degree);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                }

                if (option == "3")
                {
                    Console.Clear();
                    List<student> sortedStudentList = new List<student>();
                 sortedStudentList = sortStudentsByMerit(stu);
                    printStudents(stu);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                }

                if (option == "4")
                {
                    Console.Clear();
                    viewRegisteredStudents(stu);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                }

                if (option == "5")
                {
                    Console.Clear();
                    string degree_title;
                    Console.WriteLine("Enter Degree Name:");
                    degree_title = Console.ReadLine();
                    viewstudentInDegree(degree_title , stu);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                   
                }

                if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the student name:");
                    string name = Console.ReadLine();
                    student s = studentPresent(name, stu);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                }

                if (option == "7")
                {
                    Console.Clear();
                    calculatefeeForAll(stu);
                    clearscreen();
                    Console.Clear();
                    option = menu();
                }
                if (option == "8")
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
