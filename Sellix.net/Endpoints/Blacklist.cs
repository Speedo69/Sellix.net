using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Blacklist;

namespace Sellix.Net.Endpoints
{
    public class Blacklist
    {
        private readonly Sellix instance;

        public Blacklist(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<BlacklistRoot> GetBlacklist(string id) => ParseHelper.ParseResponse<BlacklistRoot>(RequestHelper.Get("/blacklists/" + id, instance).Result).Result;
        public Response<BlacklistList> GetBlacklists() => ParseHelper.ParseResponse<BlacklistList>(RequestHelper.Get("/blacklists", instance).Result).Result;
        public Response<UniqId> CreateBlacklist(Models.Blacklist.Blacklist blacklist) => RequestHelper.Post("/blacklists", instance, ParseHelper.ParseRequest(blacklist).Result).Result;
        public Response<UniqId> UpdateBlacklist(Models.Blacklist.Blacklist blacklist, string uniqueId) { blacklist.UniqueId = uniqueId; return UpdateBlacklist(blacklist); }
        public Response<UniqId> UpdateBlacklist(Models.Blacklist.Blacklist blacklist) => RequestHelper.Put("/blacklists/" + blacklist.UniqueId, instance, ParseHelper.ParseRequest(blacklist).Result).Result;
        public Response<object> DeleteBlacklist(string uniqueId) => RequestHelper.Delete("/blacklists/" + uniqueId, instance).Result;
        public Response<object> DeleteBlacklist(Models.Blacklist.Blacklist blacklist) => DeleteBlacklist(blacklist.UniqueId);
    }
}
