using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Durga
{
    internal class GenericList
    {
        static void Main(string[] args)
        {
            //List<string> stl = new List<string>();
            //stl.Add("A");
            //stl.Add("B");
            //stl.Add("C");
            //stl.Add("D");

            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);
            ll.Add(4);

            List<int> ar = new List<int>();
            ar.Add(20);
            ar.Add(10);
            ar.Add(40);
            ar.Add(30);
            ar.Add(60);
            ar.Add(50);


            //Console.WriteLine(ar.Count);
            //Console.WriteLine(ar.Capacity);

            // AddRange through we can pass the anothe list
            //ar.AddRange(ll);

            // Remove the element
            //ar.Remove(10);

            // RemoveAt remove element from specific index
            //ar.RemoveAt(1);

            // RemoveRange(intex, count) 
            // index number from we can remove and number of element(count)
            //ar.RemoveRange(1,4);

            // Reverse the list 
            //ar.Reverse();

            // Sorting element in ascending order
            //ar.Sort();

            //It return True if item available 
            //It return False if item unavilable
            //Console.WriteLine(ar.Contains(20));;
            //Console.WriteLine(ar.Contains(5000));;

            // IndexOf() it return index number if item available 
            // otherwise return -1
            //Console.WriteLine(ar.IndexOf(30));


            foreach(var item in ar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
