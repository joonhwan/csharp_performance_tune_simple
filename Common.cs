using System;
using System.Diagnostics;
using System.Drawing;

namespace PerformanceTune
{
    public class RandomPointGenerator
    {
        private Random _random;

        public RandomPointGenerator()
        {
            _random = new Random(1971);
        }

        public Point NextRandom => new Point(_random.Next(0, 1000), _random.Next(0, 1000));
    }
    
    public class TimeIt
    {
        public static void For(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            try
            {
                action?.Invoke();
                sw.Stop();
                Console.WriteLine("Measured : {0}", sw.Elapsed);
            }
            catch (Exception e)
            {
                sw.Stop();
                Console.WriteLine("Measured(Exception!) : {0}", sw.Elapsed);
            }
        }
    }
}