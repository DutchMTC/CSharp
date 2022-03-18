using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int result in array)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine(result);
                }

            }
        }
    }
}
