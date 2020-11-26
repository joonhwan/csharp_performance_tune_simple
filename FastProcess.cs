using System.Collections.Generic;
using System.Drawing;

namespace PerformanceTune
{
    public class FastProcess
    {
        private RandomPointGenerator _randomPointGenerator;

        public FastProcess(RandomPointGenerator randomPointGenerator)
        {
            _randomPointGenerator = randomPointGenerator;
            UniquePoints = new HashSet<Point>();
        }

        public HashSet<Point> UniquePoints { get; set; }

        public void Do(int repeat = 1000_000)
        {
            for (int i = 0; i < repeat; ++i)
            {   
                for (int iteration = 0; iteration < 1_000; ++iteration)
                {
                    var point = _randomPointGenerator.NextRandom;
                    //if (!UniquePoints.Contains(point))
                    //{
                    //    UniquePoints.Add(point);
                    //}
                    UniquePoints.Add(point);
                }
            }
        }
    }
}