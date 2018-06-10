using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Answers.Models
{
    internal class QuestionModel
    {
        public string Question { get; set; }
        public bool IsVisibleAnswer { get; set; }
        public string AnswerText { get; set; }
        public ImageSource AnswerImage { get; set; }
    }
}
