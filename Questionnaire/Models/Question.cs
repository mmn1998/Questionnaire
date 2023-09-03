namespace Questionnaire.Models;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Answer { get; set; }

    public Question(int id, string text, string answer)
    {
        Id = id;
        Text = text;
        Answer = answer;
    }
}
public class QuestionId
{
    public int Value { get; }

    public QuestionId(int value)
    {
        Value = value;
    }
}
