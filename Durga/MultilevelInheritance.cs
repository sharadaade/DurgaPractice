using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    class CompanyBranch
    {
        public int CBid { get; set; }
        public string CBname { get; set; }
        public string CBaddress { get; set; }

        public void GetCBdata()
        {
            Console.Write("Enter Commpany Branch ID : ");
            this.CBid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Commpany Branch Name : ");
            this.CBname = Console.ReadLine();

            Console.Write("Enter Commpany Address : ");
            this.CBaddress = Console.ReadLine();
        }

        public void ShowCBdata()
        {
            Console.WriteLine("Commpany Branch ID : " + this.CBid);
            Console.WriteLine("Commpany Branch Name : " + this.CBname);
            Console.WriteLine("Commpany Branch Addess : " + this.CBaddress);
        }
    }
    class CompanyEmployee : CompanyBranch
    {
        public int EMpid { get; set; }
        public int EMAge { get; set; }
        public string EMName { get; set; }
        public string EMemail { get; set; }
        public string EMaddress { get; set; }

        public void GetEmpData()
        {
            Console.Write("Enter Emp id : ");
            this.EMpid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Emp Age : ");
            this.EMAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Emp Name : ");
            this.EMName = Console.ReadLine();

            Console.Write("Enter Emp Email : ");
            this.EMemail = Console.ReadLine();

            Console.Write("Enter Emp Addess : ");
            this.EMaddress = Console.ReadLine();
        }

        public void ShowEmpData()
        {
            Console.WriteLine("Emp id is : " + this.EMpid);
            Console.WriteLine("Emp Age is : " + this.EMAge);
            Console.WriteLine("Emp Name is : " + this.EMName);
            Console.WriteLine("Emp Email is : " + this.EMemail);
            Console.WriteLine("Emp Address is : " + this.EMaddress);
        }
    }

    class EmpCalSalary : CompanyEmployee
    {
        public double Basic { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double Gross { get; set; }

        public void GetSal()
        {
            Console.Write("Enter Basic salary : ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateSal()
        {
            this.DA = this.Basic * 0.04;
            this.HRA = this.Basic * 0.6;

            this.Gross = this.Basic + this.DA + this.HRA;
        }
        public void ShowSalary()
        {
            Console.WriteLine("Employee salary is : " + this.Gross);
        }
    }
    internal class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            EmpCalSalary ob = new EmpCalSalary();
            ob.GetCBdata();
            ob.GetEmpData();
            ob.GetSal();
            ob.CalculateSal();
            Console.WriteLine("----------------------------");
            ob.ShowCBdata();
            ob.ShowEmpData();
            ob.ShowSalary();
        }
    }
}
