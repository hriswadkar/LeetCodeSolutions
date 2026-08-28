using System.Data;

public class RomanToInteger
{

	public static void Main(string[] args)
	{
		RomanToInteger romanToInteger = new RomanToInteger();
		int result = romanToInteger.RomanToInt("MCMIVVIIIIIIVV");
		Console.WriteLine(result);
	}
	
	public int RomanToInt(string str)
	{
		Dictionary<Char, int> values = new Dictionary<char, int>();

		values.Add('I', 1);
		values.Add('V', 5);
		values.Add('X', 10);
		values.Add('L', 50);
		values.Add('C', 100);
		values.Add('D', 500);
		values.Add('M', 1000);

		int result = 0;

		for (int i = 0; i < str.Length; i++)
		{
			int current = values[str[i]];

			if (i + 1 < str.Length)
			{
				int next = values[str[i + 1]];

				if (current < next)
				{
					result -= current;
				}
				else
				{
					result += current;
				}
			}
			else
			{
				result += current;
			}
		}

		return result;
	}
}