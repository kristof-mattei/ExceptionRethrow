using System;

namespace ConsoleApplication20
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				Foo();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
				Console.Read();
			}
		}

		private static void Foo()
		{
			try
			{
				Bar();
			}
			catch (Exception e)
			{
				// handle exception
				// ...
				// ...

				throw e;
			}
		}

		private static void Bar()
		{
			throw new Exception("There is a glitch in the matrix");
		}
	}
}