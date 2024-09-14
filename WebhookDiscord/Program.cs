using WebhookDiscord;

var webhookURL = "https://discord.com/api/webhooks/1051086827349610576/4-3aiRLUFfW4nZwD9hk1aaqx3pGT_2Gls1Fc1LWQkmFZneYHJ3BtHgPAS77WM08g_03g";
var userName = "Code Mega";
var avatarURL = "https://i.imgur.com/LIorKnU.jpg";
var title = "Chào các bạn!";
var color = DiscordColor.Yellow;
var titleURL = "https://code-mega.com";
var content = "Welcome to my chanel!!! \n Have a nice day \n **Code Mega**";

await DiscordNotification.SendMessageAsync(webhookURL, userName, avatarURL, title, color, titleURL, content);