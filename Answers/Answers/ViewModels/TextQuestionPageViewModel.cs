using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Answers.Models;

namespace Answers.ViewModels
{
    internal class TextQuestionPageViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<TextQuestionModel> _listOfQuestions = new List<TextQuestionModel>();
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

        public ObservableCollection<TextQuestionModel> SelectedQuestions { get; set; }


        private void UpdateList(TextQuestionModel selectedQuestion)
        {
            var index = SelectedQuestions.IndexOf(selectedQuestion);
            SelectedQuestions.Remove(selectedQuestion);
            SelectedQuestions.Insert(index, selectedQuestion);
        }


        public TextQuestionPageViewModel()
        {
            InitializeList();
            SelectedQuestions = new ObservableCollection<TextQuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<TextQuestionModel>
                (_listOfQuestions.Where(x => x.QuestionText.ToUpper().Contains(findingText.ToUpper())));
        }


        private void InitializeList()
        {
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Главными областями программной инженерии согласно SWEBOK являются...",
                AnswerText = "инженерия требований"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Организационными областями программной инженерии согласно SWEBOK являются...",
                AnswerText = "управление конфигурацией; процесс инженерии ПС"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Главными областями программной инженерии согласно SWEBOK не являются...",
                AnswerText = "управление конфигурацией; процесс инженерии ПС"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Валидация требований - это:...",
                AnswerText = "проверка полноты, непротиворечивости и однозначности спецификации и правильности выполнения функций системы в соответствии с требованиями"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Основные систематические методы обеспечения правильности программ включают в себя:...",
                AnswerText = "верификация компонентов; валидация требований"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Для каких задач управления проектом используется диаграмма Ганта?",
                AnswerText = "планирование проекта и составление графиков работ выполнения проекта"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Управление проектом - это:",
                AnswerText = "руководство работами команды исполнителей проекта для реализации проекта с использованием методов управления, планирования и контроля работ, управление рисками," +
                " эффективной организацией работы и коммуникационными потоками в команде исполнителей"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Планирование - это:",
                AnswerText = "процесс распределения и назначения ресурсов (материальных и людских) с учетом стоимости и времени выполнения проекта"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Основными составляющими любого проекта являются:",
                AnswerText = "ресурсы; время выполнения проекта; стоимость выполнения проекта"
            });
            _listOfQuestions.Add(new TextQuestionModel
            {
                QuestionText = "Ответственность за координацию и реализацию основных составляющих проекта несет:",
                AnswerText = "менеджер проекта"
            });
        }


    }


}
