using Microsoft.AspNetCore.SignalR;
using SignalRChat.controllers;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>(){
            {1, "Programación"},
            {2, "Juegos"},
            {3, "Anime"},
            {4, "Musica"}
        };
        public async Task SendMessage(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }
        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowWho", "Alguien se conecto");
        }

        public async Task AddRoom(String name)
        {
            int contador = Rooms.Count;
            contador++;
            Rooms.Add(contador, name);
            await Clients.All.SendAsync("NewRoom", contador, name);

        }
    }
}