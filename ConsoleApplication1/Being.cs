using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    public class Being : Friend
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I just ate a delicious {food}");
        }

        public Being()
        {
            
        }
    }
}
