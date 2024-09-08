using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class GenericMethod
    {
        //static void Show<T>(T a)
        //{
        //    Console.WriteLine("Data is : " + a);
        //}

        static void Show<T1, T2>(T1 x, T2 y)
        {
            Console.WriteLine("Data is : " + x);
            Console.WriteLine("Data is : " + y);
        }
        static void Main(string[] args)
        {
            //Show<string>("Sharad");
            Show<int, string>(24, "Sharad");
            Show<string, string>("Aade ", "Sharad");
        }
    }
}
