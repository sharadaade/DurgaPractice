using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Durga
{
    class Branch
    {
        public int Bid { get; set; }
        public string Bname { get; set; }

        public void GetBdata()
        {
            Console.Write("Enter Branch ID : ");
            this.Bid = int.Parse(Console.ReadLine());

            Console.Write("Enter Branch Name : ");
            this.Bname = Console.ReadLine();
        }
        public void ShowBdata()
        {
            Console.WriteLine("Branch ID : " + this.Bid);
            Console.WriteLine("Branch name : " + this.Bname);
        }
    }

    class Employee : Branch
    {
        public int Eid { get; set; }
        public int Age { get; set; }
        public string Ename { set; get; }
        public string Email { set; get; }
        

        public void GetEmpData()
        {
            Console.Write("Enter Employee ID : ");
            this.Eid = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Age : ");
            this.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee name : ");
            this.Ename = Console.ReadLine();

            Console.Write("Enter Employee email : ");
            this.Email = Console.ReadLine();
        }

        public void ShowEmpData()
        {
            Console.WriteLine("Employee ID : " + this.Eid);
            Console.WriteLine("Employee Age : " + this.Age);
            Console.WriteLine("Employee name : " + this.Ename);
            Console.WriteLine("Employee email : " + this.Email);
        }
    }
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            Employee ob = new Employee();
            ob.GetBdata();
            ob.GetEmpData();
            Console.WriteLine("---------------");
            ob.ShowBdata();
            ob.ShowEmpData();
        }
    }
}
