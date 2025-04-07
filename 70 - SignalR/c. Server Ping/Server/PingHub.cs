// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs;

public class PingHub : Hub
{
    private static readonly Timer Timer = new(SendTimeToClients, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
    private static IHubContext<PingHub>? hubContext;

    public PingHub(IHubContext<PingHub> hubContext)
	{
		// HubContext should be used for sending messages to clients in code.
        // It is needed in Static methods.
		PingHub.hubContext = hubContext;
    }

    private static async void SendTimeToClients(object? state)
    {
        if (PingHub.hubContext != null)
        {
            var currentTime = DateTime.Now.ToLongTimeString();
            await hubContext.Clients.All.SendAsync("Ping", currentTime);
        }
    }
}
