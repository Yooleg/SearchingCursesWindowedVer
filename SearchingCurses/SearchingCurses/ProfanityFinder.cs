using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SearchingCurses
{
    internal class ProfanityFinder
    {
        private string[] badWords;

        public ProfanityFinder()
        {
            var dictFile = File.ReadAllText("../profanities.txt");
            dictFile = dictFile.Replace("*","");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badWords = dictFile.Split(new []{"\",\""}, StringSplitOptions.None);
            
        }

        public string Censore(string text)
        {
            foreach (var word in badWords)
            {
                text = RemoveBadWord(text, word);
            }
            return text;
        }

  

        public int CountBadWords(string text)
        { 
            var vulgarAmount = 0;
        
            foreach (var word in badWords)
            {
                if (text.Contains(word))
                    vulgarAmount = vulgarAmount + 1;
             
            }
            return vulgarAmount;
        }

        public Dictionary<string, int> FindTopBadWords(string lyrics)
        {
            var dict = new Dictionary<string, int>();
               
            foreach (var word in badWords)
            {
                int occurrancesOfWord = CalcOccurances(word, lyrics);
                if (occurrancesOfWord > 0)
                    dict[word] = occurrancesOfWord;
            }
            return dict;
        }

        int CalcOccurances(string word, string lyrics)
        {
            return Regex.Matches(word, lyrics).Count;
        }

        public string GetBadWordsSummary(SongLyrycs song)
        {
            var summary = "";

            var badWordsAmount = FindTopBadWords(song.lyrics);

                foreach (var sth in badWordsAmount)
            {
                summary = summary + "\n" + sth.Key + " - " + sth.Value;
            }

                return summary;
        }

        private static string RemoveBadWord(string text, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(text, pattern, "___", RegexOptions.IgnoreCase);
            
        }
    }
}

