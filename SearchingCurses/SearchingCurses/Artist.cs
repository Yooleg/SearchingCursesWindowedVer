﻿using System;
using System.Collections.Generic;

namespace SearchingCurses
{
    class Artist
    {
        public string name;
        public List<string> songTitles;

        public int wordCount;
        public int swearCount;
        

        public Artist(string name)
        {
            this.name = name;
        }

        public void CalculateSwearAndWordCount()
        {
            var profanityFinder = new ProfanityFinder();
            wordCount = 0;
            swearCount = 0;
            
            foreach (var title in songTitles)
            {
                var song = new Song(name, title);
                swearCount += profanityFinder.CountBadWords(song.lyrics);
                wordCount += song.CountWords();
            }
        }
        
        public void DisplayStatistics()
        {
            int profanityIndex = 0;
            if(swearCount != 0)profanityIndex = wordCount / swearCount;
            Console.WriteLine("For " + name + " every " + profanityIndex + " word is a swear word.");
        }
        
        public int GetProfanityIndex()
        {
            if (swearCount == 0) return 0;
            return wordCount / swearCount;
        }

    }
}

