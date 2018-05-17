using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    int strLength = str.Length;
    int distinctCharCount = String.Concat(str.OrderBy(c => c)).ToLower().Distinct().Count();
    if( strLength != distinctCharCount)
    {
      return false;
    }
    return true;
  }
}
