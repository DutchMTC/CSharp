using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine rekenmachine = new Rekenmachine();

            int add = rekenmachine.add(5, 2);
            Console.WriteLine(add);

            int divide = rekenmachine.divide(50, 25);
            Console.WriteLine(divide);

            int multiply = rekenmachine.multiply(5, 10);
            Console.WriteLine(multiply);
        }
    }
}
