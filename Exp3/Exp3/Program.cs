using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Exp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Experimen Number :   3");
          
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(20);
            a.Add(30);
            Console.WriteLine(a.Count);
            Console.WriteLine(a.Contains(10));
          
           
            Console.ReadLine();
        }



        
    }
     
}