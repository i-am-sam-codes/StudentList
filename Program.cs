using System;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks for number of students recieved as string and converted to integer 
            Console.WriteLine("How many students are in your class? ");
            int studentSize = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[studentSize];

            Console.WriteLine("Please input the names of the students: ");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere are your students: ");
            Console.WriteLine("Processing...");
            Console.WriteLine("-----------------");
            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                studentSize = i + 1;
                Console.WriteLine( studentSize + "." + names[i]);
            }

            Console.ReadKey();
        }
    }
}
