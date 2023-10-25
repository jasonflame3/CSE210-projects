using System.Dynamic;

public class MathAssignment : Assignment
{
    private string _jcTextbookSection;
    private string _jcProblems;
    
    public MathAssignment(string jcTextbookSections, string jcProblems, string jcStudentName, string jcTopic) :base(jcStudentName,jcTopic){
        _jcTextbookSection = jcTextbookSections;
        _jcProblems = jcProblems;
    }

    public string jcGetHomeworkList(){
        return $"Section {_jcTextbookSection} Problems {_jcProblems}";
    }
}