using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace Server.Hubs;

public class ChatHub : Hub
{
    // Store the last 3 messages in a thread-safe queue
    private static readonly ConcurrentQueue<(string User, string Message)> LastMessages = new();

    public async Task SendMessage(string user, string message)
    {
        // Add the new message to the queue
        LastMessages.Enqueue((user, message));

        // Remove the oldest message if the queue exceeds 3 messages
        while (LastMessages.Count > 3)
        {
            LastMessages.TryDequeue(out _);
        }

        // Send the message to the caller and others
        await Clients.Caller.SendAsync("ReceiveMessage", user, $"{message} [From yourself]");
        await Clients.Others.SendAsync("ReceiveMessage", user, message);
    }

    public override async Task OnConnectedAsync()
    {
        // Send the last 3 messages to the newly connected user
        foreach (var (user, message) in LastMessages)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }

        await base.OnConnectedAsync();
    }
}