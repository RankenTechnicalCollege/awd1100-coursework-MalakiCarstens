// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;

int testScoreCount = 0;
int scoreTotal = 0;
int minScore = int.MaxValue;
int maxScore = int.MinValue;
while (true)
{
    Console.WriteLine("Enter a test score 0-100. Type 999 to finish entries.");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int score))
    {
        if (score == 999)
        {
            break;
        }
        else if (score >= 0 && score <= 100) 
        {
            scoreTotal = scoreTotal + score;
            testScoreCount++;
            if (score < minScore) minScore = score;
            if (score > maxScore) maxScore = score;
          
        }
        else
        {
            Console.WriteLine("Invalid score entry, number must be 0-100, please try again.");
        }
        if (score > 0)
        {
            double average = (double)scoreTotal / testScoreCount;
            Console.WriteLine($"Number of scores. {testScoreCount} ");
            Console.WriteLine($"Total of scores. {scoreTotal}");
            Console.WriteLine($"Average score. {average:f2}");
            Console.WriteLine($"Minimum score. {minScore}");
            Console.WriteLine($"Maximum score. {maxScore}");
        }
        else
        {
            Console.WriteLine($"No valid scores were entered.");
        }
    }
}
