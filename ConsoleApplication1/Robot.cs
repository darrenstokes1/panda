using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    public class Robot : Friend
    {
        public bool IsAsleep = false;
        private bool isTerminator = false;
        public bool IsAwake = false;

        
        
        public void IsTerminator()
        {
            Console.Write("I'm a Terminator! ");
            Console.WriteLine();
            isTerminator = true;
        }
            
        public void ShutDown()
        {
            Console.Write("Oops you hit my OFF Button ");
            Console.Write("and now I am Shutting down now...Goodbye!");
            Console.WriteLine();
            IsAsleep = true;
        }
       public void Startup()
        {
            Console.Write("Wow! You hit my ON button ");
            Console.Write("and I am awake !!");
            Console.WriteLine();
        }
            

        
    }
}
