using System;
using System.ComponentModel.DataAnnotations;
/*
W12 Prove: Developer 
Description:
Kamas Peterson 
(c) 2023 
*/

public class Letter : WheelofFortune
{
    private string _kpLetter;
    private string _kpReveal;
    private bool _kpHidden;

    public void kpHiddenLetters()
    {
        int kpLength = _kpLetter.Length;
        _kpHidden = true;
        _kpLetter = "";
        for (int i = 0; i < kpLength; i++)
        {
            _kpLetter += "_";
        }
    }

    public void kpRevealLetters()
    {
        
    }
    public kpLetter(string kpLetter, string kpReveal, bool kpHidden)
    {
        _kpLetter = kpLetter;
        _kpReveal = kpReveal;
        _kpHidden = kpHidden;
    }

    public string kpDisplay()
    {
        return _kpLetter;
    }

    public bool kpIsHidden()
    {
        return _kpHidden;
    }


}