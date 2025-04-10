// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs;

public class ChatHub : Hub
{
	public async Task SendMessage(string user, string message)
	{
		// All clients will receive the same message
		//await Clients.All.SendAsync("ReceiveMessage", user, message);

		// The caller will receive a different message than the others
		//await Clients.Caller.SendAsync("ReceiveMessage", user, $"{message} [From yourself]");
		//await Clients.Others.SendAsync("ReceiveMessage", user, message);

		// Send a message only to the current connection
		await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, $"{message} [Private to you]");
		
		// Get user info from the context
	    var userName = Context.User?.Identity?.Name ?? "Anonymous";
	    await Clients.All.SendAsync("ReceiveMessage", userName, message);
	}
}
