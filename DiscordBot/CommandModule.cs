using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class CommandModule : BaseCommandModule
    {
        Random random = new Random();

        [Command("test")]
        public async Task TestCommand(CommandContext context, string input)
        {
            await context.RespondAsync("input: " + input);
        }

        [Command("sum"), Aliases("add", "+", "加")]
        public async Task SumUp(CommandContext context, int number1, int number2)
        {
            await context.RespondAsync((number1 + number2).ToString());
        }

        [Command("multiply"), Aliases("*", "乘")]
        public async Task Multiply(CommandContext context, int number1, int number2)
        {
            await context.RespondAsync((number1*number2).ToString());
        }

        [Command("choose"), Aliases("which", "二選一")]
        public async Task HelpMeChoose(CommandContext context, string option1, string option2)
        {
            var result = random.Next(0, 2) == 0 ? option1 : option2;
            await context.RespondAsync(result);
        }
    }
}
