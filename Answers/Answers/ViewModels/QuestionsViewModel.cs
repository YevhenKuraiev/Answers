using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Answers.Models;
using Xamarin.Forms;

namespace Answers.ViewModels
{
    internal class QuestionsViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<QuestionModel> _listOfQuestions;
        public ObservableCollection<QuestionModel> SelectedQuestions { get; set; }
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

        public QuestionsViewModel(List<QuestionModel> listOfQuestions)
        {
            _listOfQuestions = listOfQuestions;
            SelectedQuestions = new ObservableCollection<QuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<QuestionModel>
                (_listOfQuestions.Where(x => x.QuestionText.ToUpper().Contains(findingText.ToUpper())));
        }

    }
}
