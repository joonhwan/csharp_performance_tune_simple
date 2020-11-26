# Dot Trace 사용 DEMO 를 위한 샘플 프로젝트

```program.cs
static void Main(string[] args)
        {
            var randomPointGenerator = new RandomPointGenerator();

            //var process = new SlowProcess(randomPointGenerator);
            var process = new FastProcess(randomPointGenerator);
            TimeIt.For(() => { process.Do(50); });
        }
```

상기 부분에서  `SlowProcess` 는 `List<T>` 를 쓰는 경우, 이고, `FastProcess` 는 `HashSet<T>` 를 쓰는 경우 임. 


