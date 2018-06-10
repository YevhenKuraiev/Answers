using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Answers.Models;

namespace Answers.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<QuestionModel> _listOfQuestions;
        private QuestionModel _selectedQuestion;
        private QuestionModel _oldSelectedQuestion;
        public string FindingText
        {
            get => _findingText;
            set
            {
                if (value != null || value != _findingText)
                {
                    _findingText = value;
                    SelectList(FindingText);
                }
            }
        }

        public ObservableCollection<QuestionModel> SelectedQuestions { get; set; }

        public QuestionModel SelectedQuestion
        {
            get => _selectedQuestion;
            set
            {
                if (value != null)
                {
                    _selectedQuestion = value;
                    if (_oldSelectedQuestion == _selectedQuestion)
                    {
                        _selectedQuestion.IsVisibleAnswer = !_selectedQuestion.IsVisibleAnswer;
                        UpdateList(_selectedQuestion);
                    }
                    else
                    {
                        if (_oldSelectedQuestion != null)
                        {
                            _oldSelectedQuestion.IsVisibleAnswer = false;
                            UpdateList(_oldSelectedQuestion);

                        }
                        _selectedQuestion.IsVisibleAnswer = true;
                        UpdateList(_selectedQuestion);
                    }
                    _oldSelectedQuestion = _selectedQuestion;
                }

            }
        }

        private void UpdateList(QuestionModel selectedQuestion)
        {
            var index = SelectedQuestions.IndexOf(selectedQuestion);
            SelectedQuestions.Remove(selectedQuestion);
            SelectedQuestions.Insert(index, selectedQuestion);
        }


        public MainViewModel()
        {
            _listOfQuestions = new List<QuestionModel>();
            _listOfQuestions.Add(new QuestionModel
            { Question = "Главными областями программной инженерии согласно SWEBOK являются...",
                AnswerText = "инженерия требований"
            });
            _listOfQuestions.Add(new QuestionModel
            { Question = "Организационными областями программной инженерии согласно SWEBOK являются...",
                AnswerText = "управление конфигурацией; процесс инженерии ПС"
            });
            SelectedQuestions = new ObservableCollection<QuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<QuestionModel>
                (_listOfQuestions.Where(x => x.Question.ToUpper().Contains(findingText.ToUpper())));
        }


    }


}
