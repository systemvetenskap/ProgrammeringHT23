using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL7
{
    /// <summary>
    /// Mall för våra pirater
    /// </summary>
    class Pirate
    {
        // Vi skapar egenskaper som ska gälla ALLA våra pirater
        // Egenskap = property
        // vi har skapat variabler
        // och till viss del konstanter, som är en variabel som inte kan ändra
        // värden.

        // Alla properties kan ha getters och setters
        public string Name { get; set; }
        // I exemplet ovan kan vi både ge vår pirat ett namn = Set
        // och vi kan fråga vad vår pirat heter = Get
        public string Rank { get; private set; }
        public int Level { get; set; }

        // Låt oss introducera begreppet konstruktor
        // en konstruktor är (typ) en metod som körs
        // en och endast en gång = när objektet skapas
        public int EmploymentYear { get; } = 1234;
        private int _currentYear = 1735;
        public Pirate()
        {
            // Lägg till vår konstruktor om den behövs
            CalculateRank();
            SetRankFromLevel();
        }

        public Pirate(string name, int employmentYear)
        {
            Name = name;
            // När vi tilldelar värden till properties
            // via vår konstruktor. Då kan vi ha
            // en property utan setter, men som ändå fungerar.
            EmploymentYear = employmentYear;
            CalculateRank();
        }

        // JAg vet.. Vi bygger en metod som räknar ut min Rank
        private void CalculateRank()
        {
            int yearsOfEmployment = _currentYear - EmploymentYear;
            if(yearsOfEmployment ==7)
            {
                Rank = "Sailing master";

            }
            else if (yearsOfEmployment > 7)
            {
                Rank = "Captain";
            }
            else if (yearsOfEmployment > 10)
            {
                Rank = "No ranking";
            }
        }

        public void SetRankFromLevel()
        {
            // är han galen?
            // detta problem är som gjort för en case
            switch (Level)
            {
                case 1:
                    Rank = "Deckhand";
                    break;
                case 2:
                    Rank = "Boatswain";
                    break;
                case 3:
                    Rank = "Powder monkey";
                    break;
                case 4:
                    Rank = "Sailing master";
                    break;
                case 5:
                    Rank = "Captain";
                    break;
                default:
                    Rank = "No rank";
                    break;
            }
        }

    }
}
