// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs;

public class ChatHub : Hub
{
    // Store the last 3 messages in memory:
    // - Must be thread safe
    // - Must be static to be shared between all users
    private static readonly List<(string User, string Message)> LastMessages = new();
    private static readonly object LockObject = new();

    public async Task SendMessage(string user, string message)
    {
        // Add the new message to the list in a thread-safe manner
        lock (LockObject)
        {
            LastMessages.Add((user, message));

            // Keep only the last 3 messages
            if (LastMessages.Count > 3)
            {
                LastMessages.RemoveAt(0);
            }
        }

        // Send the message to the caller and others
        await Clients.Caller.SendAsync("ReceiveMessage", user, $"{message} [From yourself]");
        await Clients.Others.SendAsync("ReceiveMessage", user, message);
    }

    public override async Task OnConnectedAsync()
    {
        // Send the last 3 messages to the newly connected user
        lock (LockObject)
        {
            foreach (var (user, message) in LastMessages)
            {
                Clients.Caller.SendAsync("ReceiveMessage", user, message);
            }
        }

        await base.OnConnectedAsync();
    }
}