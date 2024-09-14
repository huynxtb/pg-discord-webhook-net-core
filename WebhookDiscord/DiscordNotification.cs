using RestSharp;

namespace WebhookDiscord;

public static class DiscordNotification
{
    public static async Task SendMessageAsync(
        string webhookUrl,
        string userName,
        string avatarUrl,
        string title,
        DiscordColor color,
        string titleUrl,
        string content)
    {
        var client = new RestClient(webhookUrl);
        var request = new RestRequest() { Method = Method.Post };

        request.AddJsonBody(
            new
            {
                username = userName,
                avatar_url = avatarUrl,
                embeds = new List<object>()
                {
                    new
                    {
                        title = title.ToUpper(),
                        color = color,
                        url = titleUrl,
                        description = content
                    }
                }
            });
        var response = await client.ExecuteAsync(request);
    }
}