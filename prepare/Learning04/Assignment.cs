using System.Dynamic;

public class Assignment
{
    private string _jcStudentName;
    private string _jcTopic;

    public Assignment(){
        _jcStudentName = "";
        _jcTopic = "";
    }

    public Assignment(string jcStudentName,string jcTopic){
        _jcStudentName = jcStudentName;
        _jcTopic = jcTopic;
    }

    public string jcGetSummery(){
        return $"{_jcStudentName}, {_jcTopic}";
    }

    protected string jcGetName(){
        return _jcStudentName;
    } 
}