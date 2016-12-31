using System;

class Rethrow
{
	public static void GenException()
	{
		var numb = new int[8];
		int[] denom = { 2, 0, 4, 4, 0, 8 };
		for (int i = 2; i < 10; i++)
		{
			numb[i - 2] = (int)Math.Pow(2.0, i);
		}
		for (int i = 0; i < numb.Length; i++)
		{
			try
			{
				Console.WriteLine(numb[i] + " / " + denom[i] + " is\t" + numb[i] / denom[i]);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("dev by zero");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("out index");
				throw;	//例外を再度投げる
			}
		}
	}
}
class Program
{
	static void Main()
	{
		try
		{
			Rethrow.GenException();
		}
		catch (IndexOutOfRangeException)
		{
			Console.WriteLine("Exception");
		}
	}
}