using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// using BenchmarkDotNet.Running;
// var _ = BenchmarkRunner.Run<StringBenchmark>();


[SimpleJob]
[RPlotExporter]
[MemoryDiagnoser]
public class StringBenchmark
{

        [GlobalSetup]
        public void Setup()
        {

        }

        [Benchmark]
        public void RegularString() 
        {
            string s = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                s += i.ToString() + " ";
            }
        }


        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
                sb.Append(' ');
            }
        }
    }
