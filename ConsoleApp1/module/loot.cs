using ConsoleApp1.Fiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.module
{
    public class loot 
    {
        public void Lootexe(Hero champion, string raceMonstre)
        {
            int cadeau = 0;
            Dice dede = new Dice();
            cadeau = dede.Rolldice(1, 6);
            champion.Gold += cadeau; ;
            Console.WriteLine($"Vous lootez {cadeau} or");
            switch ( raceMonstre ) 
            {
                case "soldat":
                    cadeau = dede.Rolldice(1, 6); 
                    champion.Acier += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} acier");
                    break;
                case "squelette":
                    cadeau = dede.Rolldice(1, 6);
                    champion.Acier += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} acier");
                    break;
                case "orc":
                    cadeau = dede.Rolldice(1, 6);
                    champion.Acier += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} acier");
                    break;
                case "loup":
                    cadeau = dede.Rolldice(1, 6);
                    champion.Cuir += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} cuir");
                    break;
                case "chauve-souris":
                    cadeau = dede.Rolldice(1, 6);
                    champion.Cuir += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} cuir");
                    break;
                case "dragonnet":
                    cadeau = dede.Rolldice(1, 6);
                    champion.Cuir += cadeau;
                    Console.WriteLine($"Vous lootez {cadeau} cuir");
                    break;
            }
        }
    }
}
