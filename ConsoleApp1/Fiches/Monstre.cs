using ConsoleApp1.module;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fiches
{
    public class Monstre :Fiche
    {
        Dice dede = new Dice();
        public override void Creation()
        {
            string[] racelist = new string[] { "soldat","squelette", "orc", "loup", "chauve-souris", "dragonnet", };
            Race = racelist[dede.Rolldice(1, racelist.Length)];
            Nom = Race + " 1 ";
            Force =2+ dede.Rolldice(1,6);
            Capcomb = 3 +dede.Rolldice(1, 3);
            Crit = dede.Rolldice(1, 2);
            Degat = 4+dede.Rolldice(1, 6);
            Agi = 2+dede.Rolldice(1, 6);
            Pv = 2+dede.Rolldice(1, 10);
            PvMax = Pv;
            Armure = dede.Rolldice(1, 3);
            bool Mort = false;
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Race : {Race}, Nom : {Nom}");
            Console.WriteLine($"Points de vie : {Pv},Niveau d'armure :{Armure}");
        }
    }
}
