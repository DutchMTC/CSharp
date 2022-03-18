using System;

namespace Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            Console.WriteLine("Do you want to manually feed the horse? (YES/NO)");
            string input = Console.ReadLine();
            string upperInput = input.ToUpper();
            switch (upperInput)
            {
                case "YES":
                    Console.WriteLine("How much do you want to feed the horse? (0-100)");
                    int amount = Int32.Parse(Console.ReadLine());
                    if(amount <= 100)
                    {
                        horse.Feed(amount);
                    }
                    else if(amount >= 100)
                    {
                        Console.WriteLine("The horse isn't that hungry!");
                    }
                    break;
                case "NO":
                    horse.Feed();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
    }
}
