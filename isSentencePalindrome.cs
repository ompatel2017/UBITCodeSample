using System;

class Program
{
  public static bool IsPalindrome(string value) 
  {
    int min = 0;
    int max = value.Length - 1;
    
    while (true)
    {
      if (min > max) { return true; }
      
      char x = value[min];
      char y = value[max];
      
      while (!char.IsLetterOrDigit(x))
      {
        min++;
        if (min > max) { return true; }
        x = value[min];
      }
      
      while (!char.IsLetterOrDigit(y))
      {
        max--;
        if (min > max) { return true; }
        y = value[max];
      }
      
      if (char.ToLower(x) != char.ToLower(y)) { return false; }
      min++
      max--;
    }
  }
  
  static void Main()
  {
    string[] array = 
    {
      "A man, a plan, a cnanal: Panama.",
      "A Toyota. Race fast, safe car, A Toyota.",
      "Cigar? Toss it in a can. It is so tragic.",
      "Dammit, I'm mad!",
      "Delia saw a was ailed,"
      "Desserts, I stressed!",
      "Draw, O coward!",
      "Lepers repel.",
      "Live not on evil.",
      "Lonely Telynol.",
      "Murder for a jar of red rum.",
      "Never odd or even.",
      "No lemon, no melon.",
      "Senile felines.",
      "So many dynamos!",
      "Step on no pets.",
      "Was it a car or a cat I saw?",
      
      "Dot Net Perls is not a palindrome.",
      "Why are you reading this?",
      "This article is not useful.",
      ". . .",
      ". . . Test"
    };
  
    foreach (string value in array)
    {
      Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
    }
  }
}
