using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
	public class KataSolutions : IKataSolutions
	{
		public bool ValidParentheses(string input)
		{
			if (input.Length == 0 || input.Length % 2 != 0 || input[0] == ')') return false;

			var parentheses = new Dictionary<string, int>();

			foreach (var p in input)
			{
				
			}
			return false;
		}

		public List<int> SqInRect(int lng, int wdth)
		{
			if (lng == wdth) return null;
			var smallSide = lng > wdth ? wdth : lng;
			var largeSide = lng < wdth ? wdth : lng;
			var result = new List<int>();
			while (smallSide > 0 && largeSide > 0)
			{
				result.Add(smallSide);
				largeSide -= smallSide;

				if (smallSide > largeSide)
				{
					var aux = smallSide;
					smallSide = largeSide;
					largeSide = aux;
				}

			}
			return result;
		}
		public string Tickets(int[] peopleInLine)
		{
			var twentyFive = 0;
			var fifty = 0;

			foreach (var line in peopleInLine)
			{
				if (twentyFive == 0 && line > 25)
					return "NO";

				switch (line)
				{
					case 25:
						twentyFive += 25;
						break;
					case 50:
						if (twentyFive - 25 < 0)
							return "NO";
						fifty += 50;
						twentyFive -= 25;
						break;
					default:
						if (fifty - 50 < 0 || twentyFive - 25 < 0)
							return "NO";
						twentyFive -= 25;
						fifty -= 50;
						break;
				}
			}

			return "YES";
		}
		public int Solution(string roman)
		{
			var romanNumbers = new Dictionary<char, int>
			{
				{'I', 1 },
				{'V',5 },
				{'X',10 },
				{'L',50 },
				{'C',100 },
				{'D',500 },
				{'M',1000}
			};

			int sum = 0;
			int previosNum = 0;

			for (int i = roman.Length - 1; i >= 0; i--)
			{
				if (romanNumbers.TryGetValue(roman[i], out int value))
				{
					if (value < previosNum)
						sum -= value;
					else
						sum += value;
				}
				previosNum = value;
			}
			return sum;
		}

		public int GetSum(int a, int b)
		{
			if (a == b)
				return a;

			int higher;
			int less;
			if (a > b)
			{
				higher = a;
				less = b;
			}
			else
			{
				higher = b;
				less = a;
			}

			int sum = higher;

			for (; less < higher; less++)
			{
				sum += less;
			}
			return sum;
		}

		public int FindShort(string s)
		{

			var wordarray = s.Split(' ');
			int count = wordarray[0].Length;
			foreach (string word in wordarray)
			{
				if (word.Length < count) count = word.Length;
			}
			return count;
		}

		public int FindSmallestInt(int[] args)
		{
			int aux = args[0];
			foreach (var num in args)
			{
				if (num < aux) aux = num;
			}
			return aux;
		}
		public int PositiveSum(int[] arr)
		{
			if (arr.Length > 0)
			{
				return arr.Where(x => x > 0).Sum();
			}
			return 0;
		}
		public string AlphabetPosition(string text)
		{
			string result = String.Empty;
			var cleantext = Regex.Matches(text.ToLower(), @"[^a-z]").Count != text.Length ? Regex.Replace(text.ToLower(), @"[^a-z]", "") : text.ToLower();
			foreach (var chart in cleantext)
			{
				result += ((int)chart - 96) + " ";
			}
			return result.Trim();
		}
		public string PrinterError(String s)
		{
			var regex = Regex.Matches(s, @"[^n-z]");
			var result = (s.Length - regex.Count) + "/" + s.Length.ToString();

			return result;
		}
		public string Remove_char(string s)
		{
			//s.Substring(1, (s.Length - 2))
			var test = s.Substring(1);
			test = test.Substring(0, test.Length - 1);

			return test;
		}

	}
}
