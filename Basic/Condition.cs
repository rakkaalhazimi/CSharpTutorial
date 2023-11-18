using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Condition
    {
        public static void Run()
        {
            // If..else Statement
            int myInt = 10;
            if (myInt > 10)
            {
                Console.WriteLine("My int is larger than 10");

            } 
            else if (myInt < 10) 
            {
                Console.WriteLine("My int is smaller than 10");
            }
            else
            {
                Console.WriteLine("My int is equal to 10");
            }

            // Ternary Operator
            string statement = (true) ? "true" : "false";
            Console.WriteLine("Ternary statement: " + statement);
        }
    }
}
