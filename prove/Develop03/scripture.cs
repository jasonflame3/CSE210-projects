using System;

class srScripture
{
    private string srInputWords;
    private string srInputReference;

    private List<Word> srWords = new List<Word>();
    private Reference srReference;

    //Constructors
    public srScripture()
    {
        srInputWords = "Hello World!";
        srInputReference = "Jim 1:2";
    }
    public srScripture(string srWords, string srReference)
    {
        srInputWords = srWords;
        srInputReference = srReference;
    }
}