using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Coupons;

namespace Sellix.Net.Endpoints
{
    public class Cupon
    {
        private readonly Sellix instance;

        public Cupon(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<CouponRoot> GetCoupon(string uniqueId) => ParseHelper.ParseResponse<CouponRoot>(RequestHelper.Get(" /coupons/" + uniqueId, instance).Result).Result;
        public Response<CouponList> GetCoupons() => ParseHelper.ParseResponse<CouponList>(RequestHelper.Get("/coupons", instance).Result).Result;
        public void CreateCoupon(Coupon coupon) => RequestHelper.Post("/coupons", instance, ParseHelper.ParseRequest(coupon).Result);
        public void UpdateCoupon(Coupon coupon) => RequestHelper.Put("/coupons/", instance, ParseHelper.ParseRequest(coupon).Result);
        public void DeleteCoupon(string uniqueId) => RequestHelper.Delete("/coupons/" + uniqueId, instance);
    }
}
