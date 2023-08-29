using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameLibrary
{
    public class WordParsing
    {
        private readonly string wordsPath = "Words.txt";

        public string ParseWords(string wordsPath)
        {
            if (File.Exists(wordsPath))
            {
                return File.ReadAllText(wordsPath); 
            }
            else { return wordsPath; }
        }
        //public List<Char> StringToChars()
        //{
        //    List<Char> result = new List<Char>();

        //    string words = ParseWords(wordsPath);
        //    var wordSplit = words.Split("");
        //    foreach (var word in wordSplit)
        //    {

        //    }
        //}
    }
}
