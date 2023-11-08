using System.Dynamic;

public abstract class Shape{
    private string _jcColor;

    public Shape (string jcColor)
    {
        _jcColor = jcColor;
    }
    public void jcSetColor(string jcColor){
        _jcColor = jcColor;
    }
    public string jcGetColor(){
        return _jcColor;
    }
    public virtual double jcGetArea(){
        return -1;
    }
}