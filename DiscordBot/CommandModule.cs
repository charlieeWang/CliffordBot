using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Command("minus"), Aliases("-", "減")]
        public async Task Minus(CommandContext context, int number1, int number2)
        {
            await context.RespondAsync((number1 - number2).ToString());
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

        [Command("team"), Aliases("split", "分隊")]
        [Description("前後要加上引號，例如 .分隊 \" a b c d\"")]
        public async Task SplitTeam(CommandContext context, string input)
        {
            var members = input.Split(' ');

            if (members.Length < 2)
            {
                await context.RespondAsync("人太少ㄌ");
                return;
            }

            var i = 0;
            var result = "";
            var randomArray = members.OrderBy(x => random.Next()).ToArray();

            while(i < members.Length)
            {
                if(i < members.Length / 2)
                    result = result + "(1):" + randomArray[i] + "\n";
                else
                    result = result + "(2):" + randomArray[i] + "\n";

                i ++;
            }

            await context.RespondAsync(result);
        }
    }
}
