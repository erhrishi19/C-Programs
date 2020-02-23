using System;
using System.Collections;


namespace CollectionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" !!  Welcome  !! ");
            Console.WriteLine("Your Choices");
            Console.WriteLine("1)  Student");
            Console.WriteLine("2)  Staff");
            Console.WriteLine("Enter Your Choice");
            string a = Console.ReadLine();
            int c = Convert.ToInt32(a);
            switch (c)
            {
                case 1:
                    Student s = new Student();
                    s.Updation("Hrishikesh Salunkhe ");
                    s.Updation("Rohan Salunkhe");
                    s.Updation("ABC");
                    s.Updation("DEF");
                    s.Updation("GHI");
                    s.Updation("KLM");
                    s.Delete();
                    s.display();
                    break;
                case 2:
                    Staff st = new Staff();
                    st.Updation("Dr. XYZ");
                    st.Updation("Prof. ABC");
                    st.Updation("Prof. DEF");
                    st.Updation("Prof. GHI");
                    st.Updation("Prof. JKL");
                    st.Updation("Prof. MNO");
                    st.Updation("Prof. PQR");
                    st.Delete();
                    st.display();
                    break;
                default:
                    Console.WriteLine("Wrong Choice is Entered.");
                    break;
            }

            Console.WriteLine("Sorted List Class Example:");
            SortedListClass slc = new SortedListClass();
            slc.dis();


            Console.ReadLine();
        }

    }
    class Student : Program
    {
        public Student()
        {
            Console.WriteLine("You are in Student Class");

        }
        ArrayList a = new ArrayList();
        public void Updation(string str)
        {
            a.Add(str);
        }
        public void Delete()
        {
            a.Remove("Rohan Salunkhe");
        }
        public void display()
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(a.Count);
        }
    }
    class Staff : Program
    {
        public Staff()
        {
            Console.WriteLine("You are in Staff Class");
        }
        ArrayList ar = new ArrayList();
        public void Updation(string str)
        {
            ar.Add(str);

        }
        public void Delete()
        {
            ar.Remove("Prof. ABC");

        }
        public void display()
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ar.Count);

        }

    }
}





