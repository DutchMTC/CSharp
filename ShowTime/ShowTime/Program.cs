using System;
using System.Threading;

namespace ShowTime
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int color = 0;
            int counter = 0;

            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();

                counter++;

                if(counter == 10)
                {
                    color++;

                    if (color == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (color == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (color == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if (color == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (color == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (color == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (color == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else if (color == 7)
                    {
                        color = 0;
                    }

                    counter = 0;
                }
            }
        }


    }
}
