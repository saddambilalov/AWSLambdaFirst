using Xunit;

namespace AWSLambdaFirst.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToAdminFullNameFunction()
        {
            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var response = function.FunctionHandler();

            Assert.Equal("Saddam Bilalov", response.Body);
        }
    }
}
