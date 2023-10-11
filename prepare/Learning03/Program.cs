using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction jcFraction1 = new Fraction();
        
        Fraction jcFraction2 = new Fraction(5);

        Fraction jcFraction3 = new Fraction(3,4);

        Fraction jcFraction4 = new Fraction(1,3);
        
        jcFraction1.setFraction(1,1);
        int jctop = jcFraction1.getTop();
        int jcBottom = jcFraction1.getBottom();
        Console.WriteLine($" {jctop} / {jcBottom}");
        Console.WriteLine(jcFraction1.GetFractionString());
        Console.WriteLine(jcFraction1.GetDecimalValue());
        Console.WriteLine(jcFraction2.GetFractionString());
        Console.WriteLine(jcFraction2.GetDecimalValue());
        Console.WriteLine(jcFraction3.GetFractionString());
        Console.WriteLine(jcFraction3.GetDecimalValue());
        Console.WriteLine(jcFraction4.GetFractionString());
        Console.WriteLine(jcFraction4.GetDecimalValue());

    }
}