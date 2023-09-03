using Questionnaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Services;

public class InMemoryQuestionRepository : IQuestionRepository
{
    private readonly List<Question> questions = new List<Question>();

    public InMemoryQuestionRepository()
    {
        questions.Add(new Question(0,"What is the capital of France?", "Paris"));
        questions.Add(new Question(-1,"Who is the author of 'Romeo and Juliet'?", "William Shakespeare"));

        // Add questions and answers related to Muinmos
        questions.Add(new Question(1, "When was Muinmos founded?", "Muinmos was founded in 2012."));
        questions.Add(new Question(2, "Who is the founder of Muinmos?", "Muinmos was founded by Remonda Z. Kirketerp-Møller."));
        questions.Add(new Question(3, "What does Muinmos' client onboarding platform deliver?", "Muinmos' client onboarding platform delivers unmatched results."));
        questions.Add(new Question(4, "What problem does Muinmos solve for financial institutions?", "Muinmos automates the process of staying up-to-date and remaining compliant in a fluid regulatory landscape."));
        questions.Add(new Question(5, "How does Muinmos empower financial institutions?", "Muinmos empowers financial institutions to drive their business forward while strengthening their compliance and protecting their investors."));
        // Add more questions and answers as needed...
    }

    public Question? GetById(QuestionId id)
    {
        return questions.FirstOrDefault(q => q.Id == id.Value);
    }

    public List<Question> GetAll()
    {
        return questions;
    }
}
