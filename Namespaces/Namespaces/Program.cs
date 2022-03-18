using System;
using Namespace2;
using Address;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string name = person.name;
            int age = person.age;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + person.address2.address);
        }
    }
}
