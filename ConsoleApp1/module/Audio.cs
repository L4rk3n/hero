using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using ConsoleApp1.Fiches;


namespace ConsoleApp1.module
{
    public class Audio
    {
        public void playNormal()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\ConsoleApp1\Sound\base.wav");
            player.Load();
            player.Play();
        }
        public void playCrit()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\ConsoleApp1\Sound\crit.wav");
            player.Load();
            player.Play();
        }
        public void playInnn()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\ConsoleApp1\Sound\tavern.wav");
            player.Load();
            player.Play();
        }
        public void playWoods()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\ConsoleApp1\Sound\forest.wav");
            player.Load();
            player.Play();
        }
        public void playTown()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\ConsoleApp1\Sound\city.wav");
            player.Load();
            player.Play();
        }
        public void playHorse()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\Sound\horse.wav");
            player.Load();
            player.Play();
        }
        public void playBubbles()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\cedric.bouvier\Documents\hero\ConsoleApp1\Sound\bubbles.wav");
            player.Load();
            player.Play();
        }
    }
}
