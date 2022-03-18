using System;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rng());
        }

        static int rng()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 21);
            return number;
        }

        
    }
}
