using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

/*
W06 Prove: Developer 
Purpose: To hide words within the scriptures until finally the whole scripture is gone. 
Name: Kamas Peterson 
(c) 2023
Refrences:
https://www.w3schools.com/cs/cs_for_loop.php
*/
public class kpWord
{
    private string _kpWord; 
    private bool _kpHidden; 

    public void kpHidewords()
    {
       int kpLength = _kpWord.Length;
       _kpWord = ""; 
       for (int i = 0; i<= kpLength; i++)
       {
        _kpwords += "_";
       }
       

    }
    
    public kpWord(string kpWord, bool kpHidden)
    {
        _kpWord = kpWord; 
        _kpHidden = kpHidden;
    }

    public void kpDisplay()
    {
        Console.WriteLine($"{}");
        Console.ReadLine(); 
    }

}

