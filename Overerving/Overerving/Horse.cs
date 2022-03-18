using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    internal class Horse : Animal
    {
        public void Feed(int amount)
        {
            hunger = hunger - amount;
            Console.WriteLine("You fed the horse! The horse's hunger is now at " + hunger);
        }
    }
}
