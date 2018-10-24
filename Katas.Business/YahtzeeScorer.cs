using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Business
{
    public class YahtzeeScorer
    {
        public int ScoreFullHouse(int[] rolls)
        {
            var score = 0;
            var groups = rolls.GroupBy(x => x);

            if (groups.Count() == 2)
            {

                score = rolls.Sum();

            }

            return score;
        }

        public int ScoreYahtzee(int[] rolls)
        {
            int score = 0;
            var groups = rolls.GroupBy(x => x);
            if(groups.Count() == 1)
            {
                score = 50;
            }
            return score;
        }

        public int ScoreChance(int[] rolls)
        {
            return rolls.Sum();
        }

        public int LgStraight(int[] rolls)

        {
            int score = 0;
            var groups = rolls.GroupBy(x => x);
            if (groups.Count() == 5)
            {
                if (Array.IndexOf(rolls,1) == -1)
                {
                    score = 20;
                }
            }
            return score;
           
        }

        public int SmStraight(int[] rolls)
        {
            int score = 0;
            var groups = rolls.GroupBy(x => x);
            if (groups.Count() == 5)
            {
                if (Array.IndexOf(rolls, 6) == -1)
                {
                    score = 15;
                }
            }
            return score;
        }

        public int FourOfAKind(int[] rolls)
        {
            int score = 0;
            int[] counts = new int[6];
            foreach(int num in rolls)
            {
                counts[num]++;
                if(counts[num] >= 4)
                {
                    score = num * 4;
                }
            }
            return score;
        }

        public int ThreeOfAKind(int[] rolls)
        {
            var groups = rolls.GroupBy(x => x).ToDictionary(g => g.Key, g=> g.Count()); 

            foreach (KeyValuePair<int, int> entry in groups)
            {
               if (entry.Value >= 3)
                {
                    return entry.Key * 3;
                }
            }
            return 0;
        }

        public object TwoPairs(int[] rolls)
        {
            int score = 0;
            int pairs = 0;
            var groups = rolls.GroupBy(x => x);
            if (groups.Count() >= 2)
            {
               foreach (var num in groups)
                {
                    if(num.Count() >= 2)
                    {
                        score += num.Key * 2;
                        pairs++;
                    }
                }
            }
            return (pairs == 2 ? score : 0);
        }

        public int SinglePair(int[] rolls)
        {
            int score = 0;
            var groups = rolls.GroupBy(x => x);
            foreach (var num in groups)
            {
                if (num.Count() >= 2)
                {
                    int thisVal = num.Key * 2;
                    if(thisVal > score){
                        score = thisVal;
                    }
                }
            }
            return score;
        }

        public int PlayerChoice(int[] rolls, int choice)
        {
            int score = 0;
            var groups = rolls.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            if (groups.ContainsKey(choice))
            {
                score = choice * groups[choice];
            }
            return score;
        }
    }
}
