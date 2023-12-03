using System;
using System.Collections.Generic;

class Board
{
    private List<Category> categories;

    public Board()
    {
        categories = new List<Category>();
    }

    public void AddCategory(Category category)
    {
        categories.Add(category);
    }

    public void DisplayBoard()
    {
        Console.WriteLine("Categories:");

        for (int i = 0; i < categories.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {categories[i].Name}");
        }

        Console.WriteLine("\nQuestions:");

        for (int i = 0; i < categories.Count; i++)
        {
            Console.WriteLine($"\n{categories[i].Name}:");

            for (int j = 0; j < categories[i].Questions.Count; j++)
            {
                var question = categories[i].Questions[j];
                Console.WriteLine($"{j + 1}. {question.Value} - {question.IsAnswered}");
            }
        }
    }

    public void SelectQuestion(Player player, int categoryIndex, int questionIndex)
    {
        var category = categories[categoryIndex - 1];
        var question = category.Questions[questionIndex - 1];

        if (!question.IsAnswered)
        {
            Console.WriteLine($"\n{player.Name}, here is your question: {question.Description}");
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == question.Answer.ToLower())
            {
                Console.WriteLine("Correct!");
                player.AddScore(question.Value);
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {question.Answer}");
            }

            question.IsAnswered = true;
        }
        else
        {
            Console.WriteLine("This question has already been answered.");
        }

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public bool IsGameOver()
    {
        foreach (var category in categories)
        {
            foreach (var question in category.Questions)
            {
                if (!question.IsAnswered)
                {
                    return false;
                }
            }
        }

        return true;
    }
}