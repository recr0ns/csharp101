using System;

namespace AutoResetEventProj
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Example3.Run();
			}
			while (Console.ReadKey().Key != ConsoleKey.Enter);
		}
	}
}
