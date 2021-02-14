using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCounts = int.Parse(Console.ReadLine());
            int flowersCount = int.Parse(Console.ReadLine());
            double honey = beesCounts * flowersCount * 0.21;
            double honeyCombs = Math.Floor(honey / 100);
            Console.WriteLine($"{honeyCombs} honeycombs filled.");
            double diff = honey - (honeyCombs * 100);
            Console.WriteLine($"{diff:F2} grams of honey left.");
        }
    }
}
