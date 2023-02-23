using Microsoft.AspNetCore.Mvc;

namespace SignalRChat.controllers
{
    public class ChatController : Controller
    {
        //public static int contador = 4;
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>(){
            {1, "Programación"},
            {2, "Juegos"},
            {3, "Anime"},
            {4, "Musica"}
        };

        public static void AddRoom(string name)
        {
            int contador = Rooms.Count;
            contador++;
            Rooms.Add(contador, name);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}