using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace WordCountServices.src
{
    public static class Reducer
    {
        public static string Reduce(string data)
        {
            //data = HttpHelpers.GetResponseBody("http://localhost:55974/Service1.svc/Map/Students across Arizona participate in a statewide robotics hackathon accross arizona arizona a a a in");
            WordMap inputMap = JsonConvert.DeserializeObject<WordMap>(data);
            ReducedWordMap reductionMap = new ReducedWordMap();
            WordMap outputMap = new WordMap();
            foreach (WordMapItem wordMapItem in inputMap.DataTable) {reductionMap.Insert(wordMapItem.key);}
            foreach (string word in reductionMap.DataTable.Keys) { outputMap.Insert(new WordMapItem { key = word, value = reductionMap.DataTable[word] }); };

            return JsonConvert.SerializeObject(outputMap);
        }
    }
}
