using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction jcFraction1 = new Fraction();
        
        Fraction jcFraction2 = new Fraction(6);

        Fraction jcFraction3 = new Fraction(6,7);
        
        jcFraction1.setFraction(3,7);
        int jctop = jcFraction1.getTop();
        int jcBottom = jcFraction1.getBottom();
        Console.WriteLine($" {jctop} / {jcBottom}");
        Console.WriteLine(jcFraction1.GetFractionString());
        Console.WriteLine(jcFraction1.GetDecimalValue());
    }
}