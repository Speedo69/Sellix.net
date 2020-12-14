using System.Text.Json.Serialization;

namespace Sellix.net.Models.Feedback
{
    public class FeedbackList
    {
        [JsonPropertyName("feedback")]
        public Feedback[] Feedback { get; set; }
    }
}
