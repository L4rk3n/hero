using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fiches
{
    public abstract class Hero : Fiche
    {
        
        public int Gold { get; set; }
        public int Acier { get; set; }
        public int Cuir { get; set; }
        public int Potion { get; set; }


        public void AfficherInfos()
        {
            Console.WriteLine($"Race : {Race}, Nom : {Nom}");
            Console.WriteLine($" Capacité de combat : {Capcomb},Taux de critique : {Crit},Dégâts : {Degat}");
            Console.WriteLine($"Points de vie : {Pv},Niveau d'armure :{Armure}");
            Console.WriteLine($"Force : {Force},Agilité :{Agi}");
            Console.WriteLine($"Quantité d'or :{Gold},Quantité d'acier :{Acier},Quantité de cuir: {Cuir}");
            Console.Clear();
        }
    }
}
