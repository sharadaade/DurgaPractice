using System.Collections;

namespace Durga
{
    internal class NonGenericStackCollection
    {
        static void Main(string[] args)
        {
            // Stack use the LIFO (Last In Last Out)

            Stack st = new Stack();

            st.Push(50);
            st.Push("Sharad");
            st.Push(11.5);
            st.Push(20);
            st.Push("M");
            st.Push(99);

            // Display the no of element 
            Console.WriteLine(st.Count);

            // Peek Method return the top element withoout removing
            Console.WriteLine(st.Peek());

            // Pop() methood is used to remove top element and return element(object)
            Console.WriteLine(st.Pop());

            Console.WriteLine("-----------------------------");

            // It return True if onject is available else return False
            Console.WriteLine(st.Contains("Sharad"));
            


            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

        }
    }
}
