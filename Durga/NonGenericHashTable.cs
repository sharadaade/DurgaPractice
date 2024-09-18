using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class NonGenericHashTable
    {
        static void Main(string[] args)
        {
            // Hashtable:
            // Hashtable is a collection that stores key-value pairs
            // Internally for every hashkey unique hashcode are assigned
            // The keys in a Hashtable are unique, and the values can be accessed using the corresponding key.
            // The values can be accessed using the corresponding key.
            // Hashtable stores objects, so boxing and unboxing might occur when storing value types.
            // For better performance and type safety, Dictionary<TKey, TValue> (generic version) is often preferred.

            //Key Differences foreach loop:-
            //For Dictionary, you use KeyValuePair<TKey, TValue> in the foreach.
            //For Hashtable, you use DictionaryEntry in the foreach.


            // Use foreach to iterate through key-value pairs
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}


            Hashtable ht = new Hashtable();

            ht.Add("key1", 123);
            ht.Add("key2", 456);
            ht.Add("key3", 789);
            ht.Add("key4", 987);
            ht.Add(999, "lll");
            // Key can not be duplicate or null 
            //ht.Add("key4", 555);

            // 
            Console.WriteLine(ht.ContainsKey(999));
            Console.WriteLine(ht.ContainsValue(654));

            // Clear() => It remove the all element/object from Hashtable


            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
