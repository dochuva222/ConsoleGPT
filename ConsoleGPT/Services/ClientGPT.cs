using ConsoleGPT.Models;
using ConsoleGPT.Models.ChatGPTAPIModels;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT.Services
{
    public class ClientGPT
    {
        private List<ChatMessage> messages;
        private static string prefix = "тупая машина: ";
        public ClientGPT()
        {
            messages = new List<ChatMessage>();
            CustomConsole.Write("Hello i'm console gpt. Ask me about everything and i will try to help you.");
        }

        public ClientGPT(string systemMessage) : this()
        {
            messages.Add(new ChatMessage("system", systemMessage));
        }

        public async void Ask(string content)
        {
            if (!string.IsNullOrWhiteSpace(content))
            {
                var chatRequest = new ChatRequest();
                var chatMessage = new ChatMessage("user", content);
                messages.Add(chatMessage);
                chatRequest.Messages.AddRange(messages);
                var response = await NetManager.PostRequest(chatRequest);
                CustomConsole.Write(prefix + response["choices"].FirstOrDefault()["message"]["content"].ToString());
            }
        }
    }
}
