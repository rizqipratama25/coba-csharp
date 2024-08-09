using System;

namespace variable {
  class Variable {
    static void Main(string[] args) {
      int a = 5;
      int b = 10;
      int c = a + b;
      int d = a * b;
      int e = b / a;
      int f = int.MaxValue;
      int g = int.MinValue;
      double aa = double.MaxValue;
      double bb = double.MinValue;
      long ab = long.MaxValue;
      long ac = long.MinValue;
      decimal ad = decimal.MaxValue;
      decimal ae = decimal.MinValue;
      double r = 7;
      double keliling = 2 * Math.PI * r;
      double luas = Math.PI * r * r;

      Console.WriteLine(c);
      Console.WriteLine(d);
      Console.WriteLine(e);
      Console.WriteLine(f);
      Console.WriteLine(g);
      Console.WriteLine(aa);
      Console.WriteLine(ab);
      Console.WriteLine(ac);
      Console.WriteLine(bb);
      Console.WriteLine(ad);
      Console.WriteLine(ae);

      Console.WriteLine("Keliling Lingkran : " + keliling);
      Console.WriteLine("Luas Lingkaran : " + luas);
    }
  }
}
