using System;
using System.Collections.Generic;

class Jeopardy
{
    public Jeopardy()
    {
        // Create players
        Console.WriteLine("How many players are going to play? ");
        string playersInput = Console.ReadLine();
        int numOfPlayers = int.Parse(playersInput);
        List<Player> playerList = new();

        for (int i = 1; i <= numOfPlayers; i++)
        {
            string playerName = $"Player {i}";
            Player cPlayer = new Player(playerName);
            playerList.Add(cPlayer);
        }

        Player player1 = new("player 1");

        // Create categories
        Category historyCategory = new("History");
        Category scienceCategory = new("Science");
        Category sportsCategory = new("Sports");

        // Create questions
        Question historyQ1 = new("What year did World War II end?", "1945", 200);
        Question historyQ2 = new("Who was the first President of the United States?", "George Washington", 400);

        Question scienceQ1 = new("What is the chemical symbol for gold?", "Au", 200);
        Question scienceQ2 = new("What is the largest planet in our solar system?", "Jupiter", 400);

        Question sportsQ1 = new("Which country won the FIFA World Cup in 2018?", "France", 200);
        Question sportsQ2 = new("Who holds the record for the most Olympic gold medals?", "Michael Phelps", 400);

        // Add questions to categories
        historyCategory.AddQuestion(historyQ1);
        historyCategory.AddQuestion(historyQ2);

        scienceCategory.AddQuestion(scienceQ1);
        scienceCategory.AddQuestion(scienceQ2);

        sportsCategory.AddQuestion(sportsQ1);
        sportsCategory.AddQuestion(sportsQ2);

        // Create the game board
        Board gameBoard = new();
        gameBoard.AddCategory(historyCategory);
        gameBoard.AddCategory(scienceCategory);
        gameBoard.AddCategory(sportsCategory);

        // Play the game
        while (!gameBoard.IsGameOver())
        {
            Console.Clear();
            Console.WriteLine("Jeopardy Game\n");

            foreach (Player player in playerList)
            {
                Console.WriteLine($"{player.Name()}: {player.Score()}");
            }
            //Console.WriteLine($"Current Scores: {player1.Name()}: {player1.Score} | {player2.Name}: {player2.Score}\n");

            gameBoard.DisplayBoard();

            Console.Write($"\nEnter player buzzer (1-{num_of_players}): ");
            int playerBuzzer = int.Parse(Console.ReadLine());

            Console.Write("Enter category index: ");
            int categoryIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter question index: ");
            int questionIndex = int.Parse(Console.ReadLine());
            
            gameBoard.SelectQuestion(playerBuzzer, categoryIndex, questionIndex);
        }

        // Display final scores
        Console.Clear();
        Console.WriteLine("Jeopardy Game Over!\n");
        foreach (Player player in playerList)
        {
            Console.WriteLine($"{player.Name()}: {player.Score()}");
        }
        //Console.WriteLine($"Final Scores: {player1.Name}: {player1.Score} | {player2.Name}: {player2.Score}");
    }
}