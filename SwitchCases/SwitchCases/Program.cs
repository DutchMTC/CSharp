using System;

namespace SwitchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer (0-9):");
            string input = Console.ReadLine();
            try
            {
                int myInt = Int32.Parse(input);
                switch (myInt)
                {
                    case 0: 
                        Console.WriteLine("Case is 0");
                        break;
                    case 1:
                        Console.WriteLine("Case is 1");
                        break;
                    case 2:
                        Console.WriteLine("Case is 2");
                        break;
                    case 3:
                        Console.WriteLine("Case is 3");
                        break;
                    case 4:
                        Console.WriteLine("Case is 4");
                        break;
                    case 5:
                        Console.WriteLine("Case is 5");
                        break;
                    case 6:
                        Console.WriteLine("Case is 6");
                        break;
                    case 7:
                        Console.WriteLine("Case is 7");
                        break;
                    case 8:
                        Console.WriteLine("Case is 8");
                        break;
                    case 9:
                        Console.WriteLine("Case is 9");
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 0 and 9!");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter an integer!");
            }
        }
    }
}
