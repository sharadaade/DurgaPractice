using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durga
{
    internal class StopwatchExample
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < 600000; i++)
            {
                
            }
            timer.Stop();
        }
    }
}
