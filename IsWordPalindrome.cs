using System;

class Program
{
  public static bool IsPalindrome(string value)
  {
    int min = 0;
    int max = value.length - 1;
    while (true)
    {
      if (min > max) { return true; }
    
      char x = value[min];
      char y = value[max];
      if (char.ToLower(x) != char.ToLower(y)) { return false; }
      
      min++;
      max--;
  
    }
  }

  static void Main() 
  {
    string[] array = 
    {
      "civic",
      "deified",
      "deleveled",
      "devoved",
      "dewed",
      "Hannah",
      "kayak",
      "level",
      "madam",
      "racecar",
      "radar",
      "redder",
      "refer",
      "repaper",
      "reviver",
      "rotator",
      "rotor",
      "sagas",
      "solos",
      "sexes",
      "stats",
      "tenet",
      
      "Dot",
      "Net",
      "Perls",
      "Is",
      "Not",
      "A",
      "Palindrome",
      ""
    };
    
    foreach (string value in array) 
    {
      Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
    }
  }
}
