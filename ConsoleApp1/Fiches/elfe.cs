using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fiches
{
    public class Elfe :Hero
    {

        public override void Creation()
        {

            Race = "elfe";
            Force = 4;
            Capcomb = 8;
            Crit = 2;
            Degat = 3;
            Agi = 6;
            Pv = 8;
            PvMax = Pv;
            Armure = 2;
            Gold = 5;
            Acier = 0;
            Cuir = 0;
            Potion = 3;

            Console.WriteLine("Quel est le nom de votre personnage?");
            Nom = Console.ReadLine();
        }
    }
}
