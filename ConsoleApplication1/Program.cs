using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*var Ola = new Friend();
            Ola.Greeting = "Ola, ";
            Console.Write(Ola.DisplayGreeting());*/


            var Human = new Human();
            Human.Greeting = "Hello, ";
            Human.Name = "My name is Bro and ";
            Console.WriteLine(Human.DisplayGreeting());
            Console.Write(Human.DisplayName());
            Human.Eat("Riblet!");
            Console.WriteLine();
            

            var Panda = new Panda();
            Panda.Greeting = "Yo yo, ";
            Panda.Name = "My name is Poo Bear and ";
            Console.WriteLine(Panda.DisplayGreeting());
            Console.Write(Panda.DisplayName());
            Panda.Eat("Banana!");
            Console.WriteLine();
            


            var Robot = new Robot(); // Robot isnt acting right
            Robot.Greeting = "Hello earthlings, ";
            Robot.Name = "My name is Vinnie and ";
            Console.WriteLine(Robot.DisplayGreeting());
            Console.Write(Robot.DisplayName());
            Robot.IsTerminator(); // Vinnie is a terminator
            Console.WriteLine();
            Robot.Startup(); // and he is awake
            Console.WriteLine();
            Robot.ShutDown(); // Now he is shutting down

            Console.ReadLine();





        }
        

    }
}
