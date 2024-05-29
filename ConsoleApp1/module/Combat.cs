using ConsoleApp1.Dessins;
using ConsoleApp1.Fiches;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleApp1.module
{
    public class Combat 
    {
        
        public void Combatexe(Hero champion)
        {
            Console.Clear();
            
            int dechampion = 0;
            int demonstrex = 0;
            int degatchampion = 0;
            int degatmonstre = 0;
            string answer = " ";
            Pnj adversaire = new Pnj();
            loot gain = new loot();
            Dice dede = new Dice();
            Monstre monstrex = new Monstre();
            Audio player = new Audio();

            monstrex.Creation();
            adversaire.Dessinpnj(monstrex.Race);
            Console.WriteLine($"{monstrex.Nom} sort des hautes herbes !, le combat s'engage");

            do
            {
                monstrex.AfficherInfos();
                dechampion = dede.Rolldice(1,6);
                demonstrex = dede.Rolldice(1,6);
                Console.ForegroundColor = ConsoleColor.Green;
                if (champion.Capcomb + dechampion > monstrex.Capcomb + demonstrex)
                {
                    degatchampion = champion.Degat - monstrex.Armure < 0 ? 0 : champion.Degat - monstrex.Armure;
                    monstrex.Pv -= degatchampion;
                    Console.WriteLine($"Vous infligez {degatchampion} a {monstrex.Nom}");
                    if (dechampion > (6 - champion.Crit))
                    {
                        monstrex.Pv -= champion.Degat - monstrex.Armure;
                        Console.WriteLine($"+ {degatchampion} dégâts critiques");
                        player.playCrit();
                    }
                    else player.playNormal();
                }
                else Console.WriteLine("t'as tapé à côté faillot");
                Console.ForegroundColor = ConsoleColor.Red;
                if (monstrex.Pv >0)
                {
                    dechampion = dede.Rolldice(1, 6);
                    demonstrex = dede.Rolldice(1, 6);

                    if (monstrex.Capcomb + demonstrex > champion.Capcomb + dechampion)
                    {
                        degatmonstre = monstrex.Degat - champion.Armure < 0 ? 0 : monstrex.Degat - champion.Armure;
                        champion.Pv -= degatmonstre;
                        Console.WriteLine($"{monstrex.Nom} vous inflige {degatmonstre}dégâts");

                        if (demonstrex > (6 - monstrex.Crit))
                        {
                            champion.Pv -= degatmonstre;
                            Console.WriteLine($"+ {degatchampion} dégâts critiques");
                            player.playCrit();
                        }
                        else player.playNormal();
                    }
                    else Console.WriteLine("Vous esquivez le coup comme un champion");

                }
                Console.ResetColor();
                if (champion.Pv <1)
                {
                    Console.WriteLine("Vous succombez à vos blessures");
                    champion.Mort = true;
                }
                if (monstrex.Pv <1)
                {
                    Console.WriteLine($"Vous avez vaincu {monstrex.Nom} ");
                    monstrex.Mort = true;
                    gain.Lootexe(champion,monstrex.Race);
                }
                if (champion.Potion > 0)
                { 
                    do
                    {
                        Console.WriteLine($"Il vous reste {champion.Pv} points de vie");
                        Console.WriteLine($"Voulez vous prendre une potion ({champion.Potion})?o/n");
                        answer = Console.ReadLine();
                    } while ((answer != "o") && (answer != "n"));
                    if (answer == "o")
                    {
                        champion.Potion -= 1;
                        if (champion.Pv + 5 > champion.PvMax)
                        {
                            Console.WriteLine($"Vos points de vie ont atteint le maximum {champion.PvMax}");
                            champion.Pv = champion.PvMax;
                        }
                        else
                        {
                            champion.Pv += 5;
                        }

                    }
                    
                    { 

                    }
                }

            } while ((champion.Mort is false) && (monstrex.Mort is false));
        }

    }
}
