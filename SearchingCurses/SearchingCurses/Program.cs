using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCurses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songLyrics = new SongLyrycs(artist:"Shakira", title:"Nada");
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    class SongLyrycs
    {
        private string artist;
        private string title;

        public SongLyrycs(string artist, string title)
        {
            var browser = new WebClient();
            var url = "https://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}

