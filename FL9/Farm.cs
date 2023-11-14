using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    class Farm 
    {

        // Låt våra djur flytta in 

        //  Vår klass pekar på två andra klasser

        // Båda dessa svarar HAR på frågan
        // Alltså en komposition eller en pekare, association
        public Chicken Chicken { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

        // Om vi vill ha flera sorters djur
        // då måste vi bygga vår klass Farm
        // grisar??
        // Vi måste introducera begreppet ARV

        public Farm(int numberOfCows) 
        {
            Cow cow; // = new Cow();
            for (int i = 0; i < numberOfCows; i++)
            {
                string name = $"Ko nr: {i + 1}";
                cow = new Cow(name); // här gör vi en NY ko
                if (i % 4 == 0)
                {
                    cow.NumberOfLegs = 3;
                }
                Animals.Add(cow);
            }
        }

        public int CountTotalLegs()
        {
            int total = 0;
            foreach (Animal animal in Animals)
            {
                total += animal.NumberOfLegs;
            }

            return total;
        }

    }
}
