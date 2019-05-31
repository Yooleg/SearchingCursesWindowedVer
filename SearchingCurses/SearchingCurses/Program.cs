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
            var songLyrics = new SongLyrycs(artist:"Eminem", title:"Without me");
            var profoanityFinder = new ProfanityFinder();

            // var censored = profoanityFinder.Censore(songLyrics.lyrics);
            var vulgarAmount = profoanityFinder.CountBadWords(songLyrics.lyrics);
            Console.WriteLine(vulgarAmount);
            var dict = profoanityFinder.FindTopBadWords(songLyrics.lyrics);
            Console.WriteLine(profoanityFinder.GetBadWordsSummary(songLyrics));
            //Console.WriteLine(censored);

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

