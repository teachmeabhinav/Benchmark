using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LibToBenchmark;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BenchmarkingLib
{
    //[CoreJob]
    [MemoryDiagnoser]
	//[DisassemblyDiagnoser(printAsm: true, printSource: true, printIL: true)]
	public class Program
	{
		static List<HistoricalValue> HisticalPrices;

		static Program()
		{
			HistoricalPriceReader reader = new HistoricalPriceReader();
			HisticalPrices = reader.GetHistoricalQuotes("MSFT").ToList();
		}
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public  void CalculateWithLinq()
		{
			var linqres = SimpleMovingAverage.CalculateSMALinq(HisticalPrices, 14);
			Debug.WriteLine(linqres.Count);
		}

		[Benchmark]
		public  void CalculateWithNonLinq()
		{
			var res = SimpleMovingAverage.CalculateSMA(HisticalPrices, 14);
			Debug.WriteLine(res.Count);
		}
	}
}