using System.Diagnostics;
using System.Dynamic;

public class Fraction
{
    private int _jcTop;
    private int _jcBottom;

    public Fraction()
    {
        _jcTop = 1;
        _jcBottom = 1;
    }
    public Fraction(int jcTop)
    {
        _jcTop = jcTop;
        _jcBottom = 1;
    }
    public Fraction(int jcTop, int jcBottom)
    {
        _jcTop = jcTop;
        _jcBottom = jcBottom;
    }

    public void setFraction(int jcTop = 1, int jcBottom = 0)
    {
        _jcTop = jcTop;
        _jcBottom = jcBottom;
    }

    public int getTop()
    {
        return _jcTop;
    }

    public int getBottom()
    {
        return _jcBottom;
    }

    public string GetFractionString()
    {
        return $"{_jcTop}/{_jcBottom}";
    }

    public double GetDecimalValue()
    {
        return (double)(_jcTop) / (double)(_jcBottom);
    }
}