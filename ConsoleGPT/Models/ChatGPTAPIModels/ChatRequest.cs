using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT.Models.ChatGPTAPIModels
{
    public class ChatRequest
    {
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("messages")]
        public List<ChatMessage> Messages { get; set; }
        [JsonProperty("temperature")]
        public float Temperature { get; set; }

        public ChatRequest()
        {
            Messages = new List<ChatMessage>(); 
            Model = "gpt-3.5-turbo";
            Temperature = 0.7f;
        }

        //public string model { get; set; }
        //public string prompt { get; set; }
        //public int max_tokens { get; set; }
        //public int temperature { get; set; }
        //public int top_p { get; set; }
        //public int n { get; set; }
        //public bool stream { get; set; }
        //public object logprobs { get; set; }
        //public string stop { get; set; }


    }
}
