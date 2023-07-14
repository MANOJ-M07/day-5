using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJarray
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int noc, nos;
            Console.WriteLine("Enter Number of Classes");
            noc = int.Parse(Console.ReadLine());
            string[][] students = new string[noc][];
            for (int i = 0; i < noc; i++)
            {
                Console.WriteLine("Enter NUmber of student in class "+(i + 1));
                nos = int.Parse(Console.ReadLine());
                students[i] = new string[nos];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter Student {j+1}\'s name ");
                    students[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0;i < students.Length; i++)
            {
                Console.WriteLine($"students list of class {i+1}");
                Console.WriteLine("***********************************");
                for (int j = 0;j < students[i].Length; j++)
                {
                    Console.WriteLine(students[i][j]);
                }
                Console.WriteLine("***********************************");

            }
            Console.ReadKey();  */

            int[][,] myJArray = new int[3][,];
            myJArray[0] = new int[2,2] { { 1, 2 }, { 2,3} };
            myJArray[1]= new int[3,2] { { 1, 2 }, { 2, 3 }, { 3,4} };
            myJArray[2] = new int[3, 3] { { 1, 2, 6 }, { 2, 3, 7 }, { 5, 4, 8 } };
            Console.WriteLine("Stored Value");
            for (int i = 0; i < myJArray.Length; i++)
            {
                for (int r = 0; r< myJArray[i].GetLength(0); r++)
                {
                    for (int c = 0;c< myJArray[i].GetLength(1); c++)
                    {
                        Console.WriteLine(myJArray[i][r,c]+"\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("********************8");
            }
            Console.ReadKey();

        }
    }
}
