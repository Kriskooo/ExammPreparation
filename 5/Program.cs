using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string typeOfFlower = Console.ReadLine();
                int numberOfFlowers = int.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                double sunflower = 0;
                double daisy = 0;
                double lavender = 0;
                double mint = 0;
                double total = 0;
                if (season == "Spring")
                {
                    if (typeOfFlower == "Sunflower")
                    {
                        sunflower = 10 * numberOfFlowers;
                        total += sunflower;
                    }
                    else if (typeOfFlower == "Daisy")
                    {
                        daisy = 12 * numberOfFlowers;
                        daisy *= 1.10;
                        total += daisy;
                    }
                    else if (typeOfFlower == "Lavender")
                    {
                        lavender = 12 * numberOfFlowers;
                        total += lavender;
                    }
                    else if (typeOfFlower == "Mint")
                    {
                        mint = 10 * numberOfFlowers;
                        mint *= 1.10;
                        total += mint;
                    }
                }
                else if (season == "Summer")
                {
                    if (typeOfFlower == "Sunflower")
                    {
                        sunflower = 8 * numberOfFlowers;
                        sunflower *= 1.10;
                        total += sunflower;
                    }
                    else if (typeOfFlower == "Daisy")
                    {
                        daisy = 8 * numberOfFlowers;
                        daisy *= 1.10;
                        total += daisy;
                    }
                    else if (typeOfFlower == "Lavender")
                    {
                        lavender = 8 * numberOfFlowers;
                        lavender *= 1.10;
                        total += lavender;
                    }
                    else if (typeOfFlower == "Mint")
                    {
                        mint = 12 * numberOfFlowers;
                        mint *= 1.10;
                        total += mint;
                    }
                }
                else if (season == "Autumn")
                {
                    if (typeOfFlower == "Sunflower")
                    {
                        sunflower = 12 * numberOfFlowers;
                        sunflower = sunflower - (sunflower * 0.05);
                        total += sunflower;
                    }
                    else if (typeOfFlower == "Daisy")
                    {
                        daisy = 6 * numberOfFlowers;
                        daisy = daisy - (daisy * 0.05);
                        total += daisy;
                    }
                    else if (typeOfFlower == "Lavender")
                    {
                        lavender = 6 * numberOfFlowers;
                        lavender = lavender - (lavender * 0.05);
                        total += lavender;
                    }
                    else if (typeOfFlower == "Mint")
                    {
                        mint = 6 * numberOfFlowers;
                        mint = mint - (mint * 0.05);
                        total += mint;
                    }
                }
                Console.WriteLine($"Total honey harvested: {total:f2}");
            }
        }
    }
}
