// ABBYY Software House © 2019

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventProj
{
	public class Example3
	{
		private static readonly AutoResetEvent auto = new AutoResetEvent(false);
		private const int SLEEP = 1000;

		public static void Run()
		{
			var tasks = Enumerable.Range(1, 5)
				.Select(index => Task.Factory.StartNew(() => ConcurrentTask(index)))
				.ToArray();

			Console.WriteLine("Start");
			Thread.Sleep(SLEEP);
			auto.Set();
			Task.WaitAll(tasks);
			auto.Reset();
			Console.WriteLine("Done!");
		}

		public static void ConcurrentTask(int n)
		{
			auto.WaitOne();
			Console.WriteLine($"Task {n}");
			Thread.Sleep(SLEEP);
			auto.Set();
		}
	}
}