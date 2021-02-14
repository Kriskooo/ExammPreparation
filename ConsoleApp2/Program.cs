using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int bearsHealth = int.Parse(Console.ReadLine());
            int bearsAttack = int.Parse(Console.ReadLine());
            int beesCountAfterBearAttack = 0;
            while (beesCount >= 100)
            {
                beesCountAfterBearAttack = beesCount - bearsAttack;
                beesCount = beesCountAfterBearAttack;
                if (beesCount < 0)
                {
                    beesCount = 0;
                    beesCountAfterBearAttack = 0;
                    break;
                }
                bearsHealth = bearsHealth - (beesCountAfterBearAttack * 5);
                if (bearsHealth <= 0)
                {
                    Console.WriteLine($"Beehive won! Bees left {beesCountAfterBearAttack}.");
                    return;
                }
            }
            Console.WriteLine($"The bear stole the honey! Bees left {beesCountAfterBearAttack}.");
        }
    }
}
