using System;
using System.Collections.Generic;

class Question
{
    public string Description { get; }
    public string Answer { get; }
    public int Value { get; }
    public bool IsAnswered { get; set; }

    public Question(string description, string answer, int value)
    {
        Description = description;
        Answer = answer;
        Value = value;
        IsAnswered = false;
    }
}
