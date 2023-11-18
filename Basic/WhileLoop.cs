using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class WhileLoop
    {
        public static void Run()
        {
            // while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            // do while loop
            int j = 0;
            do
            {
                Console.WriteLine(j);
            }
            while (j < 5);
        }
    }
}
