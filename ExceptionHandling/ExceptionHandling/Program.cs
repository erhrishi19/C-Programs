using System;

namespace ExceptionHandelling
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Voter vt = new Voter();
                Console.Write("Enter age :");
                int age = Convert.ToInt32(Console.ReadLine());
                vt.SetAge(age);
                Console.Write("Enter name :");
                String name = Console.ReadLine();
                vt.SetName(name);
                vt.ShowDetails();
                Console.ReadKey();
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }

    class Voter
    {
        int age;
        String name;
        public void SetAge(int age)
        {
            this.age = age;
            if (age < 18)
            {
                throw new InvalidAgeException("Age invalid");
            }
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n Name : " + name);
            Console.WriteLine("\n age : " + age);
        }

    }
}
