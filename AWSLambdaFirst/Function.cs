using System.Collections.Generic;
using Amazon.Lambda.Core;
using AWSLambdaFirst.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaFirst
{
    public class Function
    {
        public Response FunctionHandler()
        {
            var headers = new Dictionary<string, string> { { "Access-Control-Allow-Origin", "*" } };

            return new Response
            {
                StatusCode = 200,
                Headers = headers,
                Body = "Saddam Bilalov"
            };
        }
    }
}
