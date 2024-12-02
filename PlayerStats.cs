using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame_v3
{
    internal class PlayerStats
    {
        public int TotalGamesPlayed { get; set; }
        public int TotalGamesWon { get; set; }
        public int TotalGamesLost { get; set; }
        public int ConsecutiveLosses { get; set; }
        public int TotalEarnings { get; set; }

        public PlayerStats()
        {
            TotalGamesPlayed = 0;
            TotalGamesWon = 0;
            TotalGamesLost = 0;
            ConsecutiveLosses = 0;
            TotalEarnings = 0;
        }
    }
}
