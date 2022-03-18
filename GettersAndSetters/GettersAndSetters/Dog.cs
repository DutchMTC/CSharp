using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    internal class Dog
    {
        private Ball ball;

        public void FetchBall(Ball ball)
        {
            this.ball = ball;
            Console.WriteLine("Ball Fetched");
        }
        
        public Ball GiveBall()
        {
            return ball;
            Console.WriteLine("Ball Given");
        }
    }
}
