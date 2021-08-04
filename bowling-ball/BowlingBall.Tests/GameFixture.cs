using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
         private Game game;
        
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            g.Roll(0, 20);
            Assert.AreEqual(0, game.GetScore());
        }
        [TestMethod]
        public void CanRollAll()
        {
            RollThroughMany(1,20);
            Assert.AreEqual(20,game.GetScore());
        }
        
        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollThroughMany(0,17);
            Assert.AreEqual(16,game.GetScore());
        }
        [TestMethod]
        public void CanRollStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollThroughMany(0,16);
            Assert.AreEqual(24,game.GetScore());
        }
        [TestMethod]
        public void CanRollComplete()
        {
            RollThroughMany(10,12);
            Assert.AreEqual(300,game.GetScore());
        }
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            game.RollThroughMany(0, 20);
            Assert.AreEqual(0, game.GetScore());
        }
        
        private void RollThroughMany(int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
