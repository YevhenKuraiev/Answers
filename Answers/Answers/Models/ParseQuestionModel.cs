using System.Collections.Generic;

namespace Answers.Models
{
    public class ParseQuestionModel
    {
        public string Text { get; set; }
        public string ImageSrc { get; set; }
        public List<string> Variants { get; set; }
    }
}
