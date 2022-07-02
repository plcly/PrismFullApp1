using PrismFullApp1.Services.Interfaces;

namespace PrismFullApp1.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
