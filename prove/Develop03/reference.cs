using System;

/*
W06 Prove: Developer 
Purpose: Stores the book, chapter, and verse.
Name: Lindsay Hurdman
Sources: Chat GPT
(c) 2023
*/

class lhReference
{
    // Create atributes.
    private string _lhbook;
    private string _lhchapter;
    private string _lhverse;

    // Constructor
    public lhReference(string lhbook, string lhchapter, string lhverse)
    {
        _lhbook = lhbook;
        _lhchapter = lhchapter;
        _lhverse = lhverse;
    }

    // Function to turn reference into string.
    public string lhtoString()
    {
        string lhreferenceString = $"{_lhbook} {_lhchapter}:{_lhverse}";
        return lhreferenceString;
    }
}
 