using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm scoringAlgorithm;
            Console.WriteLine(" Mans..................................");
            scoringAlgorithm = new Mens();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10,new TimeSpan(0,2,34)));
            Console.WriteLine(" Womens----------------");
            scoringAlgorithm = new Woman();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine(" Children................................");
            scoringAlgorithm = new Cildrens();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10, new TimeSpan(10, 2, 34)));

            Console.ReadLine();

        }
    }
  abstract  class ScoringAlgorithm /// TemplateMethod 
    {
        public int GenerateScore(int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateRedaction(time);
            return CalculateOveralScore(score,reduction);
        }

        public abstract int CalculateOveralScore(int score, int reduction);
        public abstract int CalculateRedaction(TimeSpan time);
        public abstract int CalculateBaseScore(int hits);
        
    }
    class Mens : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100; // her vuruş için 100 pvan ver 
        }

        public override int CalculateOveralScore(int score, int reduction)
        {
            return score - reduction;// kırılacak puvan
        }

        public override int CalculateRedaction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5; // kaç sanye geçti 
        }
    }
    class Woman : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100; // her vuruş için 100 pvan ver 
        }

        public override int CalculateOveralScore(int score, int reduction)
        {
            return score - reduction;// kırılacak puvan
        } 
        public override int CalculateRedaction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3; // kaç sanye geçti 
        }
    }
    class Cildrens : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80; // her vuruş için 100 pvan ver 
        }

        public override int CalculateOveralScore(int score, int reduction)
        {
            return reduction - score;// kırılacak puvan
        }

        public override int CalculateRedaction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2; // kaç sanye geçti 
        }
    }
}
