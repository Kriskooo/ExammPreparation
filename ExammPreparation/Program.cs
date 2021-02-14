using System;

namespace ExammPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeeded = double.Parse(Console.ReadLine());
            string beeName = Console.ReadLine();
            string honeyIncome = Console.ReadLine();
            double honeyIntIncome = 0;
            double honeyIncomePositive = 0;
            double honeyIncomeNegative = 0;
            int counter = 1;
            double counterLast = 0;
            while (honeyIncome != "Winter has come")
            {
                honeyIntIncome = double.Parse(honeyIncome);
                if (honeyIntIncome >= 0)
                {
                    honeyIncomePositive += honeyIntIncome;
                }
                else
                {
                    honeyIncomeNegative += honeyIntIncome;
                }
                if (counter == 6 && honeyIncomeNegative < honeyIncomePositive)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                    counterLast = Math.Abs(honeyIncomeNegative) - honeyIncomePositive;
                    beeName = Console.ReadLine();
                    honeyIncomePositive = 0;
                    honeyIncomeNegative = 0;
                    counter = 0;
                }
                honeyIncome = Console.ReadLine();
                counter++;
            }
            honeyIncomePositive = honeyIncomePositive - (Math.Abs(honeyIncomeNegative)) - counterLast;
            if (honeyIncomePositive > honeyNeeded)
            {
                double diff = honeyIncomePositive - honeyNeeded;
                Console.WriteLine($"Well done! Honey surplus {diff:f2}.");
            }
            else
            {
                double diff = honeyNeeded - honeyIncomePositive;
                Console.WriteLine($"Hard Winter! Honey needed {diff:f2}.");
            }
        }
    }
}
