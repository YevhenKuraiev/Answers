using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Answers.DbInitilizers;
using Answers.Models;
using Java.Text;
using KhAITestParser;
using Xamarin.Forms;

namespace Answers.ViewModels
{
    internal class TestViewModel : BaseViewModel
    {
        private List<Question> _allQuestions;
        private bool _isShowResult;
        private int _countWrongAnswers = 0;
        public TestingModel CurrentQuestion { get; set; }

        public List<TestingModel> WrongAnswers { get; set; } = new List<TestingModel>();
        public List<TestingModel> Questions { get; set; }
        public ICommand NextQuestionCommand => new Command<object>(NextQuestion);
        public string TextButton { get; set; } = "Следующий вопрос";
        public string CountAnswers { get; set; }
        public TestViewModel()
        {
            Questions = CastListToTestingModel();
            CurrentQuestion = Questions.First();
            Questions.Remove(CurrentQuestion);
        }

        private void NextQuestion(object question)
        {
            if (!_isShowResult)
            {

                var model = question as TestingModel;
                Question originalQuestionquestion = _allQuestions.First(x => x.Text == model?.Text);
                for (int i = 0; i < model?.Variants.Count; i++)
                {
                    try
                    {
                        if (model.Variants[i].IsSelected && i != originalQuestionquestion.Answers[i])
                        {
                            WrongAnswers.Add(model);
                            _countWrongAnswers++;
                            break;
                        }
                        if (!model.Variants[i].IsSelected && i == originalQuestionquestion.Answers[i])
                        {
                            WrongAnswers.Add(model);
                            _countWrongAnswers++;
                            break;
                        }
                    }
                    catch
                    {
                        if (model.Variants[i].IsSelected)
                        {
                            WrongAnswers.Add(model);
                            _countWrongAnswers++;
                            break;
                        }
                    }
                    TextButton = "Следующий вопрос";
                }
                if (Questions.Count != 0)
                {
                    CurrentQuestion = Questions.Last();
                    Questions.Remove(CurrentQuestion);

                }
                else
                {
                    CurrentQuestion = null;
                    TextButton = "Просмотреть результаты";
                    CountAnswers = $"Неправильных ответов {_countWrongAnswers} из {_allQuestions.Count} вопросов";
                    _isShowResult = true;
                }
            }
            else
            {
                if (WrongAnswers.Count != 0)
                {
                    CurrentQuestion = WrongAnswers.First();
                    WrongAnswers.Remove(CurrentQuestion);
                    TextButton = "Следующий вопрос";
                }
                else
                {
                    //CountAnswers = "";
                    //CurrentQuestion = null;
                    //TextButton = "Начать заново";
                    //_isShowResult = false;
                    //Questions = CastListToTestingModel();
                    //CurrentQuestion = Questions.First();
                    //Questions.Remove(CurrentQuestion);
                    //_countWrongAnswers = 0;
                }
            }
        }

        private List<TestingModel> CastListToTestingModel()
        {
            var questionList = new List<Question>(new Initializer().GetQustions(Initializer.SubjectTypes.All));
            _allQuestions = new List<Question>(questionList);
            var testList = new List<TestingModel>();
            foreach (var question in questionList)
            {
                var testModel = new TestingModel();
                testModel.Answers = question.Answers;
                testModel.Text = question.Text;
                testModel.Variants = new ObservableCollection<Variants>();
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
