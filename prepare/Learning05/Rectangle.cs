using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Rectangle: Shape{
    private int _jcSide;
    private int _jcLength;

    public Rectangle (string jcColor, int jcSide, int jcLength) :base(jcColor)
    {
        _jcSide = jcSide;
        _jcLength = jcLength;
    }
    public void jcSetSide(int jcSide){
        _jcSide = jcSide;
    }
    public int jcGetSide(){
        return _jcSide;
    }
    public void jcSetLength(int jcLength){
        _jcLength = jcLength;
    }
    public int jcGetLength(){
        return _jcLength;
    }
    public override double jcGetArea(){
        return _jcSide * _jcLength;
    }
}