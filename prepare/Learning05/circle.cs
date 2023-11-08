using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Circle: Shape{
    private int _jcRadius;

    public Circle (string jcColor, int jcRadius) :base(jcColor)
    {
        _jcRadius = jcRadius;
    }
    public void jcSetSide(int jcRadius){
        _jcRadius = jcRadius;
    }
    public int jcGetSide(){
        return _jcRadius;
    }
    public override double jcGetArea(){
        return _jcRadius * _jcRadius * 3.141592653589;
    }
}