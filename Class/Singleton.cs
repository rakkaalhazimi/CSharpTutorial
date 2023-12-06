using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Class
{
    internal class Singleton: IDisposable
    {
        public static Singleton Instance { get; } = new Singleton();

        public string name { get; private set; }
        
        public int age { get; private set; }

        public void Initialize (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Dispose()
        {
        }
    }
}
