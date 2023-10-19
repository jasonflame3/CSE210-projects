using System;

/*
W06 Prove: Developer 
Purpose: To store a Scripture object, which contains a Reference object and a list of Word objects
Name: Sean Reading, Kamas Peterson, Lindsay Hurdman, Jason Chandler 
(c) 10/16/2023
*/

class srScripture
{
    private string srInputWords;
    private string srInputReference;

    private List<kpWord> srWords = new List<kpWord>();
    private lhReference srReference;

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
            srWords.Add(new kpWord(word, false));
        }
    }

    //convert the inputted string reference into a Reference object
    private void srParseReference()
    {
        int srSpaceIndex = srInputReference.LastIndexOf(' ');
        int srColonIndex = srInputReference.LastIndexOf(':');

        string srItem1 = srInputReference.Substring(0, srSpaceIndex);
        string srItem2 = srInputReference.Substring(srSpaceIndex + 1, (srColonIndex - srSpaceIndex - 1));
        string srItem3 = srInputReference.Substring(srColonIndex + 1);

        srReference = new lhReference(srItem1, srItem2, srItem3);
    }

    //return the reference and scripture together as a string
    public string srDisplay()
    {
        string srOutput = srReference.lhToString() + "\n";

        foreach (kpWord word in srWords)
        {
            srOutput = srOutput + word.kpDisplay() + " ";
        }

        return srOutput;
    }

    //select a number of random Word objects and hide them
    public void srUpdate()
    {
        Random srRandom = new Random();
        int srWordsToHide = 3; //change this if you want to hide more or less words

        for (int x = 1; x <= srWordsToHide; x++)
        {
            int srIndex = srRandom.Next(srWords.Count);
            kpWord srHiddenWord = srWords[srIndex];
            srHiddenWord.kpHidewords();
        }
    }

    //returns whether or not the entire scripture is hidden
    public bool srIsDone()
    {
        bool srIsDone = true;

        foreach(kpWord word in srWords)
        {
            if (word.kpIsHidden() == false)
            {
                srIsDone = false;
                break;
            }
        }

        return srIsDone;
    }
}