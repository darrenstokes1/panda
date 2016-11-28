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
            var Ola = new Friend();
            Ola.Greeting = "Ola!";
            Console.WriteLine(Ola.DisplayGreeting());
            Console.ReadLine();

            var Human = new Human();
            Human.Name = "My name is Bro and ";
            Human.Eat("Ribs");
            Console.WriteLine(Human.DisplayName());
            Console.ReadLine();

            var Panda = new Panda();
            Panda.Name = "My name is Poo Bear and ";
            Panda.Eat("Banana");
            Console.WriteLine(Panda.DisplayName());
            Console.ReadLine();


            var Robot = new Robot();
            Robot.Name = "My name is Vinnie";
            Console.WriteLine(Robot.DisplayName());
            Console.ReadLine();

            var Dave = new Friend();
            Dave.Name = "My name is Davie ";
            Console.WriteLine(Dave.DisplayName());
            Console.ReadLine(); 

           

            
        }

       
    }
}
