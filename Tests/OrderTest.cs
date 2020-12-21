using Xunit;
using Sellix.Net;

namespace Tests
{
    public class OrderTest
    {
        [Fact]
        public void Test()
        {
            Sellix.Net.Sellix sellix = new Sellix.Net.Sellix(Token.Get, new System.Net.Http.HttpClient());
            var orders = sellix.GetOrders();
            Assert.Equal(200, orders.Status);
        }
    }
}
