using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementChallenge2
{
    internal class Program
    {
        static int score;
        static int highscore = 19;
        static string highscorePlayer = "Lucas";

        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();

            Console.WriteLine("Answer the questions to win points, {0}", name);
            Console.WriteLine();

            Console.WriteLine("How much is 3 + 4?");
            string answer1 = Console.ReadLine();

            Console.WriteLine("The largest human organ is: ");
            string answer2 = Console.ReadLine();

            Console.WriteLine("For the double amount of points, Who created this game?");
            string answer3 = Console.ReadLine();

            if (answer1.Equals("7"))
            {
                score += 5;
            }
            else
            {
                score = 0;
            }

            if (answer2.Equals("skin"))
            {
                score += 5;
            }
            else
            {
                if (score > 0)
                {
                    score -= 2;
                }
                else
                {
                    score = 0;
                }
            }

            if (answer3.Equals("Lucas"))
            {
                score += 10;
            }
            else
            {
                if (score > 0)
                {
                    score -= 4;
                }
                else
                {
                    score = 0;
                }
            }

            Scores(score, name);

            Console.Read();
        }

        public static void Scores(int score, string playerName)
        {
            if (score > highscore)
            {
                Console.WriteLine("New highscore is {0}", score);
                Console.WriteLine("New highscore holder is {0}", playerName);
            }
            else
            {
                Console.WriteLine("The old high score of {0} could not be broken and is still held by {1}", highscore, highscorePlayer);
            }
        }
    }
}
