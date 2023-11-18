using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class ArrayTutorial
    {
        public static void Run()
        {
            // Create an array
            string[] cats = { "tenyom", "combro", "sumbul" };
            int[] ages = { 4, 3, 2 };

            // Access element of the array
            Console.WriteLine("First cat: " + cats[0]);

            // Change an element of array
            cats[0] = "onyom";

            // Array length
            Console.WriteLine("Total cats: " + cats.Length);

            // Add new item in the end of array
            cats.Append<string>("sumbul");

            // Sort an array
            Array.Sort(ages);
            Console.WriteLine("Sorted array: ");
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            // System.Linq method
            Console.WriteLine("Largest values : " + ages.Max());  // returns the largest value
            Console.WriteLine("Smallest values : " + ages.Min());  // returns the smallest value
            Console.WriteLine("Sum of values : " + ages.Sum());  // returns the sum of elements


            // Multidimensional array
            int[,] matrix2d = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,,] matrix3d = { { { 1, 2, 3 } }, { { 4, 5, 6 } } };
        }
    }
}
