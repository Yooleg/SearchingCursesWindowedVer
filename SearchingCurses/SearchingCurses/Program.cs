using System;
using System.Collections.Generic;
using System.Linq;
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
}

