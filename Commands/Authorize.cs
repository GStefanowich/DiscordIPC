﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Dec.DiscordIPC.Commands.Payloads;
using Dec.DiscordIPC.Development;

namespace Dec.DiscordIPC.Commands {
    /// <summary>
    /// Used to authorize a new client with your app
    /// </summary>
    public class Authorize {
        [DiscordRPC("AUTHORIZE", false)]
        public class Args : IPayloadResponse<Data> {
            [JsonPropertyName("scopes")]
            public List<string> Scopes { get; set; }
            
            [JsonPropertyName("client_id")]
            public string ClientID { get; set; }
            
            [JsonPropertyName("rpc_token")]
            public string RPCToken { get; set; }
            
            [JsonPropertyName("username")]
            public string Username { get; set; }
            
            [JsonPropertyName("callback_url")]
            public string CallbackURL { get; set; }
        }
        
        public class Data {
            [JsonPropertyName("code")]
            public string Code { get; set; }
        }
    }
}
