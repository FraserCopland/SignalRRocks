using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRRocks.Hubs
{
    public class ChatHub : Hub {

        public async Task SendMessage(string user, string message) {
        // the ReceiveMessage method is called from the server to the client
        await Clients.Caller.SendAsync("ReceiveMessage", user, message);
    }
}
}