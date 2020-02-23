using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!! Wel-Come !!");
            Second s = new Second();
            s.Fun(1,"RIT",67.00f, "No");
           
            Console.ReadLine();
        }
    }
    class Second
    {
        int Number;
        string Clg_Name,Selection;
        float Percentage;
        public Second()
        {
            Console.WriteLine("You are in Second Class");
        }
        public void Fun(int n, string str, float p, string sele)
        {
            Number = n;
            Clg_Name = str;
            Percentage = p;
            Selection = sele;
            Console.WriteLine("Student Number   :"+Number);
            Console.WriteLine("College Name     :"+Clg_Name);
            Console.WriteLine("Percentage       :"+Percentage);
            Console.WriteLine("Selection Answer :"+Selection);

        }
        public void Fun(int n, string str,   float p)
        {
            Number = n;
            Clg_Name = str;
            Percentage = p;
            Selection = "No";

            Console.WriteLine("Student Number   :" + Number);
            Console.WriteLine("College Name     :" + Clg_Name);
            Console.WriteLine("Percentage       :" + Percentage);
            Console.WriteLine("Selection Answer :" + Selection);

        }
        public void Fun(int n, string str)
        {
            Number = n;
            Clg_Name = str;
            float p = 75.00f;
            string sele = "yes";
            Console.WriteLine("Student Number   :" + Number);
            Console.WriteLine("College Name     :" + Clg_Name);
            Console.WriteLine("Percentage       :" + p);
            Console.WriteLine("Selection Answer :" + sele);

        }

        public void Fun(int n)
        {
            Number = n;
            string str = "RIT";
            float p = 55.05f;
            string sele = "Yes";
            Console.WriteLine("Student Number   :" + Number);
            Console.WriteLine("College Name     :" + str);
            Console.WriteLine("Percentage       :" + p);
            Console.WriteLine("Selection Answer :" + sele);

        }
    }
}
