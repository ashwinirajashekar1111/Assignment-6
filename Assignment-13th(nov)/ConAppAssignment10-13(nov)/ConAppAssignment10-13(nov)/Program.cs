using System;


namespace ConAppAssignment10_13_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jagged array to store scores
            int[][] studentsScores = new int[][]
            {
            new int[] {85, 92, 78},
            new int[] {90, 87, 93, 89},
            new int[] {76, 88}
            };

            // Print scores of each student using nested loops
            for (int i = 0; i < studentsScores.Length; i++)
            {
                Console.Write($"Student {i + 1} scores: ");
                for (int j = 0; j < studentsScores[i].Length; j++)
                {
                    Console.Write(studentsScores[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Calculate and print the average score for all students combined
            double totalScore = 0;
            int totalScoresCount = 0;

            for (int i = 0; i < studentsScores.Length; i++)
            {
                for (int j = 0; j < studentsScores[i].Length; j++)
                {
                    totalScore += studentsScores[i][j];
                    totalScoresCount++;
                }
            }

            double averageScore = totalScore / totalScoresCount;
            Console.WriteLine($"Average score for all students: {averageScore}");
        }
    
    }
}
