using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A method which do not cotain any implementation, which contain only declaration is called abstract method.
// Abstract class contain non-abstract method
// We can not instantiate or create object of abstract class
// Cannot create object for interface
// It is used for impelement multiple inheritance

namespace Durga
{
    abstract class Weeler
    {
        //public Weeler()
        //{

        //}
        public abstract void M1();
        public void Color()
        {
            Console.WriteLine("Ok");
        }
    }
    class Bike : Weeler
    {
        public override void M1()
        {
            Console.WriteLine("2 - weel");
        }

    }
    class Car : Weeler
    {
        public override void M1()
        {
            Console.WriteLine("4 - weel");
        }
    }
    internal class AbstractMethod
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            b.M1();
            

            Car c = new Car();
            c.M1();
            

            //Weeler w = new Weeler(); --> Cannot create instance of abstract class
        }
    }
}
