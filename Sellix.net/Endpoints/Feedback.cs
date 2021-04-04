using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Feedback;
using System.Text.Json;

namespace Sellix.Net.Endpoints
{
    public class Feedback
    {
        private readonly Sellix instance;

        public Feedback(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<FeedbackRoot> GetFeedback(string uniqueId) => ParseHelper.ParseResponse<FeedbackRoot>(RequestHelper.Get("/feedback/" + uniqueId, instance).Result).Result;
        public Response<FeedbackList> GetFeedbacks() => ParseHelper.ParseResponse<FeedbackList>(RequestHelper.Get("/feedback", instance).Result).Result;
        public Response<UniqId> ReplyFeedback(string uniqueId, string reply) => RequestHelper.Post("/feedback/" + uniqueId, instance, JsonSerializer.Serialize(new { reply })).Result;
    }
}
