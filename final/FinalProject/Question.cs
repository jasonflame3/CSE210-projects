using System;
using System.Collections.Generic;

class Question
{
    private string _question;

    private List<string> _answers;
    //string _pointValue;

    public Question(string question, List<string> answers)
    {
        _question = question;
        _answers = answers; 
    }

    public string GetQuestion()
    {
        return _question;
    }

    public bool CheckAnswer(string playerAnswer)
    {
        return _answers.Contains(playerAnswer);
    }
}