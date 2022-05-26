using System.Collections.Generic;

namespace laba3.Serialization
{
    public class TextDictionary
    {
        public Dictionary<string, string> dictionary {get;}
        private string text;
        public TextDictionary(string text)
        {
            dictionary = new Dictionary<string, string>();
            this.text = text;
        }
        public void MakeDictionary(/*string text*/)
        {
            text = text.Replace("{", "");
            text = text.Replace("}", "");
            text = text.Replace("\r","");
            string[] itemArray = text.Split(',');
            foreach(var item in itemArray)
            {
                string[] s = item.Split(':');
                s[0] = s[0].Replace("'","");
                s[0] = s[0].Trim();
                s[1] = s[1].Trim();
                dictionary.Add(s[0], s[1]);
            }
        }
    }
}