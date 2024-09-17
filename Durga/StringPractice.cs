using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class StringPractice
    {
        static void Main(string[] args)
        {
            string s = "Welcome Gentalman";
            //Console.WriteLine(s);

            //Console.WriteLine(s.Length);
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.ToLower());

            string s2 = "         Sharad      ";

            //Console.WriteLine(s2.Trim());
            //Console.WriteLine(s2.TrimStart());
            //Console.WriteLine(s2.TrimEnd());

            //Console.WriteLine(s.Equals(s2));

            string ss = "Fall";

            //Console.WriteLine(ss.StartsWith('F'));
            //Console.WriteLine(ss.EndsWith("d"));

            //Console.WriteLine(ss.Insert(3,"Z"));

            string s3 = "Welcome in the world of Chemistry";
            //Console.WriteLine(s3.Replace("Chemistry","IT"));

            //Console.WriteLine(s3);

            // Remove --> it remove the string from 9 index => 9th index is included to remove
            //Console.WriteLine(s3.Remove(9));

            // Remove With two parameter
            // 8 is the number of index and 3 is the no of index
            //Console.WriteLine(s3.Remove(8, 3));

            string s4 = "MyNameIsSharad";
            //Console.WriteLine(s4.Substring(2));
            //Console.WriteLine(s4.Substring(6,8)); // 6 is index and 8  is number of character

            string s5 = "c sharp is a programming language";
            //Console.WriteLine(s5);

            //string[] s6 = s5.Split("-");

            //foreach (string item in s6)
            //{
            //    Console.WriteLine(s6);
            //}


            Console.WriteLine(s5.IndexOf("m"));
            Console.WriteLine(s5.IndexOf("is"));


        }
    }
}
