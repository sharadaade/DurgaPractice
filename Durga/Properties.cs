using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Properties are member of the class
// Properties are used to write the data into datafield and read the data from datafield
// Propoerties will never store the data within but trancefer the data 
// For reading and writing purpose properties will use two accessor or methods
// set acceesor => write the data 
// get acceesor => read the data
// Three types 1)read-only 2)write-only 3)read-write
// Note: - Propertyname and datafieldname should be different
//         Property datatype and datafield datatype should be same.

// Syntax:-
// access_modifieres datatype Propertyname
// {
//      set{datafieldname = value;}
//      get{return datafieldname;}
// }
//


namespace Durga
{
    class Properties
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public int PEmpid
        {
            set { Empid = value; }
            get { return Empid; }
        }
        public string PEname
        {
            set { Ename = value; }
            get { return Ename; }
        }
        public string PEaddress
        {
            set { Eaddress = value; }
            get { return Eaddress; }
        }
        public int PEage
        {
            set { Eage = value; }
            get { return Eage; }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
