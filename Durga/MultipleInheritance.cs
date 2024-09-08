using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class MultipleInheritance
    {

    }
    internal interface MultipleInheritance1
    {

    }

    // When we are inheriting the class name first and then interface name
    internal class Child : MultipleInheritance, MultipleInheritance1
    {
        
    }
}
