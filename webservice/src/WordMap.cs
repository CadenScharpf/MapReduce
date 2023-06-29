using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountServices.src
{
    [Serializable]
    public class WordMapItem
    {
        public string key { get; set; }
        public int value { get; set; }
    }

    [Serializable]
    public class WordMap
    {
        public List<WordMapItem> DataTable;
        public WordMap() { DataTable = new List<WordMapItem>(); }

        public void Insert(WordMapItem wordTableItem) { DataTable.Add(wordTableItem); }
    }

    [Serializable]
    public class ReducedWordMap
    {
        public Dictionary<string, int> DataTable;

        public ReducedWordMap() { DataTable = new Dictionary<string, int>(); }

        public void Insert(string key) {
            if (DataTable.ContainsKey(key)) { DataTable[key] = DataTable[key] + 1; return; } 
            DataTable.Add(key, 1);
        }

        public void Insert(string key, int n)
        {
            if (DataTable.ContainsKey(key)) { DataTable[key] = DataTable[key] + n; return; }
            DataTable.Add(key, n);
        }
        public WordMap toWordMap() {
            WordMap outputMap = new WordMap();
            foreach (string word in DataTable.Keys) { outputMap.Insert(new WordMapItem { key = word, value = DataTable[word] }); };
            return outputMap;
        }
    }
    [Serializable]
    public class WordMapCollection
    {
        public List<WordMap> DataTables = new List<WordMap>();
        public WordMapCollection() { DataTables = new List<WordMap>(); }
        public void Add(WordMap wordMap) { DataTables.Add(wordMap); return; }
        public WordMap Get(int i) { return DataTables[i]; }
    }


}
