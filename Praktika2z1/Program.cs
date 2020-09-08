using System;

namespace Praktika2z1
{
  
    class Program
  {
    static SByte a = 0;
    static Byte b = 0;
    static Int16 c = 0;
    static Int32 d = 0;
    static Int64 e = 0;
    static string s = "";
    static Exception ex = new Exception();
    static object[] types = { a, b, c, d, e, s, ex };
    
    public static object o { get; private set; }

    static void Main()
    {
      foreach (object o in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
    }

  }
  
}

