using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Blacklist
{
    public class BlacklistList
    {
        [JsonPropertyName("blacklists")]
        public Blacklist[] Blacklists { get; set; }
    }
}
