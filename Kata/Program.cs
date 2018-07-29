using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Autofac;

namespace Kata
{
	class Program
	{
		private readonly IKataSolutions _kataSolutions;
		private readonly IMoreSolutions _moreSolutions;
		public Program(IKataSolutions kataSolutions, IMoreSolutions moreSolutions)
		{
			_kataSolutions = kataSolutions;
			_moreSolutions = moreSolutions;
		}

		private void Run()
		{
			int adid = 543347;
			var regex = Regex.Matches("543347AAB", @"([A-Z])");
			Console.WriteLine(int.Parse(regex.Count == 0 ? "543347AAB" : "543347AAB".Substring(0, "543347AAB".Length - regex.Count)));
			Console.WriteLine("543347A --" + _moreSolutions.ConvertCharToNumber(adid, "543347A"));
			Console.WriteLine("543347B --" + _moreSolutions.ConvertCharToNumber(adid, "543347B"));
			Console.WriteLine("543347C --" + _moreSolutions.ConvertCharToNumber(adid, "543347C"));
			//Console.WriteLine("543307AA --" + _moreSolutions.ConvertCharToNumber(adid, "543307AA"));
			//Console.WriteLine("543307AZ --" + _moreSolutions.ConvertCharToNumber(adid, "543307AZ"));
			//Console.WriteLine("543307BA --" + _moreSolutions.ConvertCharToNumber(adid, "543307BA"));
			//Console.WriteLine("543307BZ --" + _moreSolutions.ConvertCharToNumber(adid, "543307BZ"));
			//Console.WriteLine("543307AAA --" + _moreSolutions.ConvertCharToNumber(adid, "543307AAA"));
			//Console.WriteLine("543307AZA --" + _moreSolutions.ConvertCharToNumber(adid, "543307AZA"));
			//string id = Console.ReadLine();
			//while (!string.IsNullOrEmpty(id))
			//{
			//	Console.WriteLine(id + "--" + _moreSolutions.ConvertCharToNumber(adid, id));
			//	id = Console.ReadLine();
			//}

			//var result = _kataSolutions.SqInRect(5, 3);
			//Console.Write('{');
			//result.ForEach(x => Console.Write(x + ","));
			//Console.WriteLine('}');

			//result = _kataSolutions.SqInRect(90, 5);
			//Console.Write('{');
			//result?.ForEach(x => Console.Write(x + ","));
			//Console.Write('}');

			////int[]  peopleInLine = new[] { 25, 50,50, 100 };
			////Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			////peopleInLine = new[] { 25, 50, 50, 100,100 };
			////Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			////peopleInLine = new[] { 25, 50, 50, 100,50,25 };
			////Console.WriteLine(_kataSolutions.Tickets(peopleInLine));
			////Console.WriteLine(_kataSolutions.GetSum(0,4));
			////Console.WriteLine(_kataSolutions.Solution("MDCLXVI"));
			//int[] arr = { 34, 15, 88, 2 };
			////Console.WriteLine(_kataSolutions.FindShort("bitcoin take over the world maybe who knows perhaps"));
			////_kataSolutions.AlphabetPosition("The sunset sets at twelve o' clock.");
			////Console.WriteLine(_kataSolutions.PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
			////Console.WriteLine(_kataSolutions.PrinterError("aaabbbbhaijjjm"));
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
