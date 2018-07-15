using System.Collections.Generic;
using Answers.Models;
using Xamarin.Forms;

namespace Answers.DbInitilizers
{
    internal class ArchitectureAndSoftDesignInitializer : IInitizlizer
    {
        public List<QuestionModel> GetInitizlizedList()
        {
            return new List<QuestionModel>
            {
                new QuestionModel
                {
                QuestionText = "В типовой архитектуре приложения к уровню логики приолжения относятся:",
                QuestionImage = ImageSource.FromResource("Answers.Images.Architecture.Image1.png"),
                AnswerText = "бизнес-компоненты"
                },

            };
        }


    }
}
