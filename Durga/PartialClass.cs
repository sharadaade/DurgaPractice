using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Code can split or divide into multiple parts is called partial class
namespace Durga
{
    partial class Banking
    {
        private int a;
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }

    partial class Banking
    {
       
        public void Dispaly()
        {
            a = 100;
            Console.WriteLine("Display");
        }
    }
    class Zero : Banking
    {
        public void MyMethod()
        {
            Console.WriteLine("CoreJJ");
        }
    }
    internal class PartialClass
    {
        static void Main(string[] args)
        {
            //Banking b = new Banking();
            //b.Show();
            //b.Dispaly();
            Zero z = new Zero();
            z.Show();
            z.Dispaly();
            z.MyMethod();
        }
    }
}
