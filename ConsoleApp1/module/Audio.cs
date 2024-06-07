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
            SoundPlayer player = new SoundPlayer($@".\Sound\base.wav");
            player.Load();
            player.Play();
        }
        public void playCrit()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\crit.wav");
            player.Load();
            player.Play();
        }
        public void playInnn()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\tavern.wav");
            player.Load();
            player.Play();
        }
        public void playWoods()
        {
            SoundPlayer player = new SoundPlayer($@".\forest.wav");
            player.Load();
            player.Play();
        }
        public void playTown()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\city.wav");
            player.Load();
            player.Play();
        }
        public void playHorse()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\horse.wav");
            player.Load();
            player.Play();
        }
        public void playBubbles()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\bubbles.wav");
            player.Load();
            player.Play();
        }
        public void playIntro()
        {
            SoundPlayer player = new SoundPlayer(@"..\Sound\intro.wav");
            player.Load();
            player.Play();
        }
        public void playWind()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\wind.wav");
            player.Load();
            player.Play();
        }
        public void playFall()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\fall.wav");
            player.Load();
            player.Play();
        }
        public void playCampfire()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\campfire.wav");
            player.Load();
            player.Play();
        }
        public void playDonjon()
        {
            SoundPlayer player = new SoundPlayer($@".\Sound\donjon.wav");
            player.Load();
            player.PlayLooping();
        }
    }
}
