using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Prerequisite -> Pointer
// Pointer is a variable which is used to store the address of another variable
// The code which is written using pointer is called unnsafe code
// Unsafe code be write using unsafe keyword within the unsafe block or within the unsafe class
// Unsafe code can only be run with unsafe option only
// Syntax: -
// datatype*variablename
//ex. int*x  => here x is pointer variable
//* Pointer operator
//& Address operator


// In C# Delegate are similar to dunction pointer in C++
// Delegate are used to represent or refer one or more funnction
// Delegate are object oriented and secure
// To consume delegate then we need to create object for the delegate
// In C# delegate are not member of class but it is similar to the class

// Work with delegates we need to follow these steps -

// Step 1: Create a delegates
// Syntax: access_modifiers delegate return_type Delegae_name(argument_list);  
// Ex:     public delegate void MyDelegate(int a, int b);

// Step 2: Instantiate a delegates
// Syntax: delegate_name Object_name = new delegate_name(target_function_name);
// Ex:     MyDelegate obj = new MyDelegate(Add);

// Step 3: Invoking a delegates
// Syntax: Delegate_object_name(argument_list);
// Ex:     obj(10, 20);

namespace Durga
{
    internal class TheDelegates
    {
        static void Main(string[] args)
        {
            int a = 100;
            unsafe
            {
                int* x = &a;
                Console.WriteLine("Value of a is :" + *x);
                Console.WriteLine("address of a is : " + (int)x);
            }
        }
    }
}
