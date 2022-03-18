using System;

namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.FetchBall(new Ball());
            Ball ball = dog.GiveBall();
        }
    }
}
