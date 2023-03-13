using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT.Models.FakeGPTModels
{
    public class DataGPT
    {
        public List<string> Tags { get; set; }
        public List<string> Content { get; set; }
        
        public DataGPT() 
        {

        }

        public DataGPT(List<string> tags, List<string> content)
        {
            Tags = tags;
            Content = content;
        }
    }
}
