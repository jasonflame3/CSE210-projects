using System;
using System.Collections.Generic;

class Jeopardy
{
    static void Main()
    {
        // Create players
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        // Create categories
        Category historyCategory = new Category("History");
        Category scienceCategory = new Category("Science");
        Category sportsCategory = new Category("Sports");

        // Create questions
        Question historyQ1 = new Question("What year did World War II end?", "1945", 200);
        Question historyQ2 = new Question("Who was the first President of the United States?", "George Washington", 400);

        Question scienceQ1 = new Question("What is the chemical symbol for gold?", "Au", 200);
        Question scienceQ2 = new Question("What is the largest planet in our solar system?", "Jupiter", 400);

        Question sportsQ1 = new Question("Which country won the FIFA World Cup in 2018?", "France", 200);
        Question sportsQ2 = new Question("Who holds the record for the most Olympic gold medals?", "Michael Phelps", 400);

        // Add questions to categories
        historyCategory.AddQuestion(historyQ1);
        historyCategory.AddQuestion(historyQ2);

        scienceCategory.AddQuestion(scienceQ1);
        scienceCategory.AddQuestion(scienceQ2);

        sportsCategory.AddQuestion(sportsQ1);
        sportsCategory.AddQuestion(sportsQ2);

        // Create the game board
        Board gameBoard = new Board();
        gameBoard.AddCategory(historyCategory);
        gameBoard.AddCategory(scienceCategory);
        gameBoard.AddCategory(sportsCategory);

        // Play the game
        while (!gameBoard.IsGameOver())
        {
            Console.Clear();
            Console.WriteLine("Jeopardy Game\n");

            Console.WriteLine($"Current Scores: {player1.Name}: {player1.Score} | {player2.Name}: {player2.Score}\n");

            gameBoard.DisplayBoard();

            Console.Write("\nEnter player buzzer (1 or 2): ");
            int playerBuzzer = int.Parse(Console.ReadLine());

            Console.Write("Enter category index: ");
            int categoryIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter question index: ");
            int questionIndex = int.Parse(Console.ReadLine());

            gameBoard.SelectQuestion(playerBuzzer == 1 ? player1 : player2, categoryIndex, questionIndex);
        }

        // Display final scores
        Console.Clear();
        Console.WriteLine("Jeopardy Game Over!\n");
        Console.WriteLine($"Final Scores: {player1.Name}: {player1.Score} | {player2.Name}: {player2.Score}");
    }
}