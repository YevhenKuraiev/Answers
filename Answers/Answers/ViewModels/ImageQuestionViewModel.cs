using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Answers.Models;

namespace Answers.ViewModels
{
    internal class ImageQuestionViewModel : BaseViewModel
    {
        private string _findingText;
        private readonly List<ImageQuestionModel> _listOfQuestions = new List<ImageQuestionModel>();
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

        public ObservableCollection<ImageQuestionModel> SelectedQuestions { get; set; }


        private void UpdateList(ImageQuestionModel selectedQuestion)
        {
            var index = SelectedQuestions.IndexOf(selectedQuestion);
            SelectedQuestions.Remove(selectedQuestion);
            SelectedQuestions.Insert(index, selectedQuestion);
        }


        public ImageQuestionViewModel()
        {
            InitializeList();
            SelectedQuestions = new ObservableCollection<ImageQuestionModel>(_listOfQuestions);
        }

        private void SelectList(string findingText)
        {
            SelectedQuestions = new ObservableCollection<ImageQuestionModel>
                (_listOfQuestions.Where(x => x.QuestionText.ToUpper().Contains(findingText.ToUpper())));
        }


        private void InitializeList()
        {
            _listOfQuestions.Add(new ImageQuestionModel
            {
                QuestionImage = ""
            });
        }


    }
}
