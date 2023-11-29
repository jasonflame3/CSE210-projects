using System;
using System.Collections.Generic;

class Player
{
    public string Name { get; }
    public int Score { get; private set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddScore(int points)
    {
        Score += points;
    }
}