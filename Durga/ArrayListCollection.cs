using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class ArrayListCollection
    {
        static void Main(string[] args)
        {
            // Non-generic collection

            ArrayList a = new ArrayList();
            a.Add("S");
            a.Add("H");
            a.Add("A");
            a.Add(23);

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("shh");
            al.Add(20);
            al.Add(30);
            al.Add(40);

            // Adding the one ArrayList in another
            al.AddRange(a);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            // Insert at specific index
            al.Insert(1, "kkk");

            // To remove the element
            al.Remove(40);

            // Remove based on index
            al.RemoveAt(1);

            // remove elemt at specific from range 
            // From 2 onward not deleted
            al.RemoveRange(0, 2);

            // reverse the ArrayList
            al.Reverse();

            //Reverse the spscific element
            //from 1 index to reverse 3 element 
            al.Reverse(1, 3);

            // To get index of element where it present
            Console.WriteLine(al.IndexOf(10));

            // 
            Console.WriteLine(al.LastIndexOf(10));


            //foreach(var items in al)
            //{
            //    Console.WriteLine(items);
            //}
        }
    }
}
