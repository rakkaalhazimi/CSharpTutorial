using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class ForLoop
    {
        public static void Run()
        {
            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hello " + i);
            }

            for (int i = 0; ; i++)
            { 
                if (i > 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("hello " + i);
                }
            }


            // For each loop
            string[] cats = { "tenyom", "combro", "jumul" };
            foreach (string catName in cats)
            {
                Console.WriteLine("catName: " + catName);
            }

        }
    }
}
