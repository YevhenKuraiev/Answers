namespace Answers.Models
{
    class QuestionModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public QuestionModel(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
