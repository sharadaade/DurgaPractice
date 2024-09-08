using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Durga
{
    internal class ArrayResize
    {
        static void Main(string[] args)
        {
            
            int[] ar = new int[4] { 1, 2, 3, 4 };

            //Console.WriteLine("Old length " + ar.Length);

            //Console.WriteLine("Enter the size of new array : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Array.Resize(ref ar, n);
            //Array.Reverse(ar);
            
            Console.WriteLine(Array.IndexOf(ar, 7));
            Console.WriteLine();
            //Console.WriteLine("New length " + ar.Length);

            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
