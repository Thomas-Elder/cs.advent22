
namespace Advent22
{
    public class RockPaperScissors
    {

        public int TotalScore(string[] lines)
        {
            int score = 0;

            int rockScore = 1;
            int paperScore = 2;
            int scissorScore = 3;

            int win = 6;
            int draw = 3;
            int loss = 0;

            foreach (string line in lines)
            {
                char x = line[0];
                char y = line[2];

                // If they've picked rock
                if(x == 'A')
                {
                    if (y == 'X') score += rockScore + draw;
                    if (y == 'Y') score += paperScore + win;
                    if (y == 'Z') score += scissorScore + loss;
                }

                // If they've picked paper
                if (x == 'B')
                {
                    if (y == 'X') score += rockScore + loss;
                    if (y == 'Y') score += paperScore + draw;
                    if (y == 'Z') score += scissorScore + win;
                }

                // If they've picked scissors
                if (x == 'C')
                {
                    if (y == 'X') score += rockScore + win;
                    if (y == 'Y') score += paperScore + loss;
                    if (y == 'Z') score += scissorScore + draw;
                }
            }

            return score;
        }

        public int TotalScoreTwo(string[] lines)
        {
            int score = 0;

            int rockScore = 1;
            int paperScore = 2;
            int scissorScore = 3;

            int win = 6;
            int draw = 3;
            int loss = 0;

            foreach (string line in lines)
            {
                char x = line[0];
                char y = line[2];

                // We need to lose
                if (y == 'X')
                {
                    score += loss;

                    if (x == 'A') score += scissorScore;
                    if (x == 'B') score += rockScore;
                    if (x == 'C') score += paperScore;
                }

                // We need to draw
                if (y == 'Y')
                {
                    score += draw;

                    if (x == 'A') score += rockScore;
                    if (x == 'B') score += paperScore;
                    if (x == 'C') score += scissorScore;
                }

                // We need to win
                if (y == 'Z')
                {
                    score += win;

                    if (x == 'A') score += paperScore;
                    if (x == 'B') score += scissorScore;
                    if (x == 'C') score += rockScore;
                }
            }

            return score;
        }
    }
}
