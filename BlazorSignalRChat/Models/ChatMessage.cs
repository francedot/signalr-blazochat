using System.ComponentModel.DataAnnotations;

namespace BlazorSignalRChat.Models
{
    public class ChatMessage
    {
        public ChatMessage()
        {
        }

        public ChatMessage(string name, string message)
        {
            Name = name;
            Message = message;
        }

        public string Name { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
    }
}
