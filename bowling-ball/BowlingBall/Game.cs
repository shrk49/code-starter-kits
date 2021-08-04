using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int[] frame = new int[10];
        int currentRoll=0;
        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
            rolls[currentRoll++]=pins;
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            return 0;
        }
         public void Roll(int[] pins)
        {
            for(int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }
    }
}
