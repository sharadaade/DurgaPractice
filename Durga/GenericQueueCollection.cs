using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class GenericQueueCollection
    {
        static void Main(string[] args)
        {
            // Queue : (FIFO) First In First Out
            // Enqueue : It is used to add the element at the end of the queue
            // Dequeue : It is used to remove the element from the start of the queue
            // In Generic Collection We can store the Simillar types of data

            Queue<int> q = new Queue<int>();

            // Enqueue() method is used to add element in queue
            q.Enqueue(10);
            q.Enqueue(50);
            q.Enqueue(44);
            q.Enqueue('M');


            // Clear() it clear the all object/element from queue
            //q.Clear();

            // It Return the number count from queue 
            //Console.WriteLine(q.Count);

            // It remove the first element 
            //q.Dequeue();

            // Contains() => it return True if element contain otherwise return False
            //Console.WriteLine(q.Contains("Raj"));
            //Console.WriteLine(q.Contains(99));

            // Peek() => It give the Beginning  element without removing
            //Console.WriteLine(q.Peek());


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
