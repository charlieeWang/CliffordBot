using DiscordBot.Models;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Bot
    {
        private DiscordClient discordClient;
        private CommandsNextExtension commands;

        public Bot()
        {
            var jsonConfig = GetJsonConfig();

            var discordConfig = new DiscordConfiguration()
            {
                Token = jsonConfig.Token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            };

            var commandConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { jsonConfig.Prefix },
                EnableMentionPrefix = true
            };

            discordClient = new DiscordClient(discordConfig);
            commands = discordClient.UseCommandsNext(commandConfig);
        }

        public async Task RunAsync()
        {
            discordClient.MessageCreated += new Event().MessageCreatedHandler;
            commands.RegisterCommands<CommandModule>();

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }

        private JsonConfig GetJsonConfig()
        {
            using (var reader = new StreamReader(@"..\..\..\doc\config.json"))
            {
                var read = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<JsonConfig>(read);
            }
        }
    }
}
