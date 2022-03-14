using System;

namespace VariablesDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer1 = 1;
            float float1 = (float)integer1;
            Console.WriteLine(float1);

            int integer2 = 75;
            char char1 = (char)integer2;
            Console.WriteLine(char1);
            // Laat K zien want K heeft het decimaal 75 in unicode.
        }
    }
}
