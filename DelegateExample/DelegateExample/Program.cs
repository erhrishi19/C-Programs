using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void Mydelegate();
    class Program
    {
        public static event Mydelegate add;

        static void Main(string[] args)
        {
            add += new Mydelegate(addition);
            add += new Mydelegate(mul);
            add += new Mydelegate(sub);
            add.Invoke();

            Console.ReadKey();
        }
       static void addition()
        {
            Console.WriteLine(" addition :" + (20 + 10));
        }

        static void mul()
        {
            Console.WriteLine(" subtraction :" + (20 * 10));
        }

        static void sub()
        {
            Console.WriteLine(" subtraction :" + (20 - 10));
        }
    }
}
