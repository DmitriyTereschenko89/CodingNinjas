namespace Program_to_check_the_validity_of_a_Password
{
	public class Solution
	{
		public bool IsValid(string str)
		{
			if (str.Length < 8 || str.Length > 15)
			{
				return false;
			}
			HashSet<char> symbolSets = [
				'\\', '!','@','#','$','%','^','&','*','(',')','_','+','=',	'{','}','[',']','|',':',';','<','>',',','.','?','/','~','`','"', '\''
				];
			bool isDigit = false;
			bool isLetterUpper = false;
			bool isLetterLower = false;
			bool isSpecialSymbol = false;
			foreach (char ch in str)
			{
				if (ch >= '0' && ch <= '9')
				{
					isDigit = true;
				}
				else if (ch >= 'a' && ch <= 'z')
				{
					isLetterLower = true;
				}
				else if (ch >= 'A' && ch <= 'Z')
				{
					isLetterUpper = true;
				}
				else if (symbolSets.Contains(ch))
				{
					isSpecialSymbol = true;
				}
				else
				{
					return false;
				}
			}
			return isDigit && isLetterUpper && isLetterLower && isSpecialSymbol;
		}
	}
}
