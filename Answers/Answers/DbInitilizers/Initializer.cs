using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Android.OS;
using Answers.Models;
using Answers.Services;
using Environment = System.Environment;

namespace Answers.DbInitilizers
{
    internal class Initializer
    {
        public enum SubjectTypes { DataBases, ArchitectureSE, FundamentalSE, All }

        public List<Models.QuestionModel> GetInitizlizedList(SubjectTypes subjectType)
        {
            var questionsList = new List<Models.QuestionModel>();
            foreach (var question in GetQustions(subjectType))
            {
                string answerText = string.Empty;
                for (int i = 0; i < question.Variants.Count; i++)
                {
                    if (question.Variants.Count > 1 && i != question.Variants.Count - 1)
                    {
                        answerText += $"{question.Variants[i]};{Environment.NewLine}";
                    }
                    else
                    {
                        answerText += $"{question.Variants[i]}.";
                    }
                }
                var questionModel = new Models.QuestionModel
                {
                    QuestionText = question.Text,
                    AnswerText = answerText,
                    QuestionImage = question.ImageSrc
                };
                questionsList.Add(questionModel);
            }
            return questionsList;
        }

        public IEnumerable<ParseQuestionModel> GetQustions(SubjectTypes subjectType)
        {
            var assembly = typeof(Initializer).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(GetDestinationPath(subjectType));
            QuestionReaderService readerService = new QuestionReaderService(stream);
            IEnumerable<ParseQuestionModel> questions = readerService.GetInputData();
            return questions;
        }

        private string GetDestinationPath(SubjectTypes subjectType)
        {
            switch (subjectType)
            {
                case SubjectTypes.FundamentalSE: return "Answers.DbInitilizers.FundamentalSE.json";
                case SubjectTypes.DataBases: return "Answers.DbInitilizers.DataBases.json";
                case SubjectTypes.ArchitectureSE: return "Answers.DbInitilizers.ArchitectureSE.json";
            }
            return string.Empty;
        }
    }
}
