using ConsoleGPT.Models;
using ConsoleGPT.Models.FakeGPTModels;
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
        const string SECRET_WORD = "switch to true chat gpt";
        const string dataPath = "LearnData\\";
        private ICollection<DataGPT> _data;
        private bool _isTrueChatGPT = false;

        public ClientGPT()
        {
            _data = GetDataGPT(dataPath);
            CustomConsole.Write("Hello i'm console gpt. Ask me about everything and i will try to help you.");
        }

        public ClientGPT(bool switcher)
        {
            _isTrueChatGPT = switcher;

        }

        private List<DataGPT> GetDataGPT(string path)
        {
            var data = new List<DataGPT>();
            var fileNames = Directory.GetFiles(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path)));
            foreach (var file in fileNames)
            {
                var dataText = File.ReadAllText(file);
                var dataGPT = JsonConvert.DeserializeObject<DataGPT>(dataText);
                data.Add(dataGPT);
            }

            return data;
        }

        //public void AskGPT(string question)
        //{
        //    if (question == SECRET_WORD)
        //    {
        //        _isTrueChatGPT = true;
        //    }

        //    if (!_isTrueChatGPT)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        public async void AskGPT(string question)
        {
           //var response = NetManager.Post<>("", )
        }

        private void AnswerGPT()
        {

        }
    }
}
