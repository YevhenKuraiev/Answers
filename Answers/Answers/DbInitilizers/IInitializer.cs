using System.Collections.Generic;
using Answers.Models;
using KhAITestParser;

namespace Answers.DbInitilizers
{
    interface IInitializer
    {
        List<QuestionModel> GetInitizlizedList(Initializer.SubjectTypes subjectTypes);
        IEnumerable<Question> GetQustions(Initializer.SubjectTypes subjectTypes);
    }
}
