using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Switch
    {
        public static void Run()
        {
            switch ("good")
            {
                case "good":
                    Console.WriteLine("is Good");
                    break;

                case "bad":
                    Console.WriteLine("is Bad");
                    break;

                default:
                    Console.WriteLine("neither Good or Bad");
                    break;
            }
        }
    }
}
