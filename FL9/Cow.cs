using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    /// <summary>
    /// En klass för våra kor
    /// </summary>
    class Cow : Animal
    {
       // ARV svarar på frågan ÄR

        public Cow()
        {
            NumberOfLegs = 4;

        }
        public Cow(string name)
        {
            Name = name;
            NumberOfLegs = 4;
        }
    }
}
