using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Autofac;

namespace Kata
{
	class Program
	{
		private readonly IKataSolutions _kataSolutions;
		public Program(IKataSolutions kataSolutions)
		{
			this._kataSolutions = kataSolutions;
			
		}

		private void Run()
		{
			var result = _kataSolutions.SqInRect(5, 3);
			Console.Write('{');
			result.ForEach(x=>Console.Write(x + ","));
			Console.WriteLine('}');
			
			result = _kataSolutions.SqInRect(90, 5);
			Console.Write('{');
			result?.ForEach(x => Console.Write(x + ","));
			Console.Write('}');

			//int[]  peopleInLine = new[] { 25, 50,50, 100 };
			//Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			//peopleInLine = new[] { 25, 50, 50, 100,100 };
			//Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			//peopleInLine = new[] { 25, 50, 50, 100,50,25 };
			//Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			//Console.WriteLine(_kataSolutions.GetSum(0,4));
			//Console.WriteLine(_kataSolutions.Solution("MDCLXVI"));
			int[] arr = { 34, 15, 88, 2 };
			//Console.WriteLine(_kataSolutions.FindShort("bitcoin take over the world maybe who knows perhaps"));
			//_kataSolutions.AlphabetPosition("The sunset sets at twelve o' clock.");
			//Console.WriteLine(_kataSolutions.PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
			//Console.WriteLine(_kataSolutions.PrinterError("aaabbbbhaijjjm"));
			Console.ReadLine();
		}

		public static void Main(string[] args)
			{
			var container = Container.ConfigureContainer();
			var program = container.Resolve<Program>();
				program.Run();



		}
	}
}
