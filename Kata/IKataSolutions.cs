using System.Collections.Generic;

namespace Kata
{
	public interface IKataSolutions
	{
		bool ValidParentheses(string input);
		List<int> SqInRect(int lng, int wdth);
		string Tickets(int[] peopleInLine);
	}
}