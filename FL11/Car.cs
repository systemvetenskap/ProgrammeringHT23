using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL11
{
    /// <summary>
    /// Ritning för alla våra objekt av typen bil
    /// </summary>
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string ChassisNumber { get; }
        public string LicenceNumber { get; set; }

        private int _tank = 0;
        private int _tankVolume = 60;

        // konstruktor
        // en slags metod som körs endast 
        // när vi skapar objektet
        // vid födsel
        public Car()
        {
               ChassisNumber = DateTime.Now.ToString();
        }

        public void FillTank(int litres)
        {
            _tank = litres;
        }
    }
}
