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
          private int currentRoll = 0;
          public int score;
          public int scoringCurrentRoll;
        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
             rolls[currentRoll++] = pins;
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            for(int frame = 1; frame <= 10; frame++)
                {
                      if(isStrike(scoringCurrentRoll))
                        addScoreForStrike();
                      else if(isSpare(scoringCurrentRoll))
                        addScoreForSpare();
                      else
                        addScoreForOtherFrame();
                }
                        return score;                    
        }
        
           public boolean isSpare(int currentRoll)
          {
            return rolls[currentRoll] + rolls[currentRoll+1] == 10;
          }

          public boolean isStrike(int currentRoll)
          {
            return rolls[currentRoll] == 10;
          }
        
           public void addScoreForStrike()
          {
            score += 10 + rolls[scoringCurrentRoll + 1] + rolls[scoringCurrentRoll + 2];
            scoringCurrentRoll += 1; 
          }
         public void addScoreForSpare()
          {
            score += 10 + rolls[scoringCurrentRoll + 2];
            scoringCurrentRoll += 2;
          }
        public void addScoreForOtherFrame()
          {
            score += rolls[scoringCurrentRoll] + rolls[scoringCurrentRoll + 1];
            scoringCurrentRoll += 2;
          }
    }
}
