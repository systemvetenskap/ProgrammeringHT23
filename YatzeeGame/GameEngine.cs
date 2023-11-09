using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzeeGame
{
    /// <summary>
    /// Spelregler och spellogik för vårt Yatzyspel
    /// </summary>
    internal class GameEngine
    {
        private readonly Random _random = new();
        private int[] _dice = new int[5];
        private bool[] _savedDice = { false, false, false, false, false };
        public void SaveDice(bool[] saved)
        {
            _savedDice = saved;
        }
        public int[] RollDice()
        {
            int total = 0;

            for (int i = 0; i < _dice.Length; i++)
            {
                // undersök om tärningen är sparad eller inte
                if (!_savedDice[i])
                {
                    _dice[i] = _random.Next(1, 7);
                }
            }
            return _dice;
        }
    }
}
