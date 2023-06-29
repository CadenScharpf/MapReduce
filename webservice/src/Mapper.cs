using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountServices.src;

namespace WordCountServices.src
{
    public static class Mapper
    {
        public static string Map(string data)
        {
            WordMap table = new WordMap();
            string[] words = data.Split(' ');
            foreach (string word in words)
            {
                table.Insert(new WordMapItem { key = word, value = 1 });
            }
            return JsonConvert.SerializeObject(table);
        }
    }
}
