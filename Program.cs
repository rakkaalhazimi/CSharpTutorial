using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTutorial.Class;
using CSharpTutorial.Utils;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Initialize("rakka", 20);

            Console.WriteLine("Name: {0}, Age: {1}", Singleton.Instance.name, Singleton.Instance.age);

            Console.WriteLine("[*] Press any key to exit");
            Console.ReadKey();
        }
    }
}
