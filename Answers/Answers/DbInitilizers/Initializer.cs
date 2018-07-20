using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Answers.Models;
using KhAITestParser;

namespace Answers.DbInitilizers
{
    internal class Initializer : IInitializer
    {
        public enum SubjectTypes { DataBases, ArchitectureSE, FundamentalSE, All }
        public List<QuestionModel> GetInitizlizedList(SubjectTypes subjectType)
        {
            var questionsList = new List<QuestionModel>();
            foreach (var question in GetQustions(subjectType))
            {
                string answerText = string.Empty;
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    answerText += $"{question.Variants[i]}; ";
                }
                questionsList.Add(new QuestionModel
                {
                    QuestionText = question.Text,
                    AnswerText = answerText
                });
            }
            return questionsList;
        }

        public IEnumerable<Question> GetQustions(SubjectTypes subjectType)
        {
            var assembly = typeof(Initializer).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Answers.DbInitilizers.answers.json");
            QuestionReader reader = new QuestionReader(stream);
            IEnumerable<Question> questions = reader.GetInputData();
            return questions;
        }
    }
}
