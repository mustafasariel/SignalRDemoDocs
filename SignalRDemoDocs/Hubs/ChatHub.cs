using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemoDocs.Hubs
{
    public class ChatHub:Hub
    {
        // Hub sınıfı bağlantıları, grupları ve mesajlaşmayı yönetir.
        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
       
    }
}
