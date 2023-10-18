using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

/*
W06 Prove: Developer 
Purpose: To hide words within the scriptures until finally the whole scripture is gone. 
Name: Kamas Peterson, Lindsay Hurdman, Sean Reading, Jason Chandler 
(c) 2023
Refrences:
https://www.w3schools.com/cs/cs_for_loop.php
https://www.tutorialspoint.com/How-to-calculate-the-length-of-the-string-using-Chash#:~:text=Use%20the%20String.,the%20length%20of%20the%20string.
*/
public class kpWord
{
    // attributes
    private string _kpWord; 
    private bool _kpHidden; 

    // behaviors 
    public void kpHidewords()
    {
        // Counts the amount of word hidden and replaces it with underscore
       int kpLength = _kpWord.Length;
       _kpHidden = true;
       _kpWord = ""; 
       for (int i = 0; i < kpLength; i++)
       {
        _kpWord += "_";
       }
       
    }
    
    public kpWord(string kpWord, bool kpHidden)
    {
        // Calls then and makes them public 
        _kpWord = kpWord; 
        _kpHidden = kpHidden;
    }

    public string kpDisplay()
    {
        //Returns the words taken.
        return _kpWord;
    }

    public bool kpIsHidden()
    {
        return _kpHidden;
    }

}

