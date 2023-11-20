using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL7
{
    class Tortuga
    {
        // Den här är private
        // Du kan alltså inte hämta piraterna från gränssnittet
        private List<Pirate> _pirates = new List<Pirate>
        {
            new Pirate {Name="Mae Whiskey-Woo", Level=2},
            new Pirate {Name="Polly d’Plank", Level=1},
            new Pirate {Name="Toothless Pete", Level=1},
            new Pirate {Name="Ruth O’Patches", Level=1},
            new Pirate {Name="Vicky FishMonger", Level=2},
            new Pirate {Name="Mabel Hook-Hand", Level=2},
            new Pirate {Name="Barnacle Bill", Level=3},
            new Pirate {Name="Pete Peg-Leg", Level=2},
            new Pirate {Name="Lady Marilyn Man-Eater", Level=2},
            new Pirate {Name="Janie Big-Lips", Level=2},
            new Pirate {Name="Clara Shadows", Level=1},
            new Pirate {Name="Musclemouth Mike", Level=1},
            new Pirate {Name="Jacob Cutter", Level=3},
            new Pirate {Name="One-Leg Nellie", Level=4},
            new Pirate {Name="Bill Bones", Level=1},
            new Pirate {Name="Randell Rummy", Level=3},
            new Pirate {Name="Betty Tuna-Breath", Level=5},
            new Pirate {Name="Esme Dark-Waters", Level=5},
            new Pirate {Name="Dirty Danny", Level=4},
            new Pirate {Name="One-Eye Wendy", Level=3},
            new Pirate {Name="Shark-Fin Suzie", Level=4},
            new Pirate {Name="Malvo Razor-Face", Level=3},
            new Pirate {Name="One-Tooth John", Level=2},
            new Pirate {Name="Mighty Mary", Level=4},
            new Pirate {Name="Crazy Kellie", Level=2},
            new Pirate {Name="Pistol-Grin Gary", Level=2},
            new Pirate {Name="Moonie Two-Toe", Level=5},
            new Pirate {Name="Lady Tide", Level=5},
            new Pirate {Name="Pearl Bailey", Level=1},
            new Pirate {Name="Esme Dark-Waters", Level=5},
            new Pirate {Name="Chipper Goldheart", Level=1},
            new Pirate {Name="Jonas Rattler", Level=3},
            new Pirate {Name="Wade Wilds", Level=3},
            new Pirate {Name="Boney Brenda", Level=4},
            new Pirate {Name="Martha One-Eyed", Level=2},
            new Pirate {Name="Silver-Tooth Samuel", Level=2},
            new Pirate {Name="Opal Sea-Wolf", Level=5},
            new Pirate {Name="Handsome Jimmy", Level=2},
            new Pirate {Name="Carrie Atlantis", Level=1},
            new Pirate {Name="Big Jones", Level=1},
            new Pirate {Name="Jack Red-Locks", Level=3},
            new Pirate {Name="Roger Starky", Level=4},
            new Pirate {Name="Cut-Throat Connie", Level=5},
            new Pirate {Name="John Blackeye", Level=1},
            new Pirate {Name="Liza Mcgee", Level=5},
            new Pirate {Name="George Balding", Level=3},
            new Pirate {Name="Oscar Foul", Level=3},
            new Pirate {Name="Nancy Tall-Tide", Level=5},
            new Pirate {Name="Lady Cassandra", Level=2},
            new Pirate {Name="Crimson Seadog", Level=1},
            new Pirate {Name="Poopdeck Pete", Level=1},
            new Pirate {Name="Maximus Dark-Skull", Level=1},
            new Pirate {Name="Salty Sarah", Level=4},
            new Pirate {Name="Suzie McGraw", Level=2},
            new Pirate {Name="Garrick Roach", Level=3},
            new Pirate {Name="Mad Michael", Level=2},
            new Pirate {Name="Mazie Deep-Waters", Level=1},
            new Pirate {Name="Lou-Lou Stubbs", Level=1},
            new Pirate {Name="Glory Jones", Level=1},
            new Pirate {Name="Kellie Strong-Heart", Level=4},
            new Pirate {Name="Edwin ‘No Money’ Mables", Level=3},
            new Pirate {Name="Vince Puffypants", Level=3},
            new Pirate {Name="Wainwright ‘Bird Eye’ Shelley", Level=1},
            new Pirate {Name="Vera Sparrow", Level=1},
            new Pirate {Name="Finn O’Fish", Level=4},
            new Pirate {Name="Shiverin’ Shelley", Level=4},
            new Pirate {Name="Mary Jane Death-Bringer", Level=2},
            new Pirate {Name="Old Chipper", Level=2},
            new Pirate {Name="Pete Blackbeard", Level=1},
            new Pirate {Name="Joy McStubby", Level=5},
            new Pirate {Name="Liza Scallywag", Level=3},
            new Pirate {Name="Sadie Waters", Level=5},
            new Pirate {Name="Daisy O’Jelly", Level=2},
            new Pirate {Name="Penelope Precious", Level=4},
            new Pirate {Name="Barnacle Bill", Level=2},
            new Pirate {Name="Speechless Mike", Level=2},
            new Pirate {Name="Hunter Brendan", Level=2},
            new Pirate {Name="Jason Sea Legs", Level=2},
            new Pirate {Name="Gordon Rough", Level=3},
            new Pirate {Name="Silvera Snake-Eyes", Level=4},
            new Pirate {Name="Nancy Lobster-Legs", Level=5},
            new Pirate {Name="Peggy One-Leg", Level=1},
            new Pirate {Name="Evie Shark-Bait", Level=1},
            new Pirate {Name="Hansel The Handsome", Level=3},
            new Pirate {Name="Mary Gun-Powder", Level=5},
            new Pirate {Name="Celia ‘Butcher’ Tyde", Level=4},
            new Pirate {Name="One-Eye Wendy", Level=4},
            new Pirate {Name="Ella Treasures", Level=1},
            new Pirate {Name="Sally Black", Level=1},
            new Pirate {Name="Bella O’Greed", Level=1},
            new Pirate {Name="Stinkin’ Pete", Level=1},
            new Pirate {Name="Voodoo Wendy", Level=4},
            new Pirate {Name="Theo Stinkalot", Level=3},
            new Pirate {Name="Misty Winters", Level=4},
            new Pirate {Name="Black Bill The Feared", Level=1},
            new Pirate {Name="Rascal Jimmy", Level=2},
            new Pirate {Name="Peteplank", Level=1},
            new Pirate {Name="Elnora ‘Evil Grin’ Neale", Level=4},
            new Pirate {Name="Cannonball Conner", Level=2},
            new Pirate {Name="Old-Tide Sammy", Level=1},
            new Pirate {Name="Evie Shark-Bait", Level=4},
            new Pirate {Name="Paddy Sparrow", Level=3},
            new Pirate {Name="Wyatt Gold", Level=3},
            new Pirate {Name="Thunder Dave", Level=1},
            new Pirate {Name="Miranda Gold-Tooth", Level=1},
            new Pirate {Name="Churchhill Evans", Level=4},
            new Pirate {Name="Lazy-Eye Louie", Level=2},
            new Pirate {Name="Jilly Buckets", Level=5},
            new Pirate {Name="Penelope Precious", Level=3},
            new Pirate {Name="Sugar-Tongue Shelly", Level=4},
            new Pirate {Name="Winter Greybeard", Level=1},
            new Pirate {Name="Davey Dark-Skull", Level=1}
        };

        public Tortuga()
        {
            //foreach (Pirate pirate in _pirates)
            //{
            //    pirate.SetRankFromLevel();
            //}
        }


        public List<Pirate> GetPiratesByLevel(int count, int level)
        {
            Pirate nyRackare = new Pirate();
            nyRackare.Name = "Erik";
            nyRackare.Level = 5;
            _pirates.Add(nyRackare);
            List<Pirate> selectedPirates = new List<Pirate> ();
            //for (int i = 0; i < count; i++)
            //{
            //    Pirate pirate = _pirates[i];
            //    if (pirate.Level == level)
            //    {
            //        selectedPirates.Add(pirate);
            //    }
            //}
            foreach (Pirate pirate in _pirates)
            {
                if (pirate.Level == level)
                {
                    selectedPirates.Add(pirate);
                }
                if (selectedPirates.Count == count)
                {
                    break;
                }
            }
            int index = 0;
            //while (selectedPirates.Count < count)
            //{
            //    Pirate pirate = _pirates[index];
            //    index++;
            //}

            return selectedPirates;
        }

        public List<Pirate> GetPirates(int lowestLevel=1, int higestLevel=4)
        {
            List<Pirate> selectedPirates = new List<Pirate>();

            // eftersom vi måste leta igenom ALLA pirater
            // => foreach

            foreach (Pirate pirate in _pirates)
            {
                if (pirate.Level >= lowestLevel && pirate.Level <=higestLevel)
                {
                    selectedPirates.Add(pirate);
                }
            }

            return selectedPirates;
        }

        /// <summary>
        /// Lista med kaptener
        /// </summary>
        /// <returns></returns>
        public List<Pirate> GetPirateCaptains()
        {
            List<Pirate> selectedPirates = new List<Pirate>();
            selectedPirates = GetPirates(4, 5);
            return selectedPirates;
        }
    }
}
