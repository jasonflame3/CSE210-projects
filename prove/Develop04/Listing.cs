using System;

/*
W08 Prove: Developer 
Activity Listing. The user picks a time and then writes a list of responses to a prompt.
Lindsay Hurdman, Kamas Peterson 
(c)2023
*/


class Listing : Prompt
{  
    private string _lhNumberOfItems;
    private string[] _lhItemList;

    // Constructor
    public Listing(string lhName, string lhDescription, float lhTime, string lhPrompt) : base(lhName, lhDescription, lhTime, lhPrompt)
    {
        // Set to 0.
        _lhNumberOfItems = "0";
        // List shouldn't need to hold more than 100 things?
        _lhItemList = new string[100];
    }

    public void lhDoListing()
    {
        // Get Display Messages
        lhGetDisplayMessage();
        
        // Get Prompt from Prompt Class.
        kpGetPrompt();

        // The spinner thingy.
        jcAnimation();

        // Call Begin Listing.
        lhBeginListing();
    }

    public void lhBeginListing()
    {
        // Figure out the times.
        DateTime lhStartTime = DateTime.Now;
        DateTime  lhFutureTime = startTime.AddSecounds(lhTime);
        Thread.Sleep(3000);

        // Do until specified time.
        while (lhCurrentTime < lhFutureTime)
        {
            DateTime lhCurrentTime = DateTime.Now;
            Console.Write("Enter an item:");
            string lhItem = Console.ReadLine();

            // Adding an item.
            lhNewItem(lhItem);
        }

        // Show number of Items.
        lhDisplayNumberOfItems();
    }

    private void lhNewItem(string lhItem)
    {
        // Adding the new items to the list of items.
        _lhItemList[int.Parse(_lhNumberOfItems)] = lhItem;
        _lhNumberOfItems = (int.Parse(_lhNumberOfItems) + 1).ToString();
    }

    private void lhDisplayNumberOfItems()
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