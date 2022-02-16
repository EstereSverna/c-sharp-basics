using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>();
            sounds.Add(new Parrot());
            sounds.Add(new Firework());
            sounds.Add(new Radio());
            sounds.Add(new Parrot());
            sounds.Add(new Firework());

            foreach(var sound in sounds)
            {
                sound.PlaySound();
            }
        }
    }
}