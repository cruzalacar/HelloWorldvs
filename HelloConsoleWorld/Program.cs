using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their name
            Console.WriteLine("Hi, what is your name?");

            //read the user input
            string userName = Console.ReadLine();

            //Say hello to them
            Console.WriteLine("Hello {0}", userName);

            //Pause and wait for the user to exit to program
            Console.ReadKey();
        }
    }
}
