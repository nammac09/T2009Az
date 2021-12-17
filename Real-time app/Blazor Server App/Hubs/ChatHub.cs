using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Blazor_Server_App.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
