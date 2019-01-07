using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{

    public class SentimentResponse
    {
        [JsonProperty(PropertyName = "documents")]
        public List<Sentiment> Sentiments { get; set; }
        public object errors { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public Detectedlanguage[] detectedLanguages { get; set; }
    }

    public class Detectedlanguage
    {
        public string name { get; set; }
        public string iso6391Name { get; set; }
        [JsonProperty(PropertyName = "score")]
        public static string Score { get; set; }
    }

}
