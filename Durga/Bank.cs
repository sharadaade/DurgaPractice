using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    class Branch1
    {
        int Bcode;
        string Bname;
        string Baddress;

        public void GetBData()
        {
            Console.Write("Enter BCode : ");
            this.Bcode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Bname : ");
            this.Bname = Console.ReadLine();

            Console.Write("Enter Baddress : ");
            this.Baddress = Console.ReadLine();
        }
        public void ShowBData()
        {
            Console.WriteLine("Bcode is " + this.Bcode);
            Console.WriteLine("Bname is " + this.Bname);
            Console.WriteLine("Baddress is " + this.Baddress);
        }
    }
    interface IEmployee
    {
        public void GetEmpData();
        public void ShowEmpData();
        
    }
    class Manage : Branch1, IEmployee
    {
        int Eid;
        string Ename;
        double CA, Bonus;

        public void GetEmpData()
        {
            Console.Write("Enter Eid : ");
            this.Eid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Ename : ");
            this.Ename = Console.ReadLine();

            Console.Write("Enter CA : ");
            this.CA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Bonus : ");
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void ShowEmpData()
        {
            Console.WriteLine("Emp id is " + this.Eid);
            Console.WriteLine("Emp name is " + this.Ename);
            Console.WriteLine("Emp CA is " + this.CA);
            Console.WriteLine("Emp Bonus is " + this.Bonus);
        }
    }
    internal class Bank
    {
        static void Main(string[] args)
        {
            Manage m = new Manage();
            m.GetBData();
            m.GetEmpData();
            Console.WriteLine("--------------------");
            m.ShowBData();
            m.ShowEmpData();
        }
    }
}
