using System;
using System.Diagnostics.Contracts;

namespace ContractTest
{
	class C
	{
		public static void OutputPositiveInt(int i)
		{
			Contract.Requires(i >= 0);
			Console.WriteLine(i);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			C.OutputPositiveInt(-23);
		}
	}
}
