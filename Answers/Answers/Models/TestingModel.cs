using System.Collections.Generic;

namespace Answers.Models
{
    class TestingModel
    {
        public string Text { get; set; }
        public List<Variants> Variants { get; set; }
        public List<int> Answers { get; set; }
    }

    class Variants
    {
        public string Variant { get; set; }
        public bool IsSelected { get; set; }
    }
}
