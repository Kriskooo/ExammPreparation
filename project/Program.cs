using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < 13; i++)
            {
                string card = i switch
                {
                    0 => "2",
                    1 => "3",
                    2 => "4",
                    3 => "5",
                    4 => "6",
                    5 => "7",
                    6 => "8",
                    7 => "9",
                    8 => "10",
                    9 => "J",
                    10 => "Q",
                    11 => "K",
                    12 => "A",
                    _ => throw new NotImplementedException(),
                };
                for (int j = 0; j < 4; j++)
                {
                    string symbol = j switch
                    {
                        0 => "\u2660",
                        1 => "\u2663",
                        2 => "\u2665",
                        3 => "\u2666",
                        _ => throw new NotImplementedException()
                    };
                    Console.Write(j < 3 ? $"{card} {symbol}," : $"{card} {symbol}");
                }
                Console.WriteLine();
            }
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string input = Console.ReadLine();
            int index = Array.IndexOf(cards, input);
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine($"{cards[i]} \u2660, {cards[i]} \u2663, {cards[i]} \u2665, {cards[i]} \u2666");
            }
        }
    }
}

