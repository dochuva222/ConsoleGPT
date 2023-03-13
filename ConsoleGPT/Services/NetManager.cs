using ConsoleGPT.Models.ChatGPTAPIModels;
using ConsoleGPT.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT.Services
{
    public static class NetManager
    {
        static HttpClient httpClient;
        const string REQUEST_URI = "https://api.openai.com/v1/chat/completions/";

        static NetManager()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", Settings.Default.BearerToken);
        }

        public static async Task<T> Get<T>(string controller)
        {
            var response = await httpClient.GetAsync(REQUEST_URI + controller);
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

        }

        public static async Task<T> PostRequest<T>(RequestParameters parameters)
        {
            var jsonData = JsonConvert.SerializeObject(parameters);
            var response = await httpClient.PostAsync(REQUEST_URI,
                                                      new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }

        public static async Task<T> Put<T, R>(string controller, R data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var response = await httpClient.PutAsync(REQUEST_URI + controller,
                                                     new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        //net manager and http client realization
    }
}
