using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 20, 30, 40, 50, 60 };
            int[] input = A;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }

        }
    }
}
