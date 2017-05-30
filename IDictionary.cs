using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Dictionary<string, string> dict = new Dictionary<string, string>();
    dict["Name"] = "Om";
    WriteKeyA(dict);
    
    SortedDictionary<string, string> sort = new SortedDictionary<string, string>();
    sort["Name"] = "Patel";
    WriteKeyA(sort);
    Console.ReadLine();
  }
  
  static void WriteKeyA(IDictionary<string, string> i)
  {
    Console.WriteLine(i["Name"]);
  }
}
