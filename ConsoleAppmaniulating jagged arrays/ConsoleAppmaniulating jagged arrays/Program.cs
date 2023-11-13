using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppmaniulating_jagged_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array called StudentScore to store the scores of three students
            int[][] StudentScore = new int[3][];

            // Initialize the StudentScore array with the following scores
            StudentScore[0] = new int[] { 85, 92, 78 };
            StudentScore[1] = new int[] { 90, 87, 93, 89 };
            StudentScore[2] = new int[] { 76, 88 };

            // Print the scores of each student using nested loops
            for (int i = 0; i < StudentScore.Length; i++)
            {
                Console.Write("Student {0}: ", i + 1);
                for (int j = 0; j < StudentScore[i].Length; j++)
                {
                    Console.Write("{0} ", StudentScore[i][j]);
                }
                Console.WriteLine();
            }

            // Calculate the average score for each student and print the results
            for (int i = 0; i < StudentScore.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < StudentScore[i].Length; j++)
                {
                    sum += StudentScore[i][j];
                }
                double average = (double)sum / StudentScore[i].Length;
                Console.WriteLine("Average score for Student {0}: {1}", i + 1, average);
            }

            // Calculate the average score for all the students combined and print the result
            int totalSum = 0;
            int totalCount = 0;
            for (int i = 0; i < StudentScore.Length; i++)
            {
                for (int j = 0; j < StudentScore[i].Length; j++)
                {
                    totalSum += StudentScore[i][j];
                    totalCount++;
                }
            }
            double totalAverage = (double)totalSum / totalCount;
            Console.WriteLine("Average score for all students combined: {0}", totalAverage);
            Console.ReadKey();
        }
    }


}
    
