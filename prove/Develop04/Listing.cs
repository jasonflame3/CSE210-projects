using System;

/*
W08 Prove: Developer 
Activity Listing. The user picks a time and then writes a list of responses to a prompt.
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
(c)2023
*/


class Listing : Prompt
{  
    private string _lhNumberOfItems;
    private readonly string[] _lhItemList;

    // Constructor
    public Listing(string lhName, string lhDescription, float lhTime, string lhPrompt) : base(lhName, lhDescription, lhTime, lhPrompt)
    {
        // Set to 0.
        _lhNumberOfItems = "0";
        // List shouldn't need to hold more than 100 things?
        _lhItemList = new string[100];

    }

    public void LhDoListing()
    {
        // Display Start Message from Activities Class.
        jcDisplayStartMessage();

        // Get Prompt from Prompt Class.
        string prompt = kpGetPrompt();
        Console.WriteLine(prompt);

        // The spinner thingy.
        jcAnimation(3);

        // Call Begin Listing.
        LhBeginListing();
        
        // Show number of Items.
        LhDisplayNumberOfItems();
        jcAnimation(3);

        // Display End Message from Activities Class.
        jcDisplayEndMessage();
    }

    public void LhBeginListing()
    {
        // // Figure out the times.
        // DateTime lhStartTime = DateTime.Now;
        // DateTime  lhFutureTime = lhStartTime.AddSeconds(jcGetTime());
        // Thread.Sleep(3000);
        // DateTime lhCurrentTime = DateTime.Now;

        // // Do until specified time.
        // while (lhCurrentTime < lhFutureTime)
        // {
            
        // }

        DateTime srStart = DateTime.Now; //the time the activity starts

        float srRunTime = 0; //how long the activity has run for already
        while (srRunTime < jcGetTime())
        {
            Console.Write("Enter an item:");
            string lhItem = Console.ReadLine();

            // Adding an item.
            LhNewItem(lhItem);

            srRunTime = ((DateTime.Now -srStart).Minutes *60 ) + (DateTime.Now - srStart).Seconds;
        }

    }

    private void LhNewItem(string lhItem)
    {
        // Adding the new items to the list of items.
        _lhItemList[int.Parse(_lhNumberOfItems)] = lhItem;
        _lhNumberOfItems = (int.Parse(_lhNumberOfItems) + 1).ToString();
    }

    private void LhDisplayNumberOfItems()
    {
        // Printing the number of items.
        Console.WriteLine($"You've listed {_lhNumberOfItems} items:");
        for (int i = 0; i < int.Parse(_lhNumberOfItems); i++)
        {
            // Nicely formatting it.
            Console.WriteLine($"{i + 1}. {_lhItemList[i]}");
        }
    }
}