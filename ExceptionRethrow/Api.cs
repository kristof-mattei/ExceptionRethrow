namespace ExceptionRethrow
{
	using System;
	using System.Linq;

	public class Api
	{
		public string Find(string toFind)
		{
			try
			{
				// force a InvalidOperationException
				return (new string[] { }).Single(e => e == toFind);
			}
			catch (InvalidOperationException e)
			{
				Logger.Log(string.Format("Tried to look for element {0}, not found", toFind));

				// most info
				throw new InvalidOperationException(e.Message, e);
				// only half the info
				throw e;
				// no info
				throw;
			}
		}
	}

	public class Logger
	{
		public static void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}