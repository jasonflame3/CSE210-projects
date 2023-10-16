using System;

/*
W06 Prove: Developer 
Purpose: To store a Scripture object, which contains a Reference object and a list of Word objects
Name: Sean Reading
(c) 10/16/2023
*/

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

        srParseWords();
        srParseReference();
    }
    public srScripture(string srWords, string srReference)
    {
        srInputWords = srWords;
        srInputReference = srReference;

        srParseWords();
        srParseReference();
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

    //convert the inputted string reference into a Reference object
    private void srParseReference()
    {
        srReference = new Reference();
    }
}