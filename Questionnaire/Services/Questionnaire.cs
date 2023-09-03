using Questionnaire.Models;
using System.Collections.Generic;

namespace Questionnaire.Services;

public class Questionnaire
{
    public List<Question> Questions { get; set; } = new List<Question>();

    public Questionnaire(List<Question> questions)
    {
        foreach (Question question in questions)
        {
            Questions.Add(question);
        }
    }
}
