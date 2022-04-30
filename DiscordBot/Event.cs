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
            var inputMessage = e.Message.Content.ToLower();
            
            if (e.Author.IsBot)
                return;

            switch (inputMessage)
            {
                case "ping":
                    await e.Message.RespondAsync("pong");
                    break;

                case "88888":
                    await e.Message.RespondAsync("88888");
                    break;

                case "請問":
                    await e.Message.RespondAsync("請問");
                    break;

                case "嫩":
                    await e.Message.RespondAsync("嫩");
                    break;

                case "可惡":
                    await e.Message.RespondAsync("可 可惡");
                    break;
            }
        }
    }
}
