namespace ExceptionRethrow
{
	using System;

	internal class Program
	{
		private static void Main()
		{
			try
			{
				var result = (new Api()).Find("foo");

				Process(result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
				Console.Read();
			}
		}

		private static void Process(string result)
		{
			//...
		}
	}
}