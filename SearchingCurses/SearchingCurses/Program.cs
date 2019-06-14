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
            
            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string> {
                "Lose Yourself",
                "Not Afraid",
                "Sing for the moment",
                "Without me",
                "The Real Slim Shady",
                "Stan",
                "Rap God",
                "asdasdasdasda",
                "Cleanin' Out My Room",
                "It's Ok",
                "I'm Shady",
            };

            //var liroy = new Artist("Liroy");
            //liroy.songTitles = new List<string>
            //{


            //};

            eminem.CalculateSwearAndWordCount();
            eminem.DisplayStatistics();

            //liroy.CalculateSwearAndWordCount();
            //liroy.DisplayStatistics();


            //var songLyrics = new Song(artist:"Eminem", title:"Without me");
            //var profoanityFinder = new ProfanityFinder();


            //var vulgarAmount = profoanityFinder.CountBadWords(songLyrics.lyrics);
            //Console.WriteLine(vulgarAmount);

            //Console.WriteLine(profoanityFinder.GetBadWordsSummary(songLyrics));


            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

