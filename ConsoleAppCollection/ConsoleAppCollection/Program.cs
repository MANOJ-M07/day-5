using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to Collection");*/


            /* ArrayList arraylist = new ArrayList
             {
                 "sam",
                 "Ravi",
                 "Amit"
             };
             Console.WriteLine("Number of Element in array list " +arraylist.Count);
             Console.WriteLine("Capacity of array " + arraylist.Capacity);
             foreach (var item in arraylist)
             {
                 Console.WriteLine(item);
             }
             arraylist.Add("Amit");
             arraylist.Add("Sunita");
             Console.WriteLine("After adding two more elements in array list");
             Console.WriteLine("number of element in array list are \t" +arraylist.Count);
             Console.WriteLine("Capacity of array list \t" +arraylist.Capacity);
             foreach (var item in arraylist)
             {
                 Console.WriteLine(item);
             }
             arraylist.Sort();
             Console.WriteLine("**Sorted Array**");
             foreach (var item in arraylist)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("Reverse the list");
             arraylist.Reverse();
             Console.WriteLine("**Sorted array in dec**");
             foreach(var item in arraylist)
             {
                 Console.WriteLine(item);
             }*/
            /*ArrayList myList = new ArrayList { 12, 45, 55, 11 };
            Console.WriteLine("Number List");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Reverse();
            Console.WriteLine("**reverse number");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Sort();
            Console.WriteLine("**sort number");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Remove(12);
            Console.WriteLine("**remove");
            foreach (int i in myList)
            { 
                Console.WriteLine(i); 
            }
            myList.RemoveAt(2);
            Console.WriteLine("After removing from index 3");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }*/
            
            /*ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("printer");
            hardwareList.Add("keyboard");
            hardwareList.Add("mouse");
            hardwareList.Add("network card");
            Console.WriteLine("initial hardware list");
            for(int i = 0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }*/
            /*Console.WriteLine("Enter item to search & update");
            string searchItem = Console.ReadLine();
            int index=hardwareList.IndexOf(searchItem);
            if(index == -1)
            {
                Console.WriteLine($"no such item {searchItem}");
            }
            else
            {
                Console.WriteLine("new value");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("updated hardware list ");
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
            }*/
            /*string newItem;
            Console.WriteLine("enter new item");
            newItem  = Console.ReadLine();
            hardwareList.Add(newItem);
            Console.WriteLine("list after adding new item");
            for (int i = 0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }*/

            Hashtable hardware = new Hashtable() { { 1, "CD" }, { 2, "DVD" }, { 3, "keyboars" }, { 4, "mouse" } };
            Console.WriteLine("List of ways");
            foreach (var k in hardware.Keys) 
            { Console.WriteLine(k); }
            Console.WriteLine("List of Values");
            foreach(var v in hardware.Values) 
            { Console.WriteLine(v); }
            Console.WriteLine("Hardware key \t Name of Hardware");
            foreach ( var k in hardware.Keys) 
            { Console.WriteLine(k+"\t\t" + hardware[k]); }

            Console.ReadKey();  
        }
    }
}
