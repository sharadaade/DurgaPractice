using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class GenericStackCollection
    {
        static void Main(string[] args)
        {
            Stack<string> ss = new Stack<string>();

            ss.Push("Sharad");
            ss.Push("Raj");
            ss.Push("Babalu");
            ss.Push("Ram");
            ss.Push("Rani");
            ss.Push("Siya");


            // Display the no of element 
            Console.WriteLine(ss.Count);

            // Peek Method return the top element withoout removing
            Console.WriteLine(ss.Peek());

            // Pop() methood is used to remove top element and return element(object)
            Console.WriteLine(ss.Pop());

            Console.WriteLine("-----------------------------");

            // It return True if onject is available else return False
            Console.WriteLine(ss.Contains("Sharad"));

            

            foreach (var items in ss)
            {
                Console.WriteLine(items);
            }

        }
    }
}
