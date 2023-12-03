class Survey{
    private List<Answer> _jcAnswers;
    private string _jcPrompt;

    Survey(List<Answer> jcAnswers,string jcPrompt){
        _jcAnswers = jcAnswers;
        _jcPrompt =jcPrompt;
    }
    public string jcDisplayPrompt(){
        return _jcPrompt;
    }
    public string jcDisplayAnswer(int jcIndex){
        _jcAnswers[jcIndex].jcSetHidden(false);
        return _jcAnswers[jcIndex].jcDisplayAnswer();
    }
    public void jcDisplayAnswers(){
        //prints the answers to the terminal
        foreach(Answer jcAnswer in _jcAnswers){
            Console.WriteLine(jcAnswer.jcDisplayAnswer());
        }
    }
}