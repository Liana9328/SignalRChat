using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    // Create the Hub
    public class ChatHub : Hub
    {
        // Clients can call those public methods
        public async Task SendMessage(string user, string message)
        {
            var connectionId = Context.ConnectionId;
            var agentNumber = Context.GetHttpContext().Request.Query["agentNumber"];
            
            // call client-side method: ReceiveMessage(string user, string message)
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
