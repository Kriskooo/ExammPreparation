using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int beesBeforeFirstYear = 0;
            int beesAfter = 0;
            int beesBefAf = population;
            int migratingBef = 0;
            int migratingAf = 0;
            for (int i = 1; i <= years; i++)
            {
                beesBeforeFirstYear = (population / 10) * 2;
                if (i % 5 == 0)
                {
                    migratingBef = beesBeforeFirstYear + beesBefAf;
                    migratingAf = (migratingBef / 50) * 5;
                    migratingBef = migratingBef - migratingAf;
                    beesAfter = migratingBef;
                    beesAfter = beesAfter / 20;
                    beesAfter = beesAfter * 2;
                    migratingBef = migratingBef - beesAfter;
                    population = migratingBef;
                    beesBefAf = population;
                    continue;
                }
                beesAfter = (population + beesBeforeFirstYear) / 20;
                beesAfter = beesAfter * 2;
                beesBefAf = (beesBefAf + beesBeforeFirstYear) - beesAfter;
                population = beesBefAf;
            }
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
