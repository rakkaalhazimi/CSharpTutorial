using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class String
    {
        public static void Run()
        {
            // String methods
            string myString = "hello";
            Console.WriteLine("Original string: " + myString);
            Console.WriteLine("Length of string: " + myString.Length);
            Console.WriteLine("Uppercase version: " + myString.ToUpper());
            Console.WriteLine("Lowercase version: " + myString.ToLower());
            Console.WriteLine("Concatenate with other string: " + string.Concat(myString, " world"));

            // String Interpolation
            string firstName = "tenyom";
            string lastName = "kucing";
            string name = $"{firstName} {lastName}";
            Console.WriteLine("Full Name: " + name);

            // Access String
            Console.WriteLine("Index 0 of string: " + myString[0]);
            Console.WriteLine("2 first words of string: " + myString.Substring(0, 2));
            Console.WriteLine("Index of first occurrence of word 'e': " + myString.IndexOf('e'));

        }
    }
}
