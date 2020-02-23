using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsandTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
             
            object obj = n;
            n = 10;
            Console.WriteLine("Value - : {0}", n);
            Console.WriteLine("Object- :{0}", obj);
            int n1= 30;
            object obj1 = n1;
            int i = (int)obj1;
            Console.WriteLine("Value  : " + obj1);
            Console.WriteLine("Value  : " + i);

            Console.ReadLine();
        }
    }
}
