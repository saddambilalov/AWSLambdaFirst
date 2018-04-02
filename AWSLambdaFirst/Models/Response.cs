using System.Collections.Generic;
using Newtonsoft.Json;

namespace AWSLambdaFirst.Models
{
    public class Response
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}