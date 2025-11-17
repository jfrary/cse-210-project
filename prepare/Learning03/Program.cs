using System;

class Program
{
    static void Main(string[] args)
  {

Fraction p1 = new Fraction();

Fraction p2 = new Fraction(5);

Fraction p3 = new Fraction(6, 7);

Fraction p4 = new Fraction(3, 4);



Console.WriteLine(p1.GetFractionString());
Console.WriteLine(p1.GetDecimalValue());
Console.WriteLine(p2.GetFractionString());
Console.WriteLine(p2.GetDecimalValue());
Console.WriteLine(p3.GetFractionString());
Console.WriteLine(p3.GetDecimalValue());
Console.WriteLine(p4.GetFractionString());
Console.WriteLine(p4.GetDecimalValue());
    }
}

