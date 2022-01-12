using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Models
{
    public class JsonConfig
    {
        [JsonProperty("prefix")]
        public string Prefix;

        [JsonProperty("token")]
        public string Token;
    }
}
