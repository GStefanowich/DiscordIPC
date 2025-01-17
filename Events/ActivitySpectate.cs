﻿using System.Text.Json.Serialization;
using Dec.DiscordIPC.Commands.Interfaces;
using Dec.DiscordIPC.Development;

namespace Dec.DiscordIPC.Events {
    /// <summary>
    /// Sent when the user clicks a Rich Presence spectate invite in chat to spectate a game
    /// </summary>
    public class ActivitySpectate {
        [DiscordRPC("ACTIVITY_SPECTATE")]
        public class Args : IDummyCommandArgs { }
        
        public class Data {
            [JsonPropertyName("secret")]
            public string Secret { get; set; }
        }
    }
}
