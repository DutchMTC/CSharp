using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string Str, reversestring = "";
        int Length;
        Console.Write("Enter A String: ");
        Str = Console.ReadLine();
        Length = Str.Length - 1;
        while (Length >= 0)
        {
            reversestring = reversestring + Str[Length];
            Length--;
        }
        Console.WriteLine(reversestring);
        Console.ReadLine();
    }
}
