using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

using var cts = new CancellationTokenSource();
var bot = new TelegramBotClient("7515705847:AAFeapAqtl5GMWGsc-Yk4x1W-p66O3QA2Og", cancellationToken: cts.Token);
var me = await bot.GetMeAsync();
bot.OnError += OnError;
bot.OnMessage += OnMessage;

Console.WriteLine($"@{me.Username} is running... Press Enter to terminate");
Console.ReadLine();
cts.Cancel(); // stop the bot

// method to handle errors in polling or in your OnMessage/OnUpdate code
async Task OnError(Exception exception, HandleErrorSource source)
{
    Console.WriteLine(exception); // just dump the exception to the console
}
async Task OnMessage(Message msg, UpdateType type)
{
    if (msg.Text == "советы по созданию сайта")
    {
        await bot.SendTextMessageAsync(msg.Chat, "Используйте простые HTML-страницы с яркими фонами и мерцающими текстами. \n2. Добавьте много GIF-анимаций и ярких кнопок. \n3. Не забывайте про фреймы!");
    }
    if (msg.Text == "анимации")
    {
        await bot.SendTextMessageAsync(msg.Chat, "Для анимаций используйте мерцающие GIF-ки. Вы можете найти их на сайтах, таких как Giphy или Tenor. Добавьте их на свой сайт, чтобы сделать его более живым!");
    }
    if (msg.Text == "geo cities")
    {
        await bot.SendTextMessageAsync(msg.Chat, "GeoCities был популярным хостингом в 90-х. Попробуйте создать сайт с использованием таблиц для разметки и ярких цветовых схем!");
    }
}