using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            var webCache = new WebCache();

            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string> {
                "Lose Yourself",
                "Not Afraid",
                "Sing for the moment"
            };

            eminem.CalculateSwearAndWordCount();
            eminem.DisplayStatistics();
            //var songLyrics = new Song(artist:"Eminem", title:"Without me");
            //var profoanityFinder = new ProfanityFinder();

            
            //var vulgarAmount = profoanityFinder.CountBadWords(songLyrics.lyrics);
            //Console.WriteLine(vulgarAmount);
            
            //Console.WriteLine(profoanityFinder.GetBadWordsSummary(songLyrics));
            

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    public class WebCache
    {
        SQLiteConnection connection;
        public WebCache()
        {
            connection = new SQLiteConnection("Data Source=WebCache.sqlite;");
            connection.Open();

        }
        public void SaveInCache(string url, string data)
        {
            var sql = SQLiteConnection
        }
    }
}

