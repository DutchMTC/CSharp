using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            foreach (char c in text)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(c);
                Thread.Sleep(1000);
            }
        }
    }
}
