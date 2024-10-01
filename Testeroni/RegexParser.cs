namespace Testeroni;

public class RegexParser
{
  public static bool IsRangeQuantifier(string toCheck)
  { 
    if (toCheck.First() != '{')
      return false;



    return true;

  }

  public static bool IsString(char prefix, string toCheck, out string substring)
  {
    if (toCheck[0] == prefix)
    {
      substring = toCheck[1..];
      return true;
    }
    substring = toCheck;
    return false;
  }

  public static bool IsNumber(string toCheck, out int number, out string substring)
  {
    substring = toCheck;
    number = 0;
    var ints = new List<int>();
    int i = 0;
    for (; i < toCheck.Length; i++)
    {
      char character = toCheck[i];
      if (character < '0' || character > '9')
      {

        break;
      }

      ints.Add(character - '0');
    }
    substring = toCheck[i..];

    if (ints.Count == 0)
      return false;

    var x = 1;
    number = ints.Reverse<int>().Aggregate((a, b) => a + b * (int)Math.Pow(10, x++));

    return true;
  }
}
