using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int intelect = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (intelect >= 80 && strength >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (intelect >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (intelect >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (strength >= 80 && gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (strength >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
