﻿using Dec.DiscordIPC.Entities;

namespace Dec.DiscordIPC.Events {
    public class ActivityJoinRequest {
        // No arguments; dummy
        public class Args { }

        public class Data {
            public User user { get; set; }
        }
    }
}
