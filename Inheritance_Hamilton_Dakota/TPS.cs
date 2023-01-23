using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Hamilton_Dakota
{
    class TPS : Game
    {
        /// <summary>
        /// Assigns the Title and ESRB a Parameter
        /// </summary>
        /// <param name="ESRBParam">(Assigns the ESRB a Parameter)</param>
        /// <param name="TitleParam">(Assigns the Title a Parameter)</param>
        public TPS(string ESRBParam, string TitleParam) : base(ESRBParam, TitleParam)
        {
            Title = TitleParam;
            ESRB = ESRBParam;
        }

        /// <summary>
        /// Describes the Game
        /// </summary>
        /// <returns>(Returns the set Title and ESRB)</returns>
        public override string Describe()
        {
            return $"{Title} is a tps game rated {ESRB}!";
        }
    }
}
