using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fiches
{
    public class Nain : Hero
    {
        public override void Creation()
        {

            Race = "nain";
            Force = 6;
            Capcomb = 7;
            Crit = 1;
            Degat = 5;
            Agi = 3;
            Pv = 10;
            PvMax = Pv;
            Armure = 4;
            Gold = 10;
            Potion = 3;

            Console.WriteLine("Quel est le nom de votre personnage?");
            Nom = Console.ReadLine();

        }
    }
}
