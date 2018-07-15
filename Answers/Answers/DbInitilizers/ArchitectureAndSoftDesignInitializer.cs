using System.Collections.Generic;
using Answers.Models;
using Xamarin.Forms;

namespace Answers.DbInitilizers
{
    internal class ArchitectureAndSoftDesignInitializer
    {
        public List<ImageQuestionModel> GetInitizlizedList()
        {
            return new List<ImageQuestionModel>
            {
                new ImageQuestionModel
                {
                QuestionText = "В типовой архитектуре приложения к уровню логики приолжения относятся:",
                QuestionImage = ImageSource.FromResource("Answers.Images.Architecture.Image1.png"),
                AnswerText = "бизнес-компоненты"
                },

            };
        }


    }
}
