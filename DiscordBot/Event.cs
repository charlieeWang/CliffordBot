using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Event
    {
        public async Task MessageCreatedHandler(DiscordClient s, MessageCreateEventArgs e)
        {
            if (e.Message.Content.ToLower().Equals("ping"))
                await e.Message.RespondAsync("pong");
        }
    }
}
