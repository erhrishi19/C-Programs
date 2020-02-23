using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2
{
    public class A
    {
        public static void fun()
        {
            Console.WriteLine("We are in Namespace");
        }
         
    }
}
 
namespace MyProgram
{
    public class MyClass
    {
        public static void Main()
        {
             Exp2.A.fun();
             Console.ReadLine();
                 
        }
       
    }
}
