using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Answers.DbInitilizers;
using Answers.Models;
using KhAITestParser;
using Xamarin.Forms;

namespace Answers.ViewModels
{
    internal class TestViewModel : BaseViewModel
    {
        public TestingModel CurrentQuestion {
            get;
            set; 
        }
        public List<TestingModel> Questions { get; set; }
        public ICommand NextQuestionCommand => new Command<object>(NextQuestion);
        public TestViewModel()
        {
            Questions = CastListToTestingModel();
            CurrentQuestion = Questions.First();
            Questions.Remove(CurrentQuestion);
        }

        private void NextQuestion(object question)
        {
            
        }

        private List<TestingModel> CastListToTestingModel()
        {
            var questionList = new List<Question>(new Initializer().GetQustions(Initializer.SubjectTypes.All));
            var testList = new List<TestingModel>();
            foreach (var question in questionList)
            {
                var testModel = new TestingModel();
                testModel.Answers = question.Answers;
                testModel.Text = question.Text;
                testModel.Variants = new List<Variants>();
                foreach (var variant in question.Variants)
                {
                    testModel.Variants.Add(new Variants
                    {
                        Variant = variant,
                        IsSelected = false
                    });
                }
                testList.Add(testModel);
            }
            return testList;
        }
    }
}
