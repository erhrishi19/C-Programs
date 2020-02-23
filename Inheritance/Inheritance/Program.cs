  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dept
    {
        static void Main(string[] args)
             
        {
            string ch;
            Console.WriteLine("Exp on Inheritance:");
            
            Console.WriteLine("1) Student");
            Console.WriteLine("2) Staff");
            Console.WriteLine("Enter your choice");
               ch = Console.ReadLine();
            int it = Convert.ToInt32(ch);
            switch (it)
            {
                case 1:
                    Console.WriteLine("Case 1:");
                    Student a = new Student();
                    a.Info("Animesh", 3035, 96);
                   
                    a.Display();
                    break;
                case 2:
                    Console.WriteLine("Case 2 :");
                    Staff s = new Staff();
                    s.Info("Animesh", 3035, "PhD", "C# .NET ","Computer Engineering");
                    s.Display();
                    break;
                default:
                    Console.WriteLine("Please enter right choice");
                    break;
            }

            Console.ReadLine();
        }
    }
   class Student: Dept
    {
        public Student()
        {
            Console.WriteLine("You Are in Student Class");

        }
       
        string name,sport,deptmt;
        int roll ,marks;
            public void Info(string n, int r, int m, string s="none", string dept ="Computer Engineering")
        {
            
            name = n;
            roll = r;
            marks = m;
            sport = s;
            deptmt = dept;
        }
        public void Display()
        {

            Console.WriteLine("Student Name        : " + name);
            Console.WriteLine("Student Roll_Number : " + roll);
            Console.WriteLine("Student Marks       : " + marks);
            Console.WriteLine("Student Sport_Game  : " + sport);
            Console.WriteLine("Student Department  : " + deptmt);

        }


    }
    class Staff:Dept
        
    {
        string name, Subject_Name, Qualification,deptmt;
        int ID;
        public Staff()
        {
            Console.WriteLine("You are in Staff Class ");
        }
        public void Info(string n, int r, string  m, string sub,string dept)
        {
            name = n;
            ID = r;
            Qualification = m;
            Subject_Name = sub;
            deptmt = dept;
        }
        public void  Display()
        {
            Console.WriteLine("Staff Name          : " + name);
            Console.WriteLine("Staff ID            : " + ID);
            Console.WriteLine("Staff Qualification : " + Qualification);
            Console.WriteLine("Staff Subject Name  : " + Subject_Name);
            Console.WriteLine("Staff Department  : " + deptmt);

        }


    }
}
