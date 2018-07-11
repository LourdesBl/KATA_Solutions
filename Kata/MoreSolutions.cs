using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
	public class MoreSolutions : IMoreSolutions
	{
		public string ConvertCharToNumber(int adid, string id)
		{
			var letters = id.Substring(adid.ToString().Length).ToCharArray();
			string charToNumber = string.Empty;
			int numberFromchar = 0;
			var bytes = Encoding.ASCII.GetBytes(letters);
			var lettersCount = 0;
			numberFromchar = (int.Parse(bytes[letters.Length - 1].ToString()) - 64);
			while (lettersCount < letters.Length - 1)
			{
				numberFromchar = numberFromchar + (((lettersCount + 1) * 26) * (int.Parse(bytes[lettersCount].ToString()) - 64));
				lettersCount++;
			}
			//foreach (var b in bytes)
			//{
			//	charToNumber = charToNumber + (26 * lettersCount--) + (int.Parse(b.ToString()) - 64);
			//	numberFromchar = (26 * (letters.Length - 1)) + (int.Parse(b.ToString()) - 64);
			//}

			//for (int i = 0; i < bytes.Length; i++)
			//{
			//	if (i == bytes.Length - 1)
			//	{
			//		numberFromchar = numberFromchar + (int.Parse(bytes[i].ToString()) - 64);
			//	}
			//	else
			//	{
			//		numberFromchar = numberFromchar +((int.Parse(bytes[i].ToString()) - 64) * 26);
			//	}
			//}



			return adid + numberFromchar.ToString();
			//if (Row.Adid.ToString() != Row.Id)
			//{
			//var letters = Row.Id.Substring(Row.Adid.ToString().Length).ToCharArray();

			//}
			//else
			//{
			//Row.NumberedId = Row.Id;
			//}
		}
	}
}
