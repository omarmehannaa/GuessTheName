using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared.ProtocolModels;

namespace GuessTheNameServer.Networking
{
    public static class ProtocolHandler
    {
        // In Shared/ProtocolModels.cs
        public class GameCommand
        {
            [JsonProperty("action")]
            public string Action { get; set; } = string.Empty; // Initialize with empty

            [JsonProperty("data")]
            public string Data { get; set; } = string.Empty;
        }
    }
}
