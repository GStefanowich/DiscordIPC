﻿using System;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dec.DiscordIPC.Commands.Interfaces;
using Dec.DiscordIPC.Development;

namespace Dec.DiscordIPC {
    internal static class Extensions {
        public static T ToObject<T>(this JsonElement element) =>
            Json.Deserialize<T>(element.GetRawText());
        
        public static bool IsErrorResponse(this JsonElement element) {
            if (element.TryGetProperty("evt", out JsonElement evt))
                return evt.GetString() == "ERROR";
            return false;
        }
        
        public static string GetArgCommand(this ICommandArgs args) {
            Type type = args.GetType();
            return type.GetCustomAttribute<DiscordRPCAttribute>()?.Command ?? throw new ArgumentException("Payloads must have the DiscordRPC Attribute", nameof(args));
        }
    }
    
    internal class Util {
        public static bool Verbose { get; set; }
        
        public static void Log(string msg) {
            if (Util.Verbose)
                Console.WriteLine(msg);
        }
        
        public static void Log(string format, params object[] arg) {
            if (Util.Verbose)
                Console.WriteLine(format, arg);
        }
    }
    
    internal class Json {
        public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json);
        
        public static byte[] SerializeToBytes<T>(T obj) {
            return JsonSerializer.SerializeToUtf8Bytes(obj, new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });
        }
    }
}
