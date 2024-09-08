using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    class AA
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int x, int y,int z)
        {
            Console.WriteLine(x + y + z);
        }

    }
    internal class Ovzerloading : AA
    {
        static void Main(string[] args)
        {
            AA a = new AA();
            a.Add(1, 3);
            a.Add(1, 2, 3);
        }
    }
}
