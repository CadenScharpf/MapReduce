using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountServices.src
{
    public class Combiner
    {
        public static string Combine(string data)
        {
            WordMapCollection dataTables = JsonConvert.DeserializeObject<WordMapCollection>(data);
            ReducedWordMap reducedWordMap = new ReducedWordMap();
            foreach (WordMap wordMap in dataTables.DataTables)
            {
                foreach(WordMapItem word in wordMap.DataTable)
                {
                    reducedWordMap.Insert(word.key, word.value);
                }    
            }
            return JsonConvert.SerializeObject(reducedWordMap.toWordMap());
        }
    }
}