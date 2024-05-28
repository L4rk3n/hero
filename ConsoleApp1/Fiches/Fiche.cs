using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fiches
{
    public abstract class Fiche
    {
        public string Race { get; set; }
        public string Nom { get; set; }
        public int Force { get; set; }
        public int Capcomb { get; set; }
        public int Crit { get; set; }
        public int Degat { get; set; }
        public int Agi { get; set; }
        public int Pv { get; set; }
        public int Armure { get; set; }
        public bool Mort { get; set; }
        public abstract void Creation();
    }
    
}
