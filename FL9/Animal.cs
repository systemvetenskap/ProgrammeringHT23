using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    /// <summary>
    /// Den här klassen ska representera ett godtyckligt djur på vår bondgård
    /// katt, hund, gris, kyckling
    /// </summary>
    class Animal
    {
        // Vi kan då låta alla våra specifika djursorter
        // ärva från Animal
        // Animal blir då vår förälder = basklass
        // Djuren blir barn, eller subklass
        // Här lägger vi alla metoder och klasser som är gemensamma
        public int NumberOfLegs { get; set; } = 4;
        public string? Name { get; set; }
    }
}
