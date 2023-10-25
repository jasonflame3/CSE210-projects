public class WritingAssignment : Assignment
{
    private string _jcTitle;

    public WritingAssignment(string jcStudentName,string jcTopic, string jcTitle): base(jcStudentName,jcTopic){
        _jcTitle = jcTitle;
    }
    public string jcGetWritingInformation(){
        return $"{_jcTitle} by {jcGetName()}";
    }
}