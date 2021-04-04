using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Sellix.Net;

namespace Tests
{
    public class FeedbackTest
    {
        [Fact]
        public void Test()
        {
            var sellix = new Sellix.Net.Sellix(Token.Get, new System.Net.Http.HttpClient());
            var response = sellix.Feedback.GetFeedbacks();
            Assert.Equal(200, response.Status);
            Assert.NotNull(response.Data.Feedback);
        }
    }
}
