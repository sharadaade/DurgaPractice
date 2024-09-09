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
    public delegate void Calculator(int a, int b);
    class MyClaa
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Result : " + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Result : " + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Result : " + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Result : " + (a / b));
        }
    }
    internal class TheDelegates
    {
        
        static void Main(string[] args)
        {
            //Pointer
            //int a = 100;

            //unsafe
            //{
            //    int* x = &a;
            //    Console.WriteLine("Value of a is :" + *x);
            //    Console.WriteLine("address of a is : " + (int)x);
            //}

            MyClaa obj = new MyClaa();

            Calculator ob = new Calculator(obj.Add);
            ob += obj.Sub;
            ob += obj.Mul;
            ob += obj.Div;

            //Invoking Delegate
            ob(20, 10);

            // Remove 
            ob -= obj.Add;
            ob -= obj.Sub;
            
            // Again Invoking Delegate
            ob(22, 2);

        }
    }
}
