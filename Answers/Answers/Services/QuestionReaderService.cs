using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Answers.Models;
using Newtonsoft.Json.Linq;

namespace Answers.Services
{
    public class QuestionReaderService : IDisposable
    {
        private readonly Stream _stream;

        public QuestionReaderService(string path) =>
            _stream = new FileStream(path, FileMode.Open);

        public QuestionReaderService(Stream stream) =>
            _stream = stream;

        public IEnumerable<ParseQuestionModel> GetInputData()
        {
            string json;
            using (StreamReader reader = new StreamReader(_stream))
            {
                json = reader.ReadToEnd();
            }
            JToken result = JObject.Parse(json)["questions"];
            IEnumerable<JToken> results = result.Children();
            IEnumerable<ParseQuestionModel> questions = results.Select(s => s.ToObject<ParseQuestionModel>());
            return questions;
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
