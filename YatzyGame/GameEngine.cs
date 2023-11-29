using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyGame
{
    class GameEngine
    {
        #region public properties
        public int ScoreOnes => _scores[0];
        public int ScoreTwos => _scores[1];
        public bool CanRollDice => _countRolls <= 3; 
        public int Total => _scores.Sum();
        #endregion
        #region Private fields
        private int _countRolls = 1;
        private readonly Random _random = new();
        private int[] _dice = new int[5];
        private bool[] _usedCategories = { false, false, false, false, false, false };
        private int[] _scores = new int[6];
        private bool[] _savedDice = { false, false, false, false, false }; 
        #endregion
        #region Tärningar
        /// <summary>
        /// Kastar fem tärningar
        /// </summary>
        /// <returns>array med fem fack, heltal</returns>
        public int[] RollDice()
        {
            for (int i = 0; i < _dice.Length; i++)
            {
                // undersök om tärningen är sparad eller inte
                if (!_savedDice[i])
                {
                    _dice[i] = _random.Next(1, 7);
                }
            }
            _countRolls++;
            return _dice;
        }

        /// <summary>
        /// Kastar fem tärningar men sparar vissa
        /// </summary>
        /// <returns>array med fem fack, heltal</returns>
        public int[] RollDice(bool[] saved)
        {
            _savedDice = saved;
            return RollDice();
        } 
        #endregion

        public bool BetOnCategory(int category)
        {
            // är kategorin tillgänglig?
            if (_usedCategories[category - 1])
                return false;
            _countRolls = 1;

          CalculateScore(category);
            return true;
        }

        private int CalculateScore(int category)
        {
            int score = 0;
            foreach (int die in _dice) { 
               if(die == category)
                {
                    score += die;
                }
            }
            _scores[category-1] = score;
            _usedCategories[category-1] = true;
            return score;
        }
    }
}
