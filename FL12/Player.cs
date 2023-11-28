using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL12
{
    /// <summary>
    /// En fotbollsspelare
    /// </summary>
    internal class Player
    {
        protected int _power;
        // klassen är  vår mall som ska gälla alla olika typer av fotbollsspelare
        // oavsett kön, ålder eller nivå
        public string Name { get; }
        /// <summary>
        /// Spelarens tröjnummer
        /// </summary>
        public int Number { get; set; }

        public  string Gender { get; set; }

        public Player()
        {
            
        }
        public Player( string name)
        {
            _power = 100;
            Name = name;
            Gender = "female";
        }

        public Player(string name, int number)
        {
            Name = name;
            Number = number;
            Gender = "female";

        }
    }
}
