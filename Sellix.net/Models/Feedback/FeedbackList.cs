using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Feedback
{
    public class FeedbackList
    {
        [JsonPropertyName("feedback")]
        public Feedback[] Feedback { get; set; }
    }
}
