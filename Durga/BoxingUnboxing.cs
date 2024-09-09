using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Boxing => Convertiong variable from value type to refernce type
// Unboxing => Convertiong variable from reference type to value type

// Boxing =>1)implicit 2)Explicit
// Unboxing =>1)Explicit

// Boxing is 20 times costlier than normal initialization
// Unboxing is 4 times costlier than normal initialization

// Boxing is 20 times costlier than normal initialization because whenever boxing is done following steps done
// 1. Runtime will search for the respective data within the stack.
// 2. A copy of this value is made into heap.
// 3. Reference of this copy is maintained from object variable.

// Unboxing is 4 times costlier than normal initialization because whenever unboxing is done following steps done
// 1. Object reference value is searched  within the heap.
// 2. A copy of this is made into stack.


//NOTE:- As boxing and Unboxing costlier than noramal initialization so that boxing and Unboxing should be avoid in maximum situation.

namespace Durga
{
    internal class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int a = 10; // Norma intialization
            Object O = a; // Implicit Boxing
            Object X = (object)a; // Explicit Boxing
            int j = (int)O; // Explicit Unboxing

            Console.WriteLine("Value is : " + a);
            Console.WriteLine("Value is : " + O);
            Console.WriteLine("Value is : " + X);
            Console.WriteLine("Value is : " + j);
        }
    }
}
