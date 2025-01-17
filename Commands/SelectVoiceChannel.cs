﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Dec.DiscordIPC.Commands.Interfaces;
using Dec.DiscordIPC.Commands.Payloads;
using Dec.DiscordIPC.Development;
using Dec.DiscordIPC.Entities;

namespace Dec.DiscordIPC.Commands {
    /// <summary>
    /// Used to join or leave a voice channel, group dm, or dm
    /// </summary>
    public class SelectVoiceChannel {
        [DiscordRPC("SELECT_VOICE_CHANNEL")]
        public class Args : IPayloadResponse<Data> {
            [JsonPropertyName("channel_id")]
            public string ChannelID { get; set; }
            
            [JsonPropertyName("timeout")]
            public int? Timeout { get; set; }
            
            [JsonPropertyName("force")]
            public bool? Force { get; set; }
        }
        
        public class Data {
            [JsonPropertyName("id")]
            public string ID { get; set; }
            
            [JsonPropertyName("guild_id")]
            public string GuildID { get; set; }
            
            [JsonPropertyName("name")]
            public string Name { get; set; }
            
            [JsonPropertyName("type")]
            public int? Type { get; set; }
            
            [JsonPropertyName("topic")]
            public string Topic { get; set; }
            
            [JsonPropertyName("bitrate")]
            public int? Bitrate { get; set; }
            
            [JsonPropertyName("user_limit")]
            public int? UserLimit { get; set; }
            
            [JsonPropertyName("position")]
            public int? Position { get; set; }
            
            [JsonPropertyName("voice_states")]
            public List<VoiceState> VoiceStates { get; set; }
            
            [JsonPropertyName("messages")]
            public List<Message> Messages { get; set; }
        }
    }
}
