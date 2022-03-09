using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Player tommy = new Player();     // create object of class Player
            Console.WriteLine(tommy.name);        //print parameter by Console.Writeline(object.parameter);
            //Console.WriteLine(tommy.health);

            //tommy.setHealth(100);                   // call method by [ object.methodName ]
            //Console.WriteLine(tommy.health);            // print the health
            
            
            Console.WriteLine(tommy.getHealth());
            tommy.setHealth(100);
            Console.WriteLine(tommy.getHealth());
            Console.ReadLine();
        }
    }
}
