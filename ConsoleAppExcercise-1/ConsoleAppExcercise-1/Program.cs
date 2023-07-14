using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExcercise_1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of working days: ");
            int numWorkingDays = int.Parse(Console.ReadLine());
            int[][] salaries = new int[numEmployees][];
            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numWorkingDays];
                Console.WriteLine("Employee :", i + 1);
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.Write($"Enter salary for day{j + 1} : \t");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDay\t\tTotal Salary");
            for (int i = 0; i < numEmployees ; i++)
            {
                int totalSalary = 0;
                Console.Write($"employee {i + 1}: \t ");
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.WriteLine($"{salaries[i][j]}");
                    totalSalary += salaries[i][j];
                }
                
                Console.WriteLine("\t{0}", totalSalary);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}

