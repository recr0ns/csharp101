// ABBYY Software House © 2019

using System;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventProj
{
	public class Example2
	{
		private static readonly AutoResetEvent event1 = new AutoResetEvent(false);
		private static readonly AutoResetEvent event2 = new AutoResetEvent(false);

		public static void Run()
		{
			var t1 = Task.Factory.StartNew(PrintOdd);
			var t2 = Task.Factory.StartNew(PrintEven);

			Task.WaitAll(t1, t2);
			Console.WriteLine();
			Console.WriteLine("Done!");
		}

		private static void PrintOdd()
		{
			int[] oddNumbers = { 1, 3, 5, 7, 9 };
			foreach (var number in oddNumbers)
			{
				Print(number);
				event2.Set();
				event1.WaitOne();
			}
		}

		private static void PrintEven()
		{
			int[] evenNumbers = { 2, 4, 6, 8, 10 };
			foreach (var number in evenNumbers)
			{
				event2.WaitOne();
				Print(number);
				event1.Set();
			}
		}

		private static void Print(int n) => Console.Write($"{n} ");
	}
}