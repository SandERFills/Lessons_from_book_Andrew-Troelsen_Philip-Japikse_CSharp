using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantaition
{
    class Song
    {
        public string Artist { get; set; }
        public string TrackName { get; set; }
        public double TrackLenght { get; set; }

    }
    class AllTracks
    {
        private Song[] allsongs = new Song[10000];
        public AllTracks()
        {
            Console.WriteLine("Filling up the songs");
        }
    }
    class MediaPlayer
    {
        public void Play() { Console.WriteLine("Music play"); }
        public void Stop() { Console.WriteLine("Music stop"); }
        public void Pause() { Console.WriteLine("Music pause"); }
        private Lazy<AllTracks> allTracks = new Lazy<AllTracks>(()=> {
            Console.WriteLine("All tacks add");
            return new AllTracks();
        });
        public AllTracks GetAllTracks()
        {
            return allTracks.Value;
        }
    }
}
