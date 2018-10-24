using Katas.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Katas.Test
{
    [TestClass]
    public class YahtzeeTests
    {
        [TestMethod]
        [DataRow(new int[]{1, 1, 1, 4, 4}, 11)]
        [DataRow(new int[]{2,1,1,2,3}, 0)]
        [DataRow(new int[] { 5, 5, 5, 5, 5 }, 0)]
        public void Can_Score_Full_House(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.ScoreFullHouse(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }
        [TestMethod]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 50)]
        [DataRow(new int[] { 2, 1, 1, 1, 1 }, 0)]
        public void Can_Score_Yahtzee(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.ScoreYahtzee(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        
        }

        [TestMethod]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 5)]
        [DataRow(new int[] { 1, 1, 1, 1, 6 }, 10)]
        public void Can_Score_chance(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.ScoreChance(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 2, 3, 4, 5, 6 }, 20)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 0)]
        public void Can_Score_LgStraight(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.LgStraight(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 0)]
        public void Can_Score_SmStraight(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.SmStraight(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 4, 4, 4, 4, 0 }, 16)]
        [DataRow(new int[] { 1, 1, 1, 1, 0 }, 4)]
        public void Can_Score_FourOfAKind(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.FourOfAKind(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 5, 5, 5, 1, 0 }, 15)]
        [DataRow(new int[] { 4, 4, 4, 2, 5 }, 12)]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 3)]
        public void Can_Score_ThreeOfAKind(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.ThreeOfAKind(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 5, 5, 1, 1, 1 }, 12)]
        [DataRow(new int[] { 5, 1, 1, 1, 1 }, 0)]
        public void Can_Score_TwoPairs(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.TwoPairs(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }

        [TestMethod]
        [DataRow(new int[] { 5, 5, 1, 1, 1 }, 10)]
        [DataRow(new int[] { 6, 6, 1, 1, 1 }, 12)]
        [DataRow(new int[] { 5, 5, 1, 6, 6 }, 12)]
        [DataRow(new int[] { 2, 3, 1, 4, 6 }, 0)]
        public void Can_Score_SinglePair(int[] rolls, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.SinglePair(rolls);

            Assert.AreEqual(expectedScore, actualScore);

        }
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, 5)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 6, 0)]
        public void Can_Score_PlayerChoice(int[] rolls, int choice, int expectedScore)
        {
            var scorer = new YahtzeeScorer();
            var actualScore = scorer.PlayerChoice(rolls, choice);

            Assert.AreEqual(expectedScore, actualScore);

        }
    }
}
