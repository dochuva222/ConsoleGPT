using ConsoleGPT.Models.ChatGPTAPIModels;
using ConsoleGPT.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT.Services
{
    public static class NetManager
    {
        static HttpClient httpClient;
        const string REQUEST_URI = "https://api.openai.com/v1/chat/completions";

        static NetManager()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.Default.BearerToken);
        }

        public static async Task<JObject> Get<T>(string controller)
        {
            var response = await httpClient.GetAsync(REQUEST_URI + controller);
            return new JObject(await response.Content.ReadAsStringAsync());
        }

        public static async Task<JObject> PostRequest(ChatRequest chatRequest)
        {
            var jsonData = JsonConvert.SerializeObject(chatRequest);
            var response = await httpClient.PostAsync(REQUEST_URI, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return JObject.Parse(await response.Content.ReadAsStringAsync());
        }


        //net manager and http client realization
    }
}
