using System;

namespace Inheritance_Hamilton_Dakota
{
    class Program
    {
        /// <summary>
        /// Prints Everything to the Console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TPS myTPS = new TPS("T", "Fortnite"); // TPS 1

            Console.WriteLine(myTPS.Describe()); // Describes the Game
            myTPS.PlayGame(); // Starts the Game

            TPS SRIV = new TPS("M", "Saints Row IV"); // TPS 2

            Console.WriteLine(SRIV.Describe()); // Describes the Game
            SRIV.PlayGame(); // Starts the Game

        }
    }
}
