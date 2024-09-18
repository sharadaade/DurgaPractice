using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class StringVsStringBuilder
    {
        static void Main(string[] args)
        {
            // string class ->System namespace
            // StringBuilder -> System.Text

            // string:-
            // => is immutable
            // => Memory usage is high in string


            // StringBuilder:-
            // => is mutable
            // => StringBuilder is much faster than string
            // => Memery usage is low as compared to string

            //string s = "Hello";
            //s += "Sharad";
            //s += "Aade";

            //Console.WriteLine(s);

            //Console.WriteLine(s.GetHashCode());

            string s1 = "Sharad";
            string s2 = "Aade";

            //Console.WriteLine(s1 + " " + s1);
            //Console.WriteLine(s1.Replace("Sharad","JJ"));

            //--------------------------------------------------------

            StringBuilder st = new StringBuilder("Hello");

            //st.Append(" Sharad");
            //st.Append(" How are you!");

            //Console.WriteLine(st);

            st.Replace("Hello","HHH");
            Console.WriteLine(st);

            
        }
    }
}
