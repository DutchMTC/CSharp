using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    internal class Animal
    {
        protected int hunger = 100;
        public void Feed()
        {
            hunger--;
            Console.WriteLine("You automatically fed the horse! The horse's hunger is now at " + hunger);
        }
        
    }
}
