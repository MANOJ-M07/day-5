using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write("Student " + (i + 1) + " scores: ");

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine("Average score for student " + (i + 1) + ": " + average);
            }
            Console.WriteLine();

            int totalSum = 0;
            int totalCount = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }
            double totalAverage = (double)totalSum / totalCount;
            Console.WriteLine("Average score for all students combined: " + totalAverage);
            Console.ReadKey();*/

            
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("\n");

            bool containsDate = fruits.Contains("date");
            Console.WriteLine("Contains 'date': " + containsDate);
            Console.WriteLine("\n");


            fruits.Insert(1, "fig");
            Console.WriteLine("***After inserting fig***");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("\n");


            fruits.Remove("banana");
            Console.WriteLine("****After removeing banana***");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
           
            Console.ReadKey();  
        }
        
    }
    
}

