using System;
using System.Collections.Generic;
using System.Text;
using Answers.Models;

namespace Answers.DbInitilizers
{
    internal class DataBasesSubjectInitializer : IInitizlizer
    {
        public List<QuestionModel> GetInitizlizedList()
        {
            return new List<QuestionModel>();
        }
    }
}
