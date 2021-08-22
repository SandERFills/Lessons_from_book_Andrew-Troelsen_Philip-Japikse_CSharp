using System;

namespace LazyObjectInstantaition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun  with Lazy Instantiation");
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.Play();
            Console.ReadLine();
        }
    }
}
