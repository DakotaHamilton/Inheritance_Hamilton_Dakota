using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Hamilton_Dakota
{
    /// <summary>
    /// Gets and Sets the Title and ESRB
    /// </summary>
   abstract class Game
    {

        public string ESRB { get; set; }

        public string Title { get; set; }

        public Game(string ESRBParam, string TitleParam)
        {
            ESRB = ESRBParam;
            Title = TitleParam;
        }

        /// <summary>
        /// Prints the Title that the game is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();

    }
}
