using System;

/*
W06 Prove: Developer 
Purpose: Stores the book, chapter, and verse.
Name: Lindsay Hurdman, Kamas Peterson, Sean Reading, Jason Chandler 
Sources: Chat GPT for errors
(c) 2023
*/

class lhReference
{
    // Create atributes book, chapter, and verse.
    private string _lhBook;
    private string _lhChapter;
    private string _lhVerse;

    // Constructor for reference.
    public lhReference(string lhBook, string lhChapter, string lhVerse)
    {
        _lhBook = lhBook;
        _lhChapter = lhChapter;
        _lhVerse = lhVerse;
    }

    // Function to turn reference into string.
    // Returns a string.
    public string lhToString()
    {
        string lhReferenceString = $"{_lhBook} {_lhChapter}:{_lhVerse}";
        return lhReferenceString;
    }
}
 