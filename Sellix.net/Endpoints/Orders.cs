using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Orders;

namespace Sellix.Net.Endpoints
{
    public class Orders
    {
        private readonly Sellix instance;

        public Orders(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<OrderRoot> GetOrder(string uniqid) => ParseHelper.ParseResponse<OrderRoot>(RequestHelper.Get("/orders/" + uniqid, instance).Result).Result;
        public Response<OrderList> GetOrders() => ParseHelper.ParseResponse<OrderList>(RequestHelper.Get("/orders", instance).Result).Result;
    }
}
