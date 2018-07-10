using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileWordsCounter
{
    public class TextProcessor
    {
        public static Dictionary<string, int> GetWordsAndCountsFromText(string text)
        {
            Regex pattern = new Regex("\\w+");
            MatchCollection matches = pattern.Matches(text);
            Dictionary<string, int> wordsAndCounts = new Dictionary<string, int>();
            foreach (Match m in matches)
            {
                if (!wordsAndCounts.ContainsKey(m.Value))
                    wordsAndCounts.Add(m.Value, 1);
                else
                {
                    wordsAndCounts[m.Value] += 1;
                }
            }
            return wordsAndCounts;
        } 
    }
}
