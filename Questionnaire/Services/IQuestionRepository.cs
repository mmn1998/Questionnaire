using Questionnaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Services;

public interface IQuestionRepository
{
    Question? GetById(QuestionId id);
    List<Question> GetAll();
}
