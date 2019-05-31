using System;
using System.Collections.Generic;
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
                "Sing for the moment"
            };

            eminem.ShowProfanityStats();
            //var songLyrics = new Song(artist:"Eminem", title:"Without me");
            //var profoanityFinder = new ProfanityFinder();

            
            //var vulgarAmount = profoanityFinder.CountBadWords(songLyrics.lyrics);
            //Console.WriteLine(vulgarAmount);
            
            //Console.WriteLine(profoanityFinder.GetBadWordsSummary(songLyrics));
            

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    class Artist
    {
        public string name;
        public List<string> songTitles;

        public Artist(string name)
        {
            this.name = name;
        }

        public void ShowProfanityStats()
        {
            var profanityFinder = new ProfanityFinder();
            foreach (var title in songTitles)
            {

                var song = new Song(name, title);
                var profanitiesAmount = profanityFinder.CountBadWords(song.lyrics);
                Console.WriteLine(song.title + ": " + profanitiesAmount);
            }
        }
    }
}

