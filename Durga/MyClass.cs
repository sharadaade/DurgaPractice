using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface contain all abstract method
// Donot contain non-abstract method
namespace Durga
{
    internal interface IFace
    {
        public abstract void Wood();
        public abstract void Steel();
    }
    class Table : IFace
    {
        public void Wood()
        {
            Console.WriteLine("Wood Table");
        }
        public void Steel()
        {
            Console.WriteLine("Steel table");
        }
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            Table t = new Table();
            t.Wood();
            t.Steel();
        }
    }
}
