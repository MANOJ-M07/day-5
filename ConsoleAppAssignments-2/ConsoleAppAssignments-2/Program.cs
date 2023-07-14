using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignments_2
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            
            Console.WriteLine("Total number of elements: " + fruits.Count);

            Console.WriteLine("Enter the elementto search");
            string searchElement = Console.ReadLine();
            bool containssearchElement = fruits.Contains(searchElement);
            Console.WriteLine($"Contains {searchElement}: " + containssearchElement);

            Console.WriteLine("Enter an elemnet to insert at second position");
            string insertElement = Console.ReadLine();
            fruits.Insert(1, insertElement);

            Console.WriteLine("Enter an element to remove");
            string removeElement = Console.ReadLine();
            fruits.Remove(removeElement);

            Console.WriteLine("");
            Console.WriteLine("Elements in the ArrayList:");
            foreach (object element in fruits)
            {
                Console.WriteLine(element);
            }





            Console.ReadKey();
        }
    }
}
