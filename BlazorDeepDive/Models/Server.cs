using System.Globalization;

namespace BlazorDeepDive.Models
{
    public class Server
    {
        public Server()
        {
            int randomNumber = new Random().Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City {  get; set; }
        public bool IsOnline { get; set; }

    }
}
