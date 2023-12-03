using System;
using System.Collections.Generic;

class Category
{
    public string Name { get; }
    public List<Question> Questions { get; }

    public Category(string name)
    {
        Name = name;
        Questions = new List<Question>();
    }

    public void AddQuestion(Question question)
    {
        Questions.Add(question);
    }
}