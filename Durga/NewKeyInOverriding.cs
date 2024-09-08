using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    class OverParent
    {
        public void MyFun()
        {
            Console.WriteLine("MyFunction Parent");
        }
        public void Car()
        {
            Console.WriteLine("Parent Car");
        }
    }
    class OverChild : OverParent
    {
        // The new keyword is only used for intetionaly
        // adding same method in child class which is
        // already present in parent class

        // If we don't add new keyword child method shows warnnig
        public void Car()
        {
            Console.WriteLine("Child Car");
            //base.Car();
        }
    }
    internal class NewKeyInOverriding
    {
        static void Main(string[] args)
        {
            OverChild ob = new OverChild();
            ob.Car();

            //OverParent obj = new OverParent();
            //obj.Car();
        }
    }
}
