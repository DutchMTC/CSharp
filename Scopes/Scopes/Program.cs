using System;
using System.Threading;

namespace Scopes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loop();
        }

        public static void Loop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i == 69)
                {
                    Console.WriteLine("Nice!");
                }
                Thread.Sleep(100);
            }
        }
    }
}
