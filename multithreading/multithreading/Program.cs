using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,b=8 ;
            try
            {
                int c = b/i;
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Inthe  finally block");

            }
            Console.ReadLine();
        }
           
    }

}
