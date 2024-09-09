using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//1.Enum stands for enumeration.
//2.enum is a special class that represent a group of constants(not changeble/Read only)
//3.to create enum we use enum keyword and separate the enum values by using comma.
//4.use enums when we have values that you know are not going to change, like month, days, colors.
//5.enum can be used in any prg language to define a set of constant values.
//6.enums consumes less memory space because enums are value-type and that allocated on stack.
//7.enums are represented as string but processed as an integer.
//8.the default enumeration type is int.

namespace Durga
{
    internal class Enumration
    {
        //enum Level
        //{
        //    low,
        //    medium,
        //    high
        //}

        enum Days
        {
            sunday,
            monday,
            tuesday,
            wensday,
            thursaday,
            friday,
            saturday
        }
        static void Main(string[] args)
        {
            //Level l = Level.high;
            //Console.WriteLine("The level is " + l);

            //Days d = Days.sunday;
            // Access like index
            int index = (int)Days.sunday;
            Console.WriteLine(index);
        }
    }
}
