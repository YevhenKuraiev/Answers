using System.Collections.Generic;
using Answers.Models;

namespace Answers.DbInitilizers
{
    interface IInitizlizer
    {
        List<QuestionModel> GetInitizlizedList();
    }
}
