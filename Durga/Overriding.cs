using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class Employ
    {
        protected int eid;
        protected string? ename;
        string? eaddress;
        int eage;

        public virtual void GetEmpData()
        {
            Console.Write("Enter emp id : ");
            this.eid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter emp name : ");
            this.ename = Console.ReadLine();

            Console.Write("Enter emp addess : ");
            this.eaddress = Console.ReadLine();

            Console.Write("Enter emp age : ");
            this.eage = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void ShowEmpData()
        {
            Console.WriteLine("Emp id is " + this.eid);
            Console.WriteLine("Emp name is " + this.ename);
            Console.WriteLine("Emp address is " + this.eaddress);
            Console.WriteLine("Emp age is " + this.eage);
        }
        
    }
    internal class Manager : Employ
    {
        private double CA, bonus;
        public override void GetEmpData()
        {
            base.GetEmpData();

            Console.Write("Enter Manager id : ");
            this.eid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Manager name : ");
            this.ename = Console.ReadLine();

            Console.Write("Enter Manager CA : ");
            this.CA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Manager bonus : ");
            this.bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override void ShowEmpData()
        {
            base.ShowEmpData();
            Console.WriteLine("Manager id is " + this.eid);
            Console.WriteLine("Manager name is " + this.ename);
            Console.WriteLine("Managermp CA is " + this.CA);
            Console.WriteLine("Manager bonus is " + this.bonus);
        }
    }
    internal class Overriding
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager();
            obj.GetEmpData();
            Console.WriteLine("------------------------------");
            obj.ShowEmpData();
        }
    }
}
