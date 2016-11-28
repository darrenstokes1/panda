using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    public class Robot : Friend
    {

        public void IsTerminator()
        {
            if (true)
            {
                Console.WriteLine("I'm a Terminator");
            }
        
        }    
            
        public void ShutDown()
        {
            Console.WriteLine("Shutdown");
            IsAsleep = true;
        }
        public void StartUp()
        {
            Console.WriteLine("Awake");
            IsAsleep = false;
        } 
    }
}
