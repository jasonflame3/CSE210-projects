using System;

/*
W08 Prove: Developer 
Activity Reflection
Lindsay Herdman, Kamas Peterson 
(c)2023
*/


class Reflection : Prompt
{
    private string _kpQuestions <list>;

    public Reflection(string lhName, string lhDecription, float lhTime, string lhPrompt, string kpQuestions) : base(lhName, lhDecription, lhTime, lhPrompt)
    {
        kpQuestions = _kpQuestions;
    }

    public DoReflection()
    {

    }

    private GetQuesitons()
    {
        return _kpQuestions;
    }
}