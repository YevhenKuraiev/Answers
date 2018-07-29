using System.Collections.Generic;
using Answers.Models;

namespace Answers.DbInitilizers
{
    internal class Initializer
    {
        public List<QuestionModel> GetInitizlizedList()
        {
            var list = new List<QuestionModel>();
            list.Add(new QuestionModel("1. His cousin doesn't go to _____ school on _____ Sunday.", "А) — , —"));
            list.Add(new QuestionModel("2. He didn't even know ______ Browns had a daughter.", "А) —"));
            list.Add(new QuestionModel("3. ______ Dnieper is	_______ main river in ______ Ukraine.", "А) — , the, —"));
            list.Add(new QuestionModel("4. _______ Parkers won lottery last week.", "А) —"));
            list.Add(new QuestionModel("5. He bought _____ book at the supermarket yesterday.", "D) the"));
            list.Add(new QuestionModel("6. The bee was buzzing among ____ flowers in the vase.", "D) the"));
            list.Add(new QuestionModel("7. He turned and saw _____ crying boy.", "D) the"));
            list.Add(new QuestionModel("8. What _____ marvelous English souvenirs you’ve bought!", "А) —"));

            list.Add(new QuestionModel("8. What _____ marvelous English souvenirs you’ve bought!", "А) —"));
            return list;
        }

    }
}
