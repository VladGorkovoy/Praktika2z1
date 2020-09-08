using NPoco.Expressions;
using System;

namespace Praktika2z2
{
  class Program
  {
    static string s = "Microsoft .NET Framework 2 Application Development Foundation";
    static string[] sa = s.Split(" ");

    static void Main()
    {

      Array.Sort(sa);

      s = string.Join(" ", sa); 
      Console.WriteLine(s);
    }
  }
}
