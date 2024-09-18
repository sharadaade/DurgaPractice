using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class NonGenericQueueCollection
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add('A');
            al.Add('B');
            al.Add('C');

            // Queue : (FIFO) First In First Out
            // Enqueue : It is used to add the element at the end of the queue
            // Dequeue : It is used to remove the element from the start of the queue
            // In Non-Generic Collection We can store different types of data

            Queue q = new Queue();

            // Enqueue() method is used to add element in queue
            q.Enqueue(10);
            q.Enqueue("Sharad");
            q.Enqueue("Nano");
            q.Enqueue(null);
            q.Enqueue("Raj");
            q.Enqueue(22.24);
            q.Enqueue('M');

            // Passing ArrayList in Queue
            q.Enqueue(al);



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


            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
