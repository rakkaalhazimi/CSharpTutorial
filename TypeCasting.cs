using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class TypeCasting
    {
        public static void Run()
        {
            /*
             Implicit Casting (automatically) - converting a smaller type to a larger type size
             char -> int -> long -> float -> double
             */
            int myInt = 10;
            long myLong = myInt;

            /*
             Explicit Casting (manually) - converting a larger type to a smaller size type
             double -> float -> long -> int -> char
             */
            int otherInt = 10;
            short myShort = (short)otherInt;

            /*
             Type Conversion Methods
             */
            bool myBool = true;
            Console.WriteLine(Convert.ToInt32(myBool));

            /*
             Parse Type from String
             */
            string myBoolString = "true";
            string myIntString = "123";

            Console.WriteLine(bool.Parse(myBoolString));
            Console.WriteLine(int.Parse(myIntString));
        }
    }
}
