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

    //convert the inputted string of text into a list of Word objects
    private void srParseWords()
    {
        //turn the input string into an array of strings
        string[] srTempArray = srInputWords.Split(" ");

        //loop through the array, turn each string into a Word object, and add it to the list of words
        foreach (string word in srTempArray)
        {
            srWords.Add(new Word());
        }
    }
}