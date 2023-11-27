using System;
using System.Collections.Generic;

class Category
{
    private string _name;
    private List<Question> _questions;

    public Category(string name)
    {
        _name = name;
        _questions = new List<Question>();
    }

    public void AddQuestions(string question, List<string> answers)
    {
        Question newQuestion = new(question, answers);
        _questions.Add(newQuestion);
    }

    public List<Question> GetQuestions()
    {
        return _questions;
    }

}