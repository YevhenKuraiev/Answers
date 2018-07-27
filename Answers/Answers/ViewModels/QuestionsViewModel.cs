using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Answers.Models;

namespace Answers.ViewModels
{
    internal class QuestionsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<QuestionModel> _selectedQuestions;
        private string _findingText;
        private readonly List<QuestionModel> _listOfQuestions;

        public ObservableCollection<QuestionModel> SelectedQuestions
        {
            get => _selectedQuestions;
            set
            {
                _selectedQuestions = value;
                OnPropertyChanged("SelectedQuestions");
            }
        }

        public string FindingText
        {
            get => _findingText;
            set
            {
                if (value != null || value != _findingText)
                {
                    _findingText = value;
                    OnPropertyChanged("FindingText");
                    SelectList(FindingText);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
