class Answer{
    private string _jcTitle;
    private int _jcPointsWorth;
    private bool _jcHidden;

    public Answer(string jcTitle, int jcPointsWorth, bool jcHidden = true){
        _jcTitle = jcTitle;
        _jcPointsWorth = jcPointsWorth;
        _jcHidden = jcHidden;
    }

    public string jcDisplayAnswer(){
        return _jcTitle;
    }
    public int jcGetPoints(){
        return _jcPointsWorth;
    }
    public bool jcGetHidden(){
        return _jcHidden;
    }
    public void jcSetHidden(bool jcHidden){
        _jcHidden = jcHidden;
    }
}