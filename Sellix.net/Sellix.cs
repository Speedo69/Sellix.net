using Sellix.Net.Endpoints;
using System.Net.Http;

namespace Sellix.Net
{
    public class Sellix
    {
        public readonly string ApiUrl;
        public readonly HttpClient HttpClient;
        #region Endpoints
        public readonly Blacklist Blacklist;
        public readonly Categories Categories;
        public readonly Cupon Cupon;
        public readonly Feedback Feedback;
        public readonly Orders Orders;
        public readonly Products Products;
        #endregion


        public Sellix(string secret, HttpClient httpClient, string apiUrl = "https://dev.sellix.io/v1")
        {
            ApiUrl = apiUrl;
            HttpClient = httpClient;
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", secret);
            Blacklist = new Blacklist(this);
            Categories = new Categories(this);
            Cupon = new Cupon(this);
            Feedback = new Feedback(this);
            Orders = new Orders(this);
            Products = new Products(this);
        }
    }
}
