using System;
using System.Linq;
using Questionnaire.Services;

class Program
{
    static void Main(string[] args)
    {
        var questionRepository = new InMemoryQuestionRepository();
        var questionnaire = new Questionnaire.Services.Questionnaire(questionRepository.GetAll());

        // Start the interactive session
        StartInteractiveSession(questionnaire);
    }

    static void StartInteractiveSession(Questionnaire.Services.Questionnaire questionnaire)
    {
        Console.WriteLine("Welcome to the Muinmos questionnaire!");

        while (true)
        {
            Console.WriteLine("Ask your question (type 'exit' to end):");
            var input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            var answer = GetAnswer(input, questionnaire);
            Console.WriteLine($"Answer: {answer}");
        }

        Console.WriteLine("Thank you for using the Muinmos questionnaire!");
    }

    static string GetAnswer(string question, Questionnaire.Services.Questionnaire questionnaire)
    {
        var matchedQuestion = questionnaire.Questions.FirstOrDefault(q => q.Text.ToLower() == question.ToLower());
        return matchedQuestion?.Answer ?? "I'm sorry, I don't have an answer to that question.";
    }
}
