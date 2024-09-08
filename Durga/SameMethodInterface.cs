using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    interface Interface1
    {
        public void m1();
    }
    interface Interface2
    {
        public void m1();
    }
    class C : Interface1, Interface2
    {
        void Interface1.m1()
        {
            Console.WriteLine("M1 for Interface1");
        }
        void Interface2.m1()
        {
            Console.WriteLine("M1 for Interface2");
        }
    }
    internal class SameMethodInterface
    {
        static void Main(string[] args)
        {
            C obj = new C();

            Interface1 i1 = obj;
            Interface2 i2 = obj;

            i1.m1();
            i2.m1();

        }
    }
}
