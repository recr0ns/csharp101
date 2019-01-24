// ABBYY Software House © 2019

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventProj
{
	/// <summary>
	/// The following example shows how to use AutoResetEvent to release one thread.
	/// In the Main method, we start a new thread by using Task Factory.
	/// It calls the GetDataFromServer method. After starting the method we put the
	/// main thread into wait state by calling WaitOne method on AutoResetEvent object.
	/// When from the GetDataFromServer method, we calls the Set method on
	/// AutoResetEvent object, it releases the main thread and print the
	/// dataFromServer into the console.
	/// </summary>
	public class Example1
	{
		private static readonly AutoResetEvent autoResetEvent = new AutoResetEvent(false);
		private static string Data = null;

		public static void Run()
		{
			Data = null;
			autoResetEvent.Reset();
			Task.Factory.StartNew(RetriveData);
			var status = autoResetEvent.WaitOne();
			Console.WriteLine(status);
			Console.WriteLine($"Data: {Data}");
		}

		private static void RetriveData()
		{
			Console.Write("Retriving data from server");
			Enumerable.Range(0, 3).Select(i =>
			{
				Thread.Sleep(1_000);
				Console.Write(".");
				return i;
			}).ToArray();
			Console.WriteLine();

			Data = Guid.NewGuid().ToString("N").ToUpper();
			Console.WriteLine("Data was retrived from server!");
			autoResetEvent.Set();
		}
	}
}