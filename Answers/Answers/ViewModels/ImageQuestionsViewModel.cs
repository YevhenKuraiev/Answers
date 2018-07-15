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
    internal class ImageQuestionsViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<ImageQuestionModel> _listOfQuestions;
        public ObservableCollection<ImageQuestionModel> SelectedQuestions { get; set; }
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

        public ImageQuestionsViewModel(List<ImageQuestionModel> listOfQuestions)
        {
            _listOfQuestions = listOfQuestions;
            SelectedQuestions = new ObservableCollection<ImageQuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<ImageQuestionModel>
                (_listOfQuestions.Where(x => x.QuestionText.ToUpper().Contains(findingText.ToUpper())));
        }

    }
}
