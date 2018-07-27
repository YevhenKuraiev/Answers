using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Answers.Models
{
    class TestingModel
    {
        public string Text { get; set; }
        public ObservableCollection<Variants> Variants { get; set; }
        public List<int> Answers { get; set; }
    }

    class Variants
    {
        public string Variant { get; set; }
        public bool IsSelected { get; set; }
    }
}
