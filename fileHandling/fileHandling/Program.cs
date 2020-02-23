using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHandling
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
               
              

                int choice;
                while (true)
                {
                    Console.WriteLine("\n1.create new File");
                    Console.WriteLine("2.open existing File");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            fio.WriteFile();
                            Console.ReadKey();
                            break;
                        case 2:
                            fio.ReadFile();
                            Console.ReadKey();
                            break;
                        default:
                            return;

                    }
                }
        }
   

        void WriteFile()
        {
            Console.Write("\nEnter File Name :");
            String filename = Console.ReadLine();
            BinaryWriter bw = new BinaryWriter(File.Create(filename));
            String filecontent = "";
            String ch;
            Console.WriteLine("Enter content of file (-1 in end of file)");
            ch = Console.ReadLine();
            while (!ch.Equals("-1"))
            {
                filecontent = filecontent + ch;
                ch = Console.ReadLine();
            }
            bw.Write(filecontent);
            bw.Close();
        }
        void ReadFile()
        {
            try
            {
                Console.Write("\nEnter File Name :");
                String filename = Console.ReadLine();
                String filecontent = File.ReadAllText(filename);
                Console.Write(filecontent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex.GetBaseException());
            }
        }

    }
}
    

