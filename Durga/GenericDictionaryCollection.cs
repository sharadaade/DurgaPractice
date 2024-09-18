using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class GenericDictionaryCollection
    {
        static void Main(string[] args)
        {
            //Key Differences printing with foreach loop:-
            //For Dictionary, you use KeyValuePair<TKey, TValue> in the foreach.
            //For Hashtable, you use DictionaryEntry in the foreach.


            // Use foreach to iterate through key-value pairs
            //foreach (KeyValuePair<string, int> pair in dict)
            //{
            //    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            //}


            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(3, "Sharad");
            dc.Add(1, "Viraj");
            dc.Add(2, "Vilas");
            dc.Add(7, "Rajesh");
            dc.Add(5, "Shubham");
            dc.Add(9, "Satish");

            //Console.WriteLine(dc.Count);
            //Console.WriteLine(dc.ContainsKey(1));
            //Console.WriteLine(dc.ContainsValue("Sharad"));
            //Console.WriteLine();
            //dc.Clear();

            foreach (KeyValuePair<int, string> item in dc)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }



        }
    }
}
