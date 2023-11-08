using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Square: Shape{
    private int _jcSide;

    public Square (string jcColor, int jcSide) :base(jcColor)
    {
        _jcSide = jcSide;
    }
    public void jcSetSide(int jcSide){
        _jcSide = jcSide;
    }
    public int jcGetSide(){
        return _jcSide;
    }
    public override double jcGetArea(){
        return _jcSide * _jcSide;
    }
}