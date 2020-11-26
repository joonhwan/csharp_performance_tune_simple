using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTune
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomPointGenerator = new RandomPointGenerator();

            var process = new SlowProcess(randomPointGenerator);
            //var process = new FastProcess(randomPointGenerator);
            TimeIt.For(() => { process.Do(50); });
        }
    }
}
