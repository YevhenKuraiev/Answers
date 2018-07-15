using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Answers.Models;

namespace Answers.ViewModels
{
    internal class TextQuestionsViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<TextQuestionModel> _listOfQuestions;
        public ObservableCollection<TextQuestionModel> SelectedQuestions { get; set; }
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

        public TextQuestionsViewModel(List<TextQuestionModel> listOfQuestions)
        {
            _listOfQuestions = listOfQuestions;
            SelectedQuestions = new ObservableCollection<TextQuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<TextQuestionModel>
                (_listOfQuestions.Where(x => x.QuestionText.ToUpper().Contains(findingText.ToUpper())));
        }


    }


}
