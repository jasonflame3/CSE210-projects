using System;

/*
W08 Prove: Developer 
Activity Listing
Lindsay Hurdman, Kamas Peterson 
(c)2023
*/


class Listing : Prompt
{  
    private string _lhNumberOfItems;
    private string[] _lhItemList;

    // Constructor
    public Listing(string lhName, string lhDecription, float lhTime, string lhPrompt) : base(lhName, lhDecription, lhTime, lhPrompt)
    {
        // Set to 0.
        _lhNumberOfItems = "0";
        // List shouldn't need to hold more than 100 things?
        _lhItemList = new string[100];
    }

    public void DoListing()
    {
        // Pull Prompt from Prompt Class.
        Console.WriteLine(lhPrompt);

        // The spinner thingy.
        Console.Write("+");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");

        // Call Begin Listing.
        BeginListing();
    }

    public void BeginListing()
    {
        // Figure out the times.
        DateTime lhStartTime = DateTime.Now;
        DateTime  lhFutureTime = startTime.AddSecounds(lhTime);
        Thread.Sleep(3000);

        // Do unitl specified time.
        while (lhCurrentTime < lhFutureTime)
        {
            DateTime lhCurrentTime = DateTime.Now;
            Console.Write("Enter an item:");
            string lhItem = Console.ReadLine();

            // Adding an item.
            NewItem(lhItem);
        }

        // Show number of Items.
        DisplayNumberOfItems();
    }

    private void NewItem(string lhItem)
    {
        // Adding the new items to the list of items.
        _itemList[int.Parse(_lhNumberOfItems)] = lhItem;
        _lhNumberOfItems = (int.Parse(_lhNumberOfItems) + 1).ToString();
    }

    private void DisplayNumberOfItems()
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