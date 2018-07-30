using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Answers.Models;
using Newtonsoft.Json.Linq;

namespace Answers.DbInitilizers
{
    public class QuestionReaderService : IDisposable
    {
        private readonly Stream _stream;

        public QuestionReaderService(string path)
        {
            var assembly = typeof(Initializer).GetTypeInfo().Assembly;
            _stream = assembly.GetManifestResourceStream(path);
        }

        public IEnumerable<QuestionModel> GetInputData()
        {
            string json;
            using (StreamReader reader = new StreamReader(_stream))
            {
                json = reader.ReadToEnd();
            }
            JToken result = JObject.Parse(json)["QuestionModels"];
            IEnumerable<JToken> results = result.Children();
            IEnumerable<QuestionModel> questions = results.Select(s => s.ToObject<QuestionModel>());
            return questions;
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
