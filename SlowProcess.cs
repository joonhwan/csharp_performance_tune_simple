using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PerformanceTune
{
    //public class GdsRegion
    //{
    //    public GdsRegion()
    //    {
    //        Codes = new List<string>();
    //        RegionPoints = new List<Point>();
    //    }
    //    public List<string> Codes { get; set; }
    //    public List<Point> RegionPoints { get; set; }
    //}

    //public class RandomCodeGenerator
    //{
    //    private Random _random;
    //    private List<string> _list;

    //    public RandomCodeGenerator()
    //    {
    //        _random = new Random();
    //        _list = new List<string>();
    //        for (var i = 0; i < 10000; ++i)
    //        {
    //            _list.Add(i.ToString("000000"));
    //        }
    //    }

    //    public string NextRandom => _list[_random.Next(0, 10000)];
    //}
    
    public class SlowProcess
    {
        private RandomPointGenerator _randomPointGenerator;

        public SlowProcess(RandomPointGenerator randomPointGenerator)
        {
            _randomPointGenerator = randomPointGenerator;
            UniquePoints = new List<Point>();
        }

        public List<Point> UniquePoints { get; set; }

        public void Do(int repeat = 1000_000)
        {
            for (int i = 0; i < repeat; ++i)
            {   
                for (int iteration = 0; iteration < 1_000; ++iteration)
                {
                    var point = _randomPointGenerator.NextRandom;
                    if (!UniquePoints.Contains(point))
                    {
                        UniquePoints.Add(point);
                    }
                }
            }
        }
    }
}